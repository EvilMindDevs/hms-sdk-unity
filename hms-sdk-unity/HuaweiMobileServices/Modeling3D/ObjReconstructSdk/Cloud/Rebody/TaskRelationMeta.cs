using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud.Rebody
{
    /// <summary>
    /// Information about the relationship between a 3D object reconstruction task and other tasks, storing the data of the original task and extra scanning tasks.
    /// Wrapper for com.huawei.hms.objreconstructsdk.cloud.rebody.TaskRelationMeta.
    /// <see cref="TaskRelationMeta" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/cloud-rebody-taskrelationmeta-0000001536004797"/>
    /// </summary>
    public class TaskRelationMeta : JavaObjectWrapper
    {
        public TaskRelationMeta(AndroidJavaObject javaObject) : base(javaObject) { }
        /// <summary>
        /// Obtains the information about the first extra scanning task for 3D object reconstruction.
        /// </summary>
        public RescanTask FirstRescanTask
        {
            get => CallAsWrapper<RescanTask>("getFirstRescanTask");
            set => Call("setFirstRescanTask", value);
        }
        /// <summary>
        /// Obtains the information about the original task for 3D object reconstruction.
        /// </summary>
        public RescanTask OriginalTask
        {
            get => CallAsWrapper<RescanTask>("getOriginalTask");
            set => Call("setOriginalTask", value);
        }
        /// <summary>
        /// Obtains the information about the second extra scanning task for 3D object reconstruction.
        /// </summary>
        public RescanTask SecondRescanTask
        {
            get => CallAsWrapper<RescanTask>("getSecondRescanTask");
            set => Call("setSecondRescanTask", value);
        }

        /// <summary>
        /// Description of a 3D object reconstruction task.
        /// </summary>
        public class RescanTask : JavaObjectWrapper
        {
            public RescanTask(AndroidJavaObject javaObject) : base(javaObject) { }
            public RescanTask() : base("com.huawei.hms.objreconstructsdk.cloud.rebody.TaskRelationMeta$RescanTask") { }
            /// <summary>
            /// Obtains the ID of the original task.
            /// </summary>
            /// <returns>ID of the original task. If the current task is an extra scanning task, this ID belongs to the original task corresponding to the extra scanning task. If the current task is the original task, the value is 0.</returns>
            public string BaseTaskId
            {
                get => CallAsString("getBaseTaskId");
                set => Call("setBaseTaskId", value.AsJavaString());
            }
            /// <summary>
            /// Obtains the ID of the current task.
            /// </summary>
            public string TaskId
            {
                get => CallAsString("getTaskId");
                set => Call("setTaskId", value.AsJavaString());
            }
            /// <summary>
            /// Obtains the information about the uploaded images for the current task.
            /// </summary>
            public TaskImageInfo UploadImageInfo
            {
                get => CallAsWrapper<TaskImageInfo>("getUploadImageInfo");
                set => Call("setUploadImageInfo", value);
            }

        }
    }
}
