#!/usr/bin/env bash
: '
Scenarios:
  1. exclude paths are specified
      Will include all paths except the ones in the exclude list.
  2. include paths are specified
      Will only include paths specified in the list.
  3. exclude + include:
     a. `--combined` is passed:
      Will use the include paths, then use exclude paths on that set, and if that has any changes
      then a variable will be set to true.
     b. `--combined` is not passed (default):
      1st we evaluate changes for all paths except ones in excluded list. If we can not find
      any applicable changes like that, then we evaluate changes for included paths
      if any of these two finds changes, then a variable will be set to true.
  In order to consume this variable in a yaml pipeline, reference it via: $[ dependencies.<JobName>.outputs["<StepName>_<subset>.containschange"] ]

  Example:
  -difftarget ''HEAD^1'' -subset coreclr -includepaths ''src/libraries/System.Private.CoreLib/*'' -excludepaths ''src/libraries/*+src/installer/*''

  This example will include ALL path changes except the ones under src/libraries/*!System.Private.CoreLib/*
'

# Disable globbing in this bash script since we iterate over path patterns
set -f

# Stop script if unbound variable found (use ${var:-} if intentional)
set -u

# Stop script if command returns non-zero exit code.
# Prevents hidden errors caused by missing error code propagation.
set -e

usage()
{
  echo "Script that evaluates changed paths and emits an azure devops variable if the changes contained in the current HEAD against the difftarget meet the includepahts/excludepaths filters:"
  echo "  --difftarget <value>       SHA or branch to diff against. (i.e: HEAD^1, origin/main, 0f4hd36, etc.)"
  echo "  --excludepaths <value>     Escaped list of paths to exclude from diff separated by '+'. (i.e: 'src/libraries/*+'src/installer/*')"
  echo "  --includepaths <value>     Escaped list of paths to include on diff separated by '+'. (i.e: 'src/libraries/System.Private.CoreLib/*')"
  echo "  --combined                 Uses both exclude, and include paths"
  echo "  --subset                   Subset name for which we're evaluating in order to include it in logs"
  echo "  --azurevariable            Name of azure devops variable to create if change meets filter criteria"
  echo ""

  echo "Arguments can also be passed in with a single hyphen."
}

source="${BASH_SOURCE[0]}"

# resolve $source until the file is no longer a symlink
while [[ -h "$source" ]]; do
  scriptroot="$( cd -P "$( dirname "$source" )" && pwd )"
  source="$(readlink "$source")"
  # if $source was a relative symlink, we need to resolve it relative to the path where the
  # symlink file was located
  [[ $source != /* ]] && source="$scriptroot/$source"
done

scriptroot="$( cd -P "$( dirname "$source" )" && pwd )"
eng_root=`cd -P "$scriptroot/.." && pwd`

exclude_paths=()
include_paths=()
subset_name=''
azure_variable=''
diff_target=''
combined=false

while [[ $# > 0 ]]; do
  opt="$(echo "${1/#--/-}" | tr "[:upper:]" "[:lower:]")"
  case "$opt" in
    -help|-h)
      usage
      exit 0
      ;;
    -difftarget)
      diff_target=$2
      shift
      ;;
    -excludepaths)
      IFS='+' read -r -a tmp <<< $2
      exclude_paths+=(${tmp[@]})
      shift
      ;;
    -includepaths)
      IFS='+' read -r -a tmp <<< $2
      include_paths+=(${tmp[@]})
      shift
      ;;
    -combined)
      combined=true
      ;;
    -subset)
      subset_name=$2
      shift
      ;;
    -azurevariable)
      azure_variable=$2
      shift
      ;;
  esac

  shift
done

ci=true # Needed in order to use pipeline-logging-functions.sh
. "$eng_root/common/pipeline-logging-functions.sh"

# -- expected args --
# $@: git diff arguments
customGitDiff() {
  (
    set -x
    git diff -M -C -b --ignore-cr-at-eol --ignore-space-at-eol "$@"
  )
}

# runs git diff with supplied filter.
# -- exit codes --
# 0: No match was found
# 1: At least 1 match was found
#
# -- expected args --
# $@: filter string
probePathsWithExitCode() {
  local _filter=$@
  echo ""
  customGitDiff --exit-code --quiet $diff_target -- $_filter
}

# -- expected args --
# $@: filter string
printMatchedPaths() {
  local _subset=$subset_name
  local _filter=$@
  echo ""
  echo "----- Matching files for $_subset -----"
  customGitDiff --name-only $diff_target -- $_filter
}

probePaths() {
  local _subset=$subset_name
  local _azure_devops_var_name=$azure_variable
  local exclude_path_string=""
  local include_path_string=""
  local found_applying_changes=false

  if [[ ${#exclude_paths[@]} -gt 0 ]]; then
    echo ""
    echo "******* Collecting $_subset exclude paths *******";
    for _path in "${exclude_paths[@]}"; do
      echo "$_path"
      if [[ -z "$exclude_path_string" ]]; then
        exclude_path_string=":!$_path"
      else
        exclude_path_string="$exclude_path_string :!$_path"
      fi
    done
  fi

  if [[ ${#include_paths[@]} -gt 0 ]]; then
    echo ""
    echo "******* Collecting $_subset include paths *******";
    for _path in "${include_paths[@]}"; do
      echo "$_path"
      if [[ -z "$include_path_string" ]]; then
        include_path_string=":$_path"
      else
        include_path_string="$include_path_string :$_path"
      fi
    done
  fi

  if [[ "$combined" == "true" ]]; then
    # Try both include, and exclude
    # finds all the changes in include files, then excludes the exclude files
    local combined_path_string="$include_path_string $exclude_path_string"
    echo "******* Probing $_subset combined paths *******";
    if ! probePathsWithExitCode $combined_path_string; then
      found_applying_changes=true
      printMatchedPaths $combined_path_string
    fi
  else
    # First try exclude
    if [[ ${#exclude_paths[@]} -gt 0 ]]; then
      echo "******* Probing $_subset exclude paths *******";
      if ! probePathsWithExitCode $exclude_path_string; then
        found_applying_changes=true
        printMatchedPaths $exclude_path_string
      fi
    fi

    # if no changes found, then try include
    if [[ $found_applying_changes != true && ${#include_paths[@]} -gt 0 ]]; then
      echo "******* Probing $_subset include paths *******";
      if ! probePathsWithExitCode $include_path_string; then
        found_applying_changes=true
        printMatchedPaths $include_path_string
      fi
    fi
  fi

  if [[ $found_applying_changes == true ]]; then
    echo ""
    echo "Setting pipeline variable $_azure_devops_var_name=true"
    Write-PipelineSetVariable -name $_azure_devops_var_name -value true
  else
    echo ""
    echo "No changed files for $_subset"
  fi
}

probePaths
