// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Blob container storage information. </summary>
    public partial class BlobShare
    {
        /// <summary> Initializes a new instance of BlobShare. </summary>
        public BlobShare()
        {
        }

        /// <summary> Initializes a new instance of BlobShare. </summary>
        /// <param name="sasUri"> SAS URI of Azure Storage Account Container. </param>
        internal BlobShare(Uri sasUri)
        {
            SasUri = sasUri;
        }

        /// <summary> SAS URI of Azure Storage Account Container. </summary>
        public Uri SasUri { get; set; }
    }
}
