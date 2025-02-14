// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the public IP Sku. It can only be set with OrchestrationMode as Flexible. </summary>
    public partial class ComputePublicIPAddressSku
    {
        /// <summary> Initializes a new instance of ComputePublicIPAddressSku. </summary>
        public ComputePublicIPAddressSku()
        {
        }

        /// <summary> Initializes a new instance of ComputePublicIPAddressSku. </summary>
        /// <param name="name"> Specify public IP sku name. </param>
        /// <param name="tier"> Specify public IP sku tier. </param>
        internal ComputePublicIPAddressSku(ComputePublicIPAddressSkuName? name, ComputePublicIPAddressSkuTier? tier)
        {
            Name = name;
            Tier = tier;
        }

        /// <summary> Specify public IP sku name. </summary>
        public ComputePublicIPAddressSkuName? Name { get; set; }
        /// <summary> Specify public IP sku tier. </summary>
        public ComputePublicIPAddressSkuTier? Tier { get; set; }
    }
}
