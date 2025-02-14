// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.StorageMover;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> List of Project resources. </summary>
    internal partial class ProjectList
    {
        /// <summary> Initializes a new instance of ProjectList. </summary>
        internal ProjectList()
        {
            Value = new ChangeTrackingList<StorageMoverProjectData>();
        }

        /// <summary> Initializes a new instance of ProjectList. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> Request URL that can be used to query next page of containers. Returned when total number of requested containers exceed maximum page size. </param>
        internal ProjectList(IReadOnlyList<StorageMoverProjectData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<StorageMoverProjectData> Value { get; }
        /// <summary> Request URL that can be used to query next page of containers. Returned when total number of requested containers exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
