using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{
    
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureDownloadListener.
    /// <see cref="Modeling3dTextureDownloadListener" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtexturedownloadlistener-0000001153213067"/>
    /// </summary>
    public class Modeling3dTextureDownloadListener : AndroidJavaProxy
    {
        private readonly IModeling3dTextureDownloadListener _IModeling3dTextureDownloadListener;

        public Modeling3dTextureDownloadListener(IModeling3dTextureDownloadListener iModeling3dTextureDownloadListener) : base("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureDownloadListener")
        {
            _IModeling3dTextureDownloadListener = iModeling3dTextureDownloadListener;
        }

        public void onDownloadProgress(string taskId, double progress, AndroidJavaObject javaObject)
        {
            _IModeling3dTextureDownloadListener.onDownloadProgress(taskId.AsJavaString(), progress, javaObject);
        }

        public void onError(string taskId, int errorCode, string errorMsg)
        {
            _IModeling3dTextureDownloadListener.onError(taskId.AsJavaString(), errorCode, errorMsg.AsJavaString());
        }

        public void OnResult(string taskId, Modeling3dTextureDownloadResult result, AndroidJavaObject javaObject)
        {
            _IModeling3dTextureDownloadListener.OnResult(taskId.AsJavaString(), result, javaObject);
        }

        public interface IModeling3dTextureDownloadListener
        {
            //JavaObject maybe make problems be careful doing test.
            void onDownloadProgress(AndroidJavaObject taskId, double progress, AndroidJavaObject javaObject);

            void onError(AndroidJavaObject taskId, int errorCode, AndroidJavaObject errorMessage);

            void OnResult(AndroidJavaObject taskId, Modeling3dTextureDownloadResult result, AndroidJavaObject javaObject);

        }


    }
}