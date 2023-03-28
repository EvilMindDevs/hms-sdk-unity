using HuaweiMobileServices.Utils;

namespace  HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{
        
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureDownloadResult.
    /// <see cref="Modeling3dTextureDownloadResult" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtexturedownloadresult-0000001152893163"/>
    /// </summary>
    public class Modeling3dTextureDownloadResult : JavaObjectWrapper
    {
        public Modeling3dTextureDownloadResult(string taskId, bool isComplate) : base("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureDownloadResult", taskId.AsJavaString(), isComplate) { }

        /// <summary>
        /// Obtains the ID of a material generation task.
        /// </summary>
        /// <returns>ID of a material generation task. A unique task ID is generated each time the material generation API is called.</returns>
        public string TaskId => CallAsString("getTaskId");

        /// <summary>
        /// Obtains the model download result.
        /// </summary>
        /// <returns>
        /// Model download result. true: The model is downloaded successfully. false: The model fails to be downloaded.
        /// </returns>
        public bool Complate => Call<bool>("isComplate");

    }
}