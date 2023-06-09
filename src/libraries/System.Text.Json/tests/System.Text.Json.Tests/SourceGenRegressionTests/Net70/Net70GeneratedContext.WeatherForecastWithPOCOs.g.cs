﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Source files represent a source generated JsonSerializerContext as produced by the .NET 7 SDK.
// Used to validate correctness of contexts generated by previous SDKs against the current System.Text.Json runtime components.
// Unless absolutely necessary DO NOT MODIFY any of these files -- it would invalidate the purpose of the regression tests.

// <auto-generated/>

#nullable enable annotations
#nullable disable warnings

// Suppress warnings about [Obsolete] member usage in generated code.
#pragma warning disable CS0618

namespace System.Text.Json.Tests.SourceGenRegressionTests.Net70
{
    public partial class Net70GeneratedContext
    {
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs>? _WeatherForecastWithPOCOs;
        /// <summary>
        /// Defines the source generated JSON serialization contract metadata for a given type.
        /// </summary>
        public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs> WeatherForecastWithPOCOs
        {
            get => _WeatherForecastWithPOCOs ??= Create_WeatherForecastWithPOCOs(Options, makeReadOnly: true);
        }
        
        private global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs> Create_WeatherForecastWithPOCOs(global::System.Text.Json.JsonSerializerOptions options, bool makeReadOnly)
        {
            global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs>? jsonTypeInfo = null;
            global::System.Text.Json.Serialization.JsonConverter? customConverter;
            if (options.Converters.Count > 0 && (customConverter = GetRuntimeProvidedCustomConverter(options, typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs))) != null)
            {
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateValueInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs>(options, customConverter);
            }
            else
            {
                global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs> objectInfo = new global::System.Text.Json.Serialization.Metadata.JsonObjectInfoValues<global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs>()
                {
                    ObjectCreator = static () => new global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs(),
                    ObjectWithParameterizedConstructorCreator = null,
                    PropertyMetadataInitializer = _ => WeatherForecastWithPOCOsPropInit(options),
                    ConstructorParameterMetadataInitializer = null,
                    NumberHandling = default,
                    SerializeHandler = WeatherForecastWithPOCOsSerializeHandler
                };
        
                jsonTypeInfo = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreateObjectInfo<global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs>(options, objectInfo);
            }
        
            if (makeReadOnly)
            {
                jsonTypeInfo.MakeReadOnly();
            }
        
            return jsonTypeInfo;
        }
        
        private static global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] WeatherForecastWithPOCOsPropInit(global::System.Text.Json.JsonSerializerOptions options)
        {
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[] properties = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo[7];
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.DateTimeOffset> info0 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.DateTimeOffset>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs),
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).Date,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).Date = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "Date",
                JsonPropertyName = null
            };
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo propertyInfo0 = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.DateTimeOffset>(options, info0);
            properties[0] = propertyInfo0;
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Int32> info1 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Int32>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs),
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).TemperatureCelsius,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).TemperatureCelsius = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "TemperatureCelsius",
                JsonPropertyName = null
            };
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo propertyInfo1 = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Int32>(options, info1);
            properties[1] = propertyInfo1;
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String> info2 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs),
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).Summary!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).Summary = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "Summary",
                JsonPropertyName = null
            };
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo propertyInfo2 = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.String>(options, info2);
            properties[2] = propertyInfo2;
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Generic.List<global::System.DateTimeOffset>> info3 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Generic.List<global::System.DateTimeOffset>>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs),
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).DatesAvailable!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).DatesAvailable = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "DatesAvailable",
                JsonPropertyName = null
            };
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo propertyInfo3 = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Generic.List<global::System.DateTimeOffset>>(options, info3);
            properties[3] = propertyInfo3;
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.HighLowTemps>> info4 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.HighLowTemps>>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs),
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).TemperatureRanges!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).TemperatureRanges = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "TemperatureRanges",
                JsonPropertyName = null
            };
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo propertyInfo4 = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.Collections.Generic.Dictionary<global::System.String, global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.HighLowTemps>>(options, info4);
            properties[4] = propertyInfo4;
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String[]> info5 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String[]>()
            {
                IsProperty = true,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs),
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).SummaryWords!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).SummaryWords = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "SummaryWords",
                JsonPropertyName = null
            };
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo propertyInfo5 = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.String[]>(options, info5);
            properties[5] = propertyInfo5;
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String> info6 = new global::System.Text.Json.Serialization.Metadata.JsonPropertyInfoValues<global::System.String>()
            {
                IsProperty = false,
                IsPublic = true,
                IsVirtual = false,
                DeclaringType = typeof(global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs),
                Converter = null,
                Getter = static (obj) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).SummaryField!,
                Setter = static (obj, value) => ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)obj).SummaryField = value!,
                IgnoreCondition = null,
                HasJsonInclude = false,
                IsExtensionData = false,
                NumberHandling = default,
                PropertyName = "SummaryField",
                JsonPropertyName = null
            };
        
            global::System.Text.Json.Serialization.Metadata.JsonPropertyInfo propertyInfo6 = global::System.Text.Json.Serialization.Metadata.JsonMetadataServices.CreatePropertyInfo<global::System.String>(options, info6);
            properties[6] = propertyInfo6;
        
            return properties;
        }
        
        // Intentionally not a static method because we create a delegate to it. Invoking delegates to instance
        // methods is almost as fast as virtual calls. Static methods need to go through a shuffle thunk.
        private void WeatherForecastWithPOCOsSerializeHandler(global::System.Text.Json.Utf8JsonWriter writer, global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs? value)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }
        
            writer.WriteStartObject();
            writer.WriteString(PropName_Date, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)value).Date);
            writer.WriteNumber(PropName_TemperatureCelsius, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)value).TemperatureCelsius);
            writer.WriteString(PropName_Summary, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)value).Summary);
            writer.WritePropertyName(PropName_DatesAvailable);
            ListDateTimeOffsetSerializeHandler(writer, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)value).DatesAvailable!);
            writer.WritePropertyName(PropName_TemperatureRanges);
            DictionaryStringHighLowTempsSerializeHandler(writer, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)value).TemperatureRanges!);
            writer.WritePropertyName(PropName_SummaryWords);
            StringArraySerializeHandler(writer, ((global::System.Text.Json.Tests.SourceGenRegressionTests.Net70.WeatherForecastWithPOCOs)value).SummaryWords!);
        
            writer.WriteEndObject();
        }
    }
}
