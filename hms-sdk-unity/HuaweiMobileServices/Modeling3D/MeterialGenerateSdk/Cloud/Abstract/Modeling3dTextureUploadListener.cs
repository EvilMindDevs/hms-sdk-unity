using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{
    
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureUploadListener.
    /// <see cref="Modeling3dTextureUploadListener" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureuploadlistener-0000001153013001"/>
    /// </summary>
    public class Modeling3dTextureUploadListener : AndroidJavaProxy
    {
        private readonly IModeling3dTextureUploadListener _IModeling3dTextureUploadListener;
        public Modeling3dTextureUploadListener(IModeling3dTextureUploadListener iModeling3dTextureUploadListener) : base("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureUploadListener")
        {
            _IModeling3dTextureUploadListener = iModeling3dTextureUploadListener;
        }
        public void onUploadProgress(string taskId, double progress, AndroidJavaObject javaObject)
        {
            _IModeling3dTextureUploadListener.onUploadProgress(taskId.AsJavaString(), progress, javaObject);
        }
        public void onError(string taskId, int errorCode, string errorMsg)
        {
            _IModeling3dTextureUploadListener.onError(taskId.AsJavaString(), errorCode, errorMsg.AsJavaString());
        }
        public void OnResult(string taskId, Modeling3dTextureUploadResult result, AndroidJavaObject javaObject)
        {
            _IModeling3dTextureUploadListener.OnResult(taskId.AsJavaString(), result, javaObject);
        }

        public interface IModeling3dTextureUploadListener
        {
            //JavaObject maybe make problems be careful doing test.
            void onUploadProgress(AndroidJavaObject taskId, double progress, AndroidJavaObject javaObject);

            void onError(AndroidJavaObject taskId, int errorCode, AndroidJavaObject errorMessage);

            void OnResult(AndroidJavaObject taskId, Modeling3dTextureUploadResult result, AndroidJavaObject javaObject);

        }
    }
}