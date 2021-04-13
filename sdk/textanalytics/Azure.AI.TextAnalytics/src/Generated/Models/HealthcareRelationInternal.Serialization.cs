// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class HealthcareRelationInternal
    {
        internal static HealthcareRelationInternal DeserializeHealthcareRelationInternal(JsonElement element)
        {
            HealthcareEntityRelationType relationType = default;
            IReadOnlyList<HealthcareRelationEntity> entities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("relationType"))
                {
                    relationType = new HealthcareEntityRelationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("entities"))
                {
                    List<HealthcareRelationEntity> array = new List<HealthcareRelationEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareRelationEntity.DeserializeHealthcareRelationEntity(item));
                    }
                    entities = array;
                    continue;
                }
            }
            return new HealthcareRelationInternal(relationType, entities);
        }
    }
}
