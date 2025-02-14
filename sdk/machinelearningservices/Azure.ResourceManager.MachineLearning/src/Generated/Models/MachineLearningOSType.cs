// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Compute OS Type
    /// Serialized Name: OsType
    /// </summary>
    public readonly partial struct MachineLearningOSType : IEquatable<MachineLearningOSType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MachineLearningOSType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MachineLearningOSType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LinuxValue = "Linux";
        private const string WindowsValue = "Windows";

        /// <summary>
        /// Linux
        /// Serialized Name: OsType.Linux
        /// </summary>
        public static MachineLearningOSType Linux { get; } = new MachineLearningOSType(LinuxValue);
        /// <summary>
        /// Windows
        /// Serialized Name: OsType.Windows
        /// </summary>
        public static MachineLearningOSType Windows { get; } = new MachineLearningOSType(WindowsValue);
        /// <summary> Determines if two <see cref="MachineLearningOSType"/> values are the same. </summary>
        public static bool operator ==(MachineLearningOSType left, MachineLearningOSType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MachineLearningOSType"/> values are not the same. </summary>
        public static bool operator !=(MachineLearningOSType left, MachineLearningOSType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MachineLearningOSType"/>. </summary>
        public static implicit operator MachineLearningOSType(string value) => new MachineLearningOSType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MachineLearningOSType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MachineLearningOSType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
