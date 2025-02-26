// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Outputs.Apps.V1
{

    /// <summary>
    /// DeploymentStrategy describes how to replace existing pods with new ones.
    /// </summary>
    [OutputType]
    public sealed class DeploymentStrategy
    {
        /// <summary>
        /// Rolling update config params. Present only if DeploymentStrategyType = RollingUpdate.
        /// </summary>
        public readonly Pulumi.Kubernetes.Types.Outputs.Apps.V1.RollingUpdateDeployment RollingUpdate;
        /// <summary>
        /// Type of deployment. Can be "Recreate" or "RollingUpdate". Default is RollingUpdate.
        /// 
        /// Possible enum values:
        ///  - `"Recreate"` Kill all existing pods before creating new ones.
        ///  - `"RollingUpdate"` Replace the old ReplicaSets by new one using rolling update i.e gradually scale down the old ReplicaSets and scale up the new one.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private DeploymentStrategy(
            Pulumi.Kubernetes.Types.Outputs.Apps.V1.RollingUpdateDeployment rollingUpdate,

            string type)
        {
            RollingUpdate = rollingUpdate;
            Type = type;
        }
    }
}
