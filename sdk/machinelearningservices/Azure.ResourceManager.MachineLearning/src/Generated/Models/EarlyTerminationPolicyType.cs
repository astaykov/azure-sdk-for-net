// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The EarlyTerminationPolicyType.
    /// Serialized Name: EarlyTerminationPolicyType
    /// </summary>
    internal readonly partial struct EarlyTerminationPolicyType : IEquatable<EarlyTerminationPolicyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EarlyTerminationPolicyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EarlyTerminationPolicyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BanditValue = "Bandit";
        private const string MedianStoppingValue = "MedianStopping";
        private const string TruncationSelectionValue = "TruncationSelection";

        /// <summary>
        /// Bandit
        /// Serialized Name: EarlyTerminationPolicyType.Bandit
        /// </summary>
        public static EarlyTerminationPolicyType Bandit { get; } = new EarlyTerminationPolicyType(BanditValue);
        /// <summary>
        /// MedianStopping
        /// Serialized Name: EarlyTerminationPolicyType.MedianStopping
        /// </summary>
        public static EarlyTerminationPolicyType MedianStopping { get; } = new EarlyTerminationPolicyType(MedianStoppingValue);
        /// <summary>
        /// TruncationSelection
        /// Serialized Name: EarlyTerminationPolicyType.TruncationSelection
        /// </summary>
        public static EarlyTerminationPolicyType TruncationSelection { get; } = new EarlyTerminationPolicyType(TruncationSelectionValue);
        /// <summary> Determines if two <see cref="EarlyTerminationPolicyType"/> values are the same. </summary>
        public static bool operator ==(EarlyTerminationPolicyType left, EarlyTerminationPolicyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EarlyTerminationPolicyType"/> values are not the same. </summary>
        public static bool operator !=(EarlyTerminationPolicyType left, EarlyTerminationPolicyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EarlyTerminationPolicyType"/>. </summary>
        public static implicit operator EarlyTerminationPolicyType(string value) => new EarlyTerminationPolicyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EarlyTerminationPolicyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EarlyTerminationPolicyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
