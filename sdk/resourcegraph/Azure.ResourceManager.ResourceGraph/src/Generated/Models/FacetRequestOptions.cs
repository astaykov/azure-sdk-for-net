// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary> The options for facet evaluation. </summary>
    public partial class FacetRequestOptions
    {
        /// <summary> Initializes a new instance of FacetRequestOptions. </summary>
        public FacetRequestOptions()
        {
        }

        /// <summary> The column name or query expression to sort on. Defaults to count if not present. </summary>
        public string SortBy { get; set; }
        /// <summary> The sorting order by the selected column (count by default). </summary>
        public FacetSortOrder? SortOrder { get; set; }
        /// <summary> Specifies the filter condition for the &apos;where&apos; clause which will be run on main query&apos;s result, just before the actual faceting. </summary>
        public string Filter { get; set; }
        /// <summary> The maximum number of facet rows that should be returned. </summary>
        public int? Top { get; set; }
    }
}
