﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Security.KeyVault.Certificates
{
    internal class CertificateUpdateParameters : IJsonSerializable
    {
        private const string AttributesPropertyName = "attributes";
        private const string EnabledPropertyName = "enabled";
        private const string TagsPropertyName = "tags";

        private static readonly JsonEncodedText s_attributesPropertyNameBytes = JsonEncodedText.Encode(AttributesPropertyName);
        private static readonly JsonEncodedText s_enabledPropertyNameBytes = JsonEncodedText.Encode(EnabledPropertyName);
        private static readonly JsonEncodedText s_tagsPropertyNameBytes = JsonEncodedText.Encode(TagsPropertyName);

        public CertificateUpdateParameters(bool? enabled, IDictionary<string, string> tags)
        {
            Enabled = enabled;
            Tags = tags;
        }

        public bool? Enabled { get; private set; }

        public IDictionary<string, string> Tags { get; private set; }

        void IJsonSerializable.WriteProperties(Utf8JsonWriter json)
        {
            if (Enabled.HasValue)
            {
                json.WriteStartObject(s_attributesPropertyNameBytes);

                json.WriteBoolean(s_enabledPropertyNameBytes, Enabled.Value);

                json.WriteEndObject();
            }

            if (Tags != null)
            {
                json.WriteStartObject(s_tagsPropertyNameBytes);

                foreach (KeyValuePair<string, string> kvp in Tags)
                {
                    json.WriteString(kvp.Key, kvp.Value);
                }

                json.WriteEndObject();
            }
        }
    }
}