using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace  HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{
        
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureQueryResult.
    /// <see cref="Modeling3dTextureQueryResult" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtexturequeryresult-0000001106453242"/>
    /// </summary>
    public class Modeling3dTextureQueryResult : JavaObjectWrapper
    {
        public Modeling3dTextureQueryResult(string taskId, int retCode, string retMsg) : base("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureQueryResult", taskId.AsJavaString(), retCode, retMsg.AsJavaString()) { }

        public Modeling3dTextureQueryResult(AndroidJavaObject javaObject) : base(javaObject) { }

        /// <summary>
        /// Obtains the ID of a material generation task.
        /// </summary>
        /// <returns>ID of a material generation task. A unique task ID is generated each time the material generation API is called.</returns>
        public string TaskId => CallAsString("getTaskId");
        /// <summary>
        /// Obtains the result code for material generation task initialization.
        /// </summary>
        /// <returns>
        /// Result code. 0 indicates success, and other values indicate failure.
        /// <see cref="other values" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/error-code-0000001153097761"/>
        /// </returns>
        public int RetCode => Call<int>("getRetCode");
        /// <summary>
        /// Obtains the description of the result code for a material generation task.
        /// </summary>
        /// <returns>Description of the result code.</returns>
        public string RetMsg => CallAsString("getRetMessage");
        /// <summary>
        /// Obtains the status of a material generation task.
        /// </summary>
        /// <returns>
        /// Status of a material generation task.
        /// <see cref="Status" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureconstants-progressstatus-0000001106773050"/>
        /// </returns>
        public int Status => Call<int>("getStatus");

    }
}