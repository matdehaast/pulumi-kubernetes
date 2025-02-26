// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Types.Inputs.Core.V1
{

    /// <summary>
    /// Volume represents a named volume in a pod that may be accessed by any container in the pod.
    /// </summary>
    public class VolumeArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AWSElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        /// </summary>
        [Input("awsElasticBlockStore")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.AWSElasticBlockStoreVolumeSourceArgs>? AwsElasticBlockStore { get; set; }

        /// <summary>
        /// AzureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.
        /// </summary>
        [Input("azureDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.AzureDiskVolumeSourceArgs>? AzureDisk { get; set; }

        /// <summary>
        /// AzureFile represents an Azure File Service mount on the host and bind mount to the pod.
        /// </summary>
        [Input("azureFile")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.AzureFileVolumeSourceArgs>? AzureFile { get; set; }

        /// <summary>
        /// CephFS represents a Ceph FS mount on the host that shares a pod's lifetime
        /// </summary>
        [Input("cephfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.CephFSVolumeSourceArgs>? Cephfs { get; set; }

        /// <summary>
        /// Cinder represents a cinder volume attached and mounted on kubelets host machine. More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        /// </summary>
        [Input("cinder")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.CinderVolumeSourceArgs>? Cinder { get; set; }

        /// <summary>
        /// ConfigMap represents a configMap that should populate this volume
        /// </summary>
        [Input("configMap")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ConfigMapVolumeSourceArgs>? ConfigMap { get; set; }

        /// <summary>
        /// CSI (Container Storage Interface) represents ephemeral storage that is handled by certain external CSI drivers (Beta feature).
        /// </summary>
        [Input("csi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.CSIVolumeSourceArgs>? Csi { get; set; }

        /// <summary>
        /// DownwardAPI represents downward API about the pod that should populate this volume
        /// </summary>
        [Input("downwardAPI")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.DownwardAPIVolumeSourceArgs>? DownwardAPI { get; set; }

        /// <summary>
        /// EmptyDir represents a temporary directory that shares a pod's lifetime. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        /// </summary>
        [Input("emptyDir")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.EmptyDirVolumeSourceArgs>? EmptyDir { get; set; }

        /// <summary>
        /// Ephemeral represents a volume that is handled by a cluster storage driver. The volume's lifecycle is tied to the pod that defines it - it will be created before the pod starts, and deleted when the pod is removed.
        /// 
        /// Use this if: a) the volume is only needed while the pod runs, b) features of normal volumes like restoring from snapshot or capacity
        ///    tracking are needed,
        /// c) the storage driver is specified through a storage class, and d) the storage driver supports dynamic volume provisioning through
        ///    a PersistentVolumeClaim (see EphemeralVolumeSource for more
        ///    information on the connection between this volume type
        ///    and PersistentVolumeClaim).
        /// 
        /// Use PersistentVolumeClaim or one of the vendor-specific APIs for volumes that persist for longer than the lifecycle of an individual pod.
        /// 
        /// Use CSI for light-weight local ephemeral volumes if the CSI driver is meant to be used that way - see the documentation of the driver for more information.
        /// 
        /// A pod can use both types of ephemeral volumes and persistent volumes at the same time.
        /// </summary>
        [Input("ephemeral")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.EphemeralVolumeSourceArgs>? Ephemeral { get; set; }

        /// <summary>
        /// FC represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.
        /// </summary>
        [Input("fc")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.FCVolumeSourceArgs>? Fc { get; set; }

        /// <summary>
        /// FlexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.
        /// </summary>
        [Input("flexVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.FlexVolumeSourceArgs>? FlexVolume { get; set; }

        /// <summary>
        /// Flocker represents a Flocker volume attached to a kubelet's host machine. This depends on the Flocker control service being running
        /// </summary>
        [Input("flocker")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.FlockerVolumeSourceArgs>? Flocker { get; set; }

        /// <summary>
        /// GCEPersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        /// </summary>
        [Input("gcePersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.GCEPersistentDiskVolumeSourceArgs>? GcePersistentDisk { get; set; }

        /// <summary>
        /// GitRepo represents a git repository at a particular revision. DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
        /// </summary>
        [Input("gitRepo")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.GitRepoVolumeSourceArgs>? GitRepo { get; set; }

        /// <summary>
        /// Glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/glusterfs/README.md
        /// </summary>
        [Input("glusterfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.GlusterfsVolumeSourceArgs>? Glusterfs { get; set; }

        /// <summary>
        /// HostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container. This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [Input("hostPath")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.HostPathVolumeSourceArgs>? HostPath { get; set; }

        /// <summary>
        /// ISCSI represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod. More info: https://examples.k8s.io/volumes/iscsi/README.md
        /// </summary>
        [Input("iscsi")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ISCSIVolumeSourceArgs>? Iscsi { get; set; }

        /// <summary>
        /// Volume's name. Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// NFS represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        /// </summary>
        [Input("nfs")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.NFSVolumeSourceArgs>? Nfs { get; set; }

        /// <summary>
        /// PersistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        /// </summary>
        [Input("persistentVolumeClaim")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PersistentVolumeClaimVolumeSourceArgs>? PersistentVolumeClaim { get; set; }

        /// <summary>
        /// PhotonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine
        /// </summary>
        [Input("photonPersistentDisk")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PhotonPersistentDiskVolumeSourceArgs>? PhotonPersistentDisk { get; set; }

        /// <summary>
        /// PortworxVolume represents a portworx volume attached and mounted on kubelets host machine
        /// </summary>
        [Input("portworxVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.PortworxVolumeSourceArgs>? PortworxVolume { get; set; }

        /// <summary>
        /// Items for all in one resources secrets, configmaps, and downward API
        /// </summary>
        [Input("projected")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ProjectedVolumeSourceArgs>? Projected { get; set; }

        /// <summary>
        /// Quobyte represents a Quobyte mount on the host that shares a pod's lifetime
        /// </summary>
        [Input("quobyte")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.QuobyteVolumeSourceArgs>? Quobyte { get; set; }

        /// <summary>
        /// RBD represents a Rados Block Device mount on the host that shares a pod's lifetime. More info: https://examples.k8s.io/volumes/rbd/README.md
        /// </summary>
        [Input("rbd")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.RBDVolumeSourceArgs>? Rbd { get; set; }

        /// <summary>
        /// ScaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.
        /// </summary>
        [Input("scaleIO")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.ScaleIOVolumeSourceArgs>? ScaleIO { get; set; }

        /// <summary>
        /// Secret represents a secret that should populate this volume. More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        /// </summary>
        [Input("secret")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.SecretVolumeSourceArgs>? Secret { get; set; }

        /// <summary>
        /// StorageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.
        /// </summary>
        [Input("storageos")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.StorageOSVolumeSourceArgs>? Storageos { get; set; }

        /// <summary>
        /// VsphereVolume represents a vSphere volume attached and mounted on kubelets host machine
        /// </summary>
        [Input("vsphereVolume")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Core.V1.VsphereVirtualDiskVolumeSourceArgs>? VsphereVolume { get; set; }

        public VolumeArgs()
        {
        }
    }
}
