using HuaweiMobileServices.Utils;
using UnityEngine;

namespace  HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{
        
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureInitResult.
    /// <see cref="Modeling3dTextureInitResult" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureinitresult-0000001153093113"/>
    /// </summary>
    public class Modeling3dTextureInitResult : JavaObjectWrapper
    {
        public Modeling3dTextureInitResult(string taskId, int retCode, string retMsg) : base("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureInitResult", taskId.AsJavaString(), retCode, retMsg.AsJavaString()) { }

        public Modeling3dTextureInitResult(AndroidJavaObject javaObject) : base(javaObject) { }

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
        /// Obtains the description of the result code for material generation task initialization.
        /// </summary>
        /// <returns>Description of the result code.</returns>
        public string RetMsg => CallAsString("getRetMsg");

    }
}