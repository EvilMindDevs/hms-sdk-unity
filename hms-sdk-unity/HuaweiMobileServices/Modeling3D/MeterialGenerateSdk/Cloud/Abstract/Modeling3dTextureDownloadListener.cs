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
            _IModeling3dTextureDownloadListener.onDownloadProgress(taskId, progress, javaObject);
        }

        public void onError(string taskId, int errorCode, string errorMsg)
        {
            _IModeling3dTextureDownloadListener.onError(taskId, errorCode, errorMsg);
        }

        public void onResult(string taskId, Modeling3dTextureDownloadResult result, AndroidJavaObject javaObject)
        {
            _IModeling3dTextureDownloadListener.onResult(taskId, result, javaObject);
        }

        public interface IModeling3dTextureDownloadListener
        {
            //TODO: AndroidObject maybe make problems be careful doing test. AndroidObject = Android Object Class
            void onDownloadProgress(string taskId, double progress, AndroidJavaObject javaObject);

            void onError(string taskId, int errorCode, string errorMessage);

            void onResult(string taskId, Modeling3dTextureDownloadResult result, AndroidJavaObject javaObject);

        }


    }
}