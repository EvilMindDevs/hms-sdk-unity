using System.Threading.Tasks;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace  HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{
        
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureEngine.
    /// <see cref="Modeling3dTextureEngine" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureengine-0000001106773052#section122241321310"/>
    /// </summary>
    public class Modeling3dTextureEngine : JavaObjectWrapper
    {
        public Modeling3dTextureEngine(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureEngine");

        /// <summary>
        /// Obtains a Modeling3dTextureEngine instance.
        /// <param name="context">Context</param>
        /// </summary>
        /// <returns>
        /// Modeling3dTextureEngine instance
        /// <see cref="Modeling3dTextureEngine:" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureengine-0000001106773052"/>
        /// </returns>
        public Modeling3dTextureEngine GetInstance() => javaClass.CallStaticAsWrapper<Modeling3dTextureEngine>("getInstance",AndroidContext.ApplicationContext);
        /// <summary>
        /// Initializes the texture generation task.
        /// <param name="taskId">Task ID.</param>
        /// <param name="fileSavePath">Path to which the generated texture maps are to be saved.</param>
        /// </summary>
        public void AsyncDownloadTexture(string taskId, string fileSavePath) =>   javaClass.Call("asyncDownloadTexture", taskId.AsJavaString(), fileSavePath.AsJavaString());
        /// <summary>
        /// Uploads images and triggers a material generation task.
        /// param name="taskId">Task ID.</param>
        /// <param name="fileSavePath">Path from which images are to be uploaded.</param>
        /// </summary>
        public void AsyncUploadFile(string taskId, string filePath) => Call("asyncUploadFile", taskId.AsJavaString(), filePath.AsJavaString());
        /// <summary>
        /// Cancels texture map download.
        /// <param name="taskId">Task ID.</param>
        /// </summary>
        /// <returns> 
        /// Cancellation result. 0 indicates success, and other values indicate failure. 
        /// <see cref="Other values" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/error-code-0000001153097761"/>
        /// </returns>
        public int CancelDownload(string taskId) => Call<int>("cancelDownload", taskId.AsJavaString());
        /// <summary>
        /// Cancels image upload.
        /// <param name="taskId">Task ID.</param>
        /// </summary>
        /// <returns> 
        /// Cancellation result. 0 indicates success, and other values indicate failure. 
        /// <see cref="Other values" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/error-code-0000001153097761"/>
        /// </returns>
        public int CancelUpload(string taskId) => Call<int>("cancelUpload", taskId.AsJavaString());
        /// <summary>
        /// Disables the material generation engine.
        /// </summary>
        public void Close() => Call("close");
        /// <summary>
        /// Initializes a material generation task.
        /// <param name="setting">Material generation task settings.</param>
        /// </summary>
        /// <returns> 
        /// Initialization result.
        /// <see cref="Modeling3dTextureInitResult " link="https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureinitresult-0000001153093113"/>
        /// </returns>
        public Modeling3dTextureInitResult InitTask(Modeling3dTextureSetting setting) => CallAsWrapper<Modeling3dTextureInitResult>("initTask", setting);
        /// <summary>
        /// Previews the material.
        /// <param name="taskId">ID of a material generation task.</param>
        /// <param name="context">App context.</param>
        /// <param name="previewListener">Listener for the preview.</param>
        /// </summary>
        public void PreviewTexture(string taskId, AndroidJavaObject context, Modeling3dTexturePreviewListener previewListener) => Call("previewTexture", taskId.AsJavaString(), context, previewListener);
        /// <summary>
        /// Sets the listener for texture map download.
        /// <param name="listener">Instance of the texture map download listener.</param>
        /// </summary>
        public void SetTextureDownloadListener(Modeling3dTextureDownloadListener listener) => Call("setTextureDownloadListener", listener);
        /// <summary>
        /// Sets the listener for image upload.
        /// <param name="listener">Instance of the image upload listener.</param>
        /// </summary>
        public void SetTextureUploadListener(Modeling3dTextureUploadListener listener) => Call("setTextureUploadListener", listener);
        /// <summary>
        /// Generates texture maps synchronously.
        /// <param name="filePath">Path of images to be uploaded.</param>
        /// <param name="fileSavePath">Path for storing the generated texture maps.</param>
        /// <param name="setting">Material generation task settings.</param>
        /// </summary>
        /// <returns>
        /// Texture map generation result. 0 indicates success, and other values indicate failure.
        /// <see cref="Other values" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/error-code-0000001153097761"/>
        /// </returns>    
        public int SyncGenerateTexture(string filePath, string fileSavePath, Modeling3dTextureSetting setting) => Call<int>("syncGenerateTexture", filePath.AsJavaString(), fileSavePath.AsJavaString(), setting);

    }
}