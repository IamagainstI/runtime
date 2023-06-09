// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel.Composition.Primitives;
using System.Globalization;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.ReflectionModel
{
    internal abstract class ImportingItem
    {
        private readonly ContractBasedImportDefinition _definition;
        private readonly ImportType _importType;

        protected ImportingItem(ContractBasedImportDefinition definition, ImportType importType)
        {
            ArgumentNullException.ThrowIfNull(definition);

            _definition = definition;
            _importType = importType;
        }

        public ContractBasedImportDefinition Definition
        {
            get { return _definition; }
        }

        public ImportType ImportType
        {
            get { return _importType; }
        }

        public object? CastExportsToImportType(Export[] exports)
        {
            if (Definition.Cardinality == ImportCardinality.ZeroOrMore)
            {
                return CastExportsToCollectionImportType(exports);
            }
            else
            {
                return CastExportsToSingleImportType(exports);
            }
        }

        private Array CastExportsToCollectionImportType(Export[] exports)
        {
            ArgumentNullException.ThrowIfNull(exports);

            // Element type could be null if the actually import type of the member is not a collection
            // This particular case will end up failing when we set the member.
            Type elementType = ImportType.ElementType ?? typeof(object);

            Array array = Array.CreateInstance(elementType, exports.Length);

            for (int i = 0; i < array.Length; i++)
            {
                object? value = CastSingleExportToImportType(elementType, exports[i]);

                array.SetValue(value, i);
            }

            return array;
        }

        private object? CastExportsToSingleImportType(Export[] exports)
        {
            ArgumentNullException.ThrowIfNull(exports);

            if (exports.Length >= 2)
            {
                throw new Exception(SR.Diagnostic_InternalExceptionMessage);
            }

            if (exports.Length == 0)
            {
                return null;
            }

            return CastSingleExportToImportType(ImportType.ActualType, exports[0]);
        }

        private object? CastSingleExportToImportType(Type type, Export export)
        {
            if (ImportType.CastExport != null)
            {
                return ImportType.CastExport(export);
            }

            return Cast(type, export);
        }

        private object? Cast(Type type, Export export)
        {
            object? value = export.Value;

            if (!ContractServices.TryCast(type, value, out object? result))
            {
                throw new ComposablePartException(
                    SR.Format(
                        SR.ReflectionModel_ImportNotAssignableFromExport,
                        export.ToElement().DisplayName,
                        type.FullName),
                    Definition.ToElement());
            }

            return result;
        }
    }
}
