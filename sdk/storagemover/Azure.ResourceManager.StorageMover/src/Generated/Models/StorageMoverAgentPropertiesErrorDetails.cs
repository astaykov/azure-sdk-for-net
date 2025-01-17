// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The StorageMoverAgentPropertiesErrorDetails. </summary>
    public partial class StorageMoverAgentPropertiesErrorDetails
    {
        /// <summary> Initializes a new instance of StorageMoverAgentPropertiesErrorDetails. </summary>
        internal StorageMoverAgentPropertiesErrorDetails()
        {
        }

        /// <summary> Initializes a new instance of StorageMoverAgentPropertiesErrorDetails. </summary>
        /// <param name="code"> Error code reported by Agent. </param>
        /// <param name="message"> Expanded description of reported error code. </param>
        internal StorageMoverAgentPropertiesErrorDetails(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Error code reported by Agent. </summary>
        public string Code { get; }
        /// <summary> Expanded description of reported error code. </summary>
        public string Message { get; }
    }
}
