// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Core.V1
{

    /// <summary>
    /// PodCondition contains details for the current condition of this pod.
    /// </summary>
    [OutputType]
    public sealed class PodCondition
    {
        /// <summary>
        /// Last time we probed the condition.
        /// </summary>
        public readonly string LastProbeTime;
        /// <summary>
        /// Last time the condition transitioned from one status to another.
        /// </summary>
        public readonly string LastTransitionTime;
        /// <summary>
        /// Human-readable message indicating details about last transition.
        /// </summary>
        public readonly string Message;
        /// <summary>
        /// Unique, one-word, CamelCase reason for the condition's last transition.
        /// </summary>
        public readonly string Reason;
        /// <summary>
        /// Status is the status of the condition. Can be True, False, Unknown. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Type is the type of the condition. More info: https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions
        /// 
        /// Possible enum values:
        ///  - `"ContainersReady"` indicates whether all containers in the pod are ready.
        ///  - `"Initialized"` means that all init containers in the pod have started successfully.
        ///  - `"PodScheduled"` represents status of the scheduling process for this pod.
        ///  - `"Ready"` means the pod is able to service requests and should be added to the load balancing pools of all matching services.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private PodCondition(
            string lastProbeTime,

            string lastTransitionTime,

            string message,

            string reason,

            string status,

            string type)
        {
            LastProbeTime = lastProbeTime;
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
        }
    }
}
