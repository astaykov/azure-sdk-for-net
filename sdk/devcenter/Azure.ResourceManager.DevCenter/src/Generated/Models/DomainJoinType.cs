// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Active Directory join type. </summary>
    public readonly partial struct DomainJoinType : IEquatable<DomainJoinType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DomainJoinType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DomainJoinType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HybridAzureADJoinValue = "HybridAzureADJoin";
        private const string AzureADJoinValue = "AzureADJoin";

        /// <summary> HybridAzureADJoin. </summary>
        public static DomainJoinType HybridAzureADJoin { get; } = new DomainJoinType(HybridAzureADJoinValue);
        /// <summary> AzureADJoin. </summary>
        public static DomainJoinType AzureADJoin { get; } = new DomainJoinType(AzureADJoinValue);
        /// <summary> Determines if two <see cref="DomainJoinType"/> values are the same. </summary>
        public static bool operator ==(DomainJoinType left, DomainJoinType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DomainJoinType"/> values are not the same. </summary>
        public static bool operator !=(DomainJoinType left, DomainJoinType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DomainJoinType"/>. </summary>
        public static implicit operator DomainJoinType(string value) => new DomainJoinType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DomainJoinType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DomainJoinType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
