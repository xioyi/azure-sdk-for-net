// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class SearchRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (IncludeTotalResultCount != null)
            {
                writer.WritePropertyName("count");
                writer.WriteBooleanValue(IncludeTotalResultCount.Value);
            }
            if (Facets != null)
            {
                writer.WritePropertyName("facets");
                writer.WriteStartArray();
                foreach (var item in Facets)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Filter != null)
            {
                writer.WritePropertyName("filter");
                writer.WriteStringValue(Filter);
            }
            if (HighlightFields != null)
            {
                writer.WritePropertyName("highlight");
                writer.WriteStringValue(HighlightFields);
            }
            if (HighlightPostTag != null)
            {
                writer.WritePropertyName("highlightPostTag");
                writer.WriteStringValue(HighlightPostTag);
            }
            if (HighlightPreTag != null)
            {
                writer.WritePropertyName("highlightPreTag");
                writer.WriteStringValue(HighlightPreTag);
            }
            if (MinimumCoverage != null)
            {
                writer.WritePropertyName("minimumCoverage");
                writer.WriteNumberValue(MinimumCoverage.Value);
            }
            if (OrderBy != null)
            {
                writer.WritePropertyName("orderby");
                writer.WriteStringValue(OrderBy);
            }
            if (QueryType != null)
            {
                writer.WritePropertyName("queryType");
                writer.WriteStringValue(QueryType.Value.ToSerialString());
            }
            if (ScoringParameters != null)
            {
                writer.WritePropertyName("scoringParameters");
                writer.WriteStartArray();
                foreach (var item in ScoringParameters)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ScoringProfile != null)
            {
                writer.WritePropertyName("scoringProfile");
                writer.WriteStringValue(ScoringProfile);
            }
            if (SearchText != null)
            {
                writer.WritePropertyName("search");
                writer.WriteStringValue(SearchText);
            }
            if (SearchFields != null)
            {
                writer.WritePropertyName("searchFields");
                writer.WriteStringValue(SearchFields);
            }
            if (SearchMode != null)
            {
                writer.WritePropertyName("searchMode");
                writer.WriteStringValue(SearchMode.Value.ToSerialString());
            }
            if (Select != null)
            {
                writer.WritePropertyName("select");
                writer.WriteStringValue(Select);
            }
            if (Skip != null)
            {
                writer.WritePropertyName("skip");
                writer.WriteNumberValue(Skip.Value);
            }
            if (Top != null)
            {
                writer.WritePropertyName("top");
                writer.WriteNumberValue(Top.Value);
            }
            writer.WriteEndObject();
        }
        internal static SearchRequest DeserializeSearchRequest(JsonElement element)
        {
            SearchRequest result = new SearchRequest();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.IncludeTotalResultCount = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("facets"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Facets = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Facets.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("filter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlight"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HighlightFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightPostTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HighlightPostTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("highlightPreTag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.HighlightPreTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumCoverage"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.MinimumCoverage = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("orderby"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.OrderBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.QueryType = property.Value.GetString().ToQueryType();
                    continue;
                }
                if (property.NameEquals("scoringParameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ScoringParameters = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.ScoringParameters.Add(item.GetString());
                    }
                    continue;
                }
                if (property.NameEquals("scoringProfile"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ScoringProfile = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("search"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SearchText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchFields"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SearchFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("searchMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SearchMode = property.Value.GetString().ToSearchMode();
                    continue;
                }
                if (property.NameEquals("select"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Select = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skip"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Skip = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("top"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Top = property.Value.GetInt32();
                    continue;
                }
            }
            return result;
        }
    }
}