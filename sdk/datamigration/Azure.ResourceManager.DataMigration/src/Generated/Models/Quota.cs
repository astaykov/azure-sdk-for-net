// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes a quota for or usage details about a resource. </summary>
    public partial class Quota
    {
        /// <summary> Initializes a new instance of Quota. </summary>
        internal Quota()
        {
        }

        /// <summary> Initializes a new instance of Quota. </summary>
        /// <param name="currentValue"> The current value of the quota. If null or missing, the current value cannot be determined in the context of the request. </param>
        /// <param name="id"> The resource ID of the quota object. </param>
        /// <param name="limit"> The maximum value of the quota. If null or missing, the quota has no maximum, in which case it merely tracks usage. </param>
        /// <param name="name"> The name of the quota. </param>
        /// <param name="unit"> The unit for the quota, such as Count, Bytes, BytesPerSecond, etc. </param>
        internal Quota(double? currentValue, string id, double? limit, QuotaName name, string unit)
        {
            CurrentValue = currentValue;
            Id = id;
            Limit = limit;
            Name = name;
            Unit = unit;
        }

        /// <summary> The current value of the quota. If null or missing, the current value cannot be determined in the context of the request. </summary>
        public double? CurrentValue { get; }
        /// <summary> The resource ID of the quota object. </summary>
        public string Id { get; }
        /// <summary> The maximum value of the quota. If null or missing, the quota has no maximum, in which case it merely tracks usage. </summary>
        public double? Limit { get; }
        /// <summary> The name of the quota. </summary>
        public QuotaName Name { get; }
        /// <summary> The unit for the quota, such as Count, Bytes, BytesPerSecond, etc. </summary>
        public string Unit { get; }
    }
}
