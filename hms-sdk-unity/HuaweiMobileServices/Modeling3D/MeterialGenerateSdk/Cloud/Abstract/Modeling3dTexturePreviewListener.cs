using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{
    
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTexturePreviewListener.
    /// <see cref="Modeling3dTexturePreviewListener" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtexturepreviewlistener-0000001194914115"/>
    /// </summary>
    public class Modeling3dTexturePreviewListener : AndroidJavaProxy
    {
        private readonly IModeling3dTexturePreviewListener _IModeling3dTexturePreviewListener;
        public Modeling3dTexturePreviewListener(IModeling3dTexturePreviewListener iModeling3dTexturePreviewListener) : base("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTexturePreviewListener")
        {
            _IModeling3dTexturePreviewListener = iModeling3dTexturePreviewListener;
        }
        public void onError(string taskId, int errorCode, string errorMsg)
        {
            _IModeling3dTexturePreviewListener.onError(taskId, errorCode, errorMsg);
        }
        public void onResult(string taskId, AndroidJavaObject javaObject)
        {
            _IModeling3dTexturePreviewListener.onResult(taskId, javaObject);
        }

        public interface IModeling3dTexturePreviewListener
        {
            void onError(string taskId, int errorCode, string errorMessage);
            void onResult(string taskId,  AndroidJavaObject javaObject);

        }
    }
}