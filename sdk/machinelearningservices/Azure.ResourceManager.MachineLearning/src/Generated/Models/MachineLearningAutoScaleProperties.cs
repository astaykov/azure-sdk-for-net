// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Auto scale properties
    /// Serialized Name: AutoScaleProperties
    /// </summary>
    public partial class MachineLearningAutoScaleProperties
    {
        /// <summary> Initializes a new instance of MachineLearningAutoScaleProperties. </summary>
        public MachineLearningAutoScaleProperties()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningAutoScaleProperties. </summary>
        /// <param name="minNodeCount"> Serialized Name: AutoScaleProperties.minNodeCount. </param>
        /// <param name="isEnabled"> Serialized Name: AutoScaleProperties.enabled. </param>
        /// <param name="maxNodeCount"> Serialized Name: AutoScaleProperties.maxNodeCount. </param>
        internal MachineLearningAutoScaleProperties(int? minNodeCount, bool? isEnabled, int? maxNodeCount)
        {
            MinNodeCount = minNodeCount;
            IsEnabled = isEnabled;
            MaxNodeCount = maxNodeCount;
        }

        /// <summary> Serialized Name: AutoScaleProperties.minNodeCount. </summary>
        public int? MinNodeCount { get; set; }
        /// <summary> Serialized Name: AutoScaleProperties.enabled. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Serialized Name: AutoScaleProperties.maxNodeCount. </summary>
        public int? MaxNodeCount { get; set; }
    }
}
