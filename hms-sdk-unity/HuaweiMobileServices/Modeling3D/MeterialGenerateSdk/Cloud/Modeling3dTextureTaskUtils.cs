using HuaweiMobileServices.Utils;
using UnityEngine;

namespace  HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{
        
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureTaskUtils.
    /// <see cref="Modeling3dTextureTaskUtils" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtexturetaskutils-0000001106293436"/>
    /// </summary>
    public class Modeling3dTextureTaskUtils : JavaObjectWrapper
    {
        public Modeling3dTextureTaskUtils(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureTaskUtils");

        /// <summary>
        /// Obtains a Modeling3dTextureTaskUtils instance.
        /// <param name="context">Context</param>
        /// </summary>
        /// <returns>
        /// Modeling3dTextureTaskUtils instance
        /// <see cref="Modeling3dTextureTaskUtils:" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtexturetaskutils-0000001106293436"/>
        /// </returns>
        public Modeling3dTextureTaskUtils GetInstance() => javaClass.CallStaticAsWrapper<Modeling3dTextureTaskUtils>("getInstance",AndroidContext.ApplicationContext);
        /// <summary>
        /// Deletes a material generation task using its ID.
        /// <param name="taskId">Task ID.</param>
        /// </summary>
        /// <returns>
        /// Deletion result. 0 indicates success, and other values indicate failure.
        /// <see cref="Other values:" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/error-code-0000001153097761"/>
        /// </returns>
        public int DeleteTask(string taskId) => Call<int>("deleteTask", taskId.AsJavaString());
        /// <summary>
        /// Queries the status of a material generation task.
        /// </summary>
        /// <param name="taskId">Task ID.</param>
        /// <returns>Status of a material generation task.</returns>
        public Modeling3dTextureQueryResult QueryTask(string taskId) => CallAsWrapper<Modeling3dTextureQueryResult>("queryTask", taskId.AsJavaString());
        /// <summary>
        /// Queries the restriction status of a material generation task using its ID.
        /// </summary>
        /// <param name="taskId">Task ID.</param>
        /// <returns>
        /// Restriction status. 0 indicates that the task is UNRESTRICT. 1 indicates that the task is RESTRICT. When the query fails, a result code is returned.
        /// <see cref="Result Code:" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/error-code-0000001153097761"/>
        /// </returns>
        public int QueryTaskRestrictStatus(string taskId) => Call<int>("queryTaskRestrictStatus", taskId.AsJavaString());
        /// <summary>
        /// Sets the restriction status of a material generation task using its ID.
        /// </summary>
        /// <param name="taskId">Task ID.</param>
        /// <param name="restrictStatus"Restriction status. (0 - UNRESTRICT, 1 - RESTRICT)</param>"
        /// <see cref="Restriction status:" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureconstantsrestrictstatus-0000001148991652"/>
        /// <returns> Restriction status setting result. 0 indicates success, and other values indicate failure. </returns>
        public int SetTaskRestrictStatus(string taskId, int restrictStatus) => Call<int>("setTaskRestrictStatus", taskId.AsJavaString(), restrictStatus);

    }
}