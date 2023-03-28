using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructEngine
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructengine-0000001153013003
    public class Modeling3dReconstructEngine : JavaObjectWrapper
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructEngine");
        public Modeling3dReconstructEngine(AndroidJavaObject javaObject) : base(javaObject) { }
        /// <summary>
        /// Obtains a Modeling3dReconstructEngine instance.
        /// </summary>
        /// <returns>Instance of Modeling3dReconstructEngine.</returns>
        public Modeling3dReconstructEngine GetInstance() => sJavaClass.CallStaticAsWrapper<Modeling3dReconstructEngine>("getInstance",AndroidContext.ApplicationContext);
        /// <summary>
        /// Initializes a 3D object reconstruction task.
        /// </summary>
        /// <param name="setting">3D object reconstruction task settings.</param>
        /// <returns>Initialization result.</returns>
        public Modeling3dReconstructEngine InitTask(Modeling3dReconstructSetting setting) => CallAsWrapper<Modeling3dReconstructEngine>("initTask", setting);
        public int CancelDownload(string taskId) => Call<int>("cancelDownload", taskId.AsJavaString());
        public int CancelUpload(string taskId) => Call<int>("cancelUpload", taskId.AsJavaString());
        /// <summary>
        /// Disables the 3D object reconstruction engine.
        /// </summary>
        public void Close() => Call("close");
        /// <summary>
        /// Downloads the 3D object reconstruction task result using the custom configuration.
        /// </summary>
        /// <param name="taskId">Task ID.</param>
        /// <param name="fileSavePath">Path to which the generated 3D object model is to be saved.</param>
        /// <param name="downloadConfig">Custom download configurations.</param>
        public void DownloadModelWithConfig(string taskId, string fileSavePath, Modeling3dReconstructDownloadConfig downloadConfig) => Call("downloadModelWithConfig", taskId.AsJavaString(), fileSavePath.AsJavaString(), downloadConfig);
        /// <summary>
        /// Downloads the 3D object reconstruction task result.
        /// </summary>
        /// <param name="taskId">Task ID.</param>
        /// <param name="previewConfig">Preview configuration.</param>
        /// <param name="previewListener">Listener for the preview.</param>
        public void PreviewModelWithConfig(string taskId, Modeling3dReconstructPreviewConfig previewConfig, Modeling3dReconstructPreviewListener previewListener) => Call("previewModelWithConfig", taskId.AsJavaString(), AndroidContext.ApplicationContext, previewConfig, previewListener);
        public void SetReconstructDownloadListener(Modeling3dReconstructDownloadListener listener) => Call("setReconstructDownloadListener", listener);
        public void SetReconstructUploadListener(Modeling3dReconstructUploadListener listener) => Call("setReconstructUploadListener", listener);
       
        /// <summary>
        /// Uploads images and triggers a 3D object reconstruction task.
        /// </summary>
        /// <param name="taskId">Task ID.</param>
        /// <param name="filePath">Path from which images are to be uploaded.</param>
        public void UploadFile(string taskId, string filePath) => Call("uploadFile", taskId.AsJavaString(), filePath.AsJavaString());

    }
}