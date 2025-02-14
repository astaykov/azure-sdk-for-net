// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> ExecAction describes a &quot;run in container&quot; action. </summary>
    public partial class AppInstanceExecAction : AppInstanceProbeAction
    {
        /// <summary> Initializes a new instance of AppInstanceExecAction. </summary>
        public AppInstanceExecAction()
        {
            Command = new ChangeTrackingList<string>();
            ProbeActionType = ProbeActionType.ExecAction;
        }

        /// <summary> Initializes a new instance of AppInstanceExecAction. </summary>
        /// <param name="probeActionType"> The type of the action to take to perform the health check. </param>
        /// <param name="command"> Command is the command line to execute inside the container, the working directory for the command is root (&apos;/&apos;) in the container&apos;s filesystem. The command is not run inside a shell, so traditional shell instructions (&apos;|&apos;, etc) won&apos;t work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy. </param>
        internal AppInstanceExecAction(ProbeActionType probeActionType, IList<string> command) : base(probeActionType)
        {
            Command = command;
            ProbeActionType = probeActionType;
        }

        /// <summary> Command is the command line to execute inside the container, the working directory for the command is root (&apos;/&apos;) in the container&apos;s filesystem. The command is not run inside a shell, so traditional shell instructions (&apos;|&apos;, etc) won&apos;t work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy. </summary>
        public IList<string> Command { get; }
    }
}
