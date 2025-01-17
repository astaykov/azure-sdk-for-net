// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Operation status extended info for ILR provision action. </summary>
    public partial class OperationStatusProvisionILRExtendedInfo : OperationStatusExtendedInfo
    {
        /// <summary> Initializes a new instance of OperationStatusProvisionILRExtendedInfo. </summary>
        internal OperationStatusProvisionILRExtendedInfo()
        {
            ObjectType = "OperationStatusProvisionILRExtendedInfo";
        }

        /// <summary> Initializes a new instance of OperationStatusProvisionILRExtendedInfo. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryTarget"> Target details for file / folder restore. </param>
        internal OperationStatusProvisionILRExtendedInfo(string objectType, InstantItemRecoveryTarget recoveryTarget) : base(objectType)
        {
            RecoveryTarget = recoveryTarget;
            ObjectType = objectType ?? "OperationStatusProvisionILRExtendedInfo";
        }

        /// <summary> Target details for file / folder restore. </summary>
        internal InstantItemRecoveryTarget RecoveryTarget { get; }
        /// <summary> List of client scripts. </summary>
        public IReadOnlyList<ClientScriptForConnect> RecoveryTargetClientScripts
        {
            get => RecoveryTarget?.ClientScripts;
        }
    }
}
