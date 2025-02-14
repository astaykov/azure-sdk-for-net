// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchPrivateLinkServiceConnectionState : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToSerialString());
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static BatchPrivateLinkServiceConnectionState DeserializeBatchPrivateLinkServiceConnectionState(JsonElement element)
        {
            BatchPrivateLinkServiceConnectionStatus status = default;
            Optional<string> description = default;
            Optional<string> actionsRequired = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToBatchPrivateLinkServiceConnectionStatus();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
            }
            return new BatchPrivateLinkServiceConnectionState(status, description.Value, actionsRequired.Value);
        }
    }
}
