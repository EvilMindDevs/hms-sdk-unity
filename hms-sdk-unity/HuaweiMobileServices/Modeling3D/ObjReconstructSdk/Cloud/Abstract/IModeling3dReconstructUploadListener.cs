using System;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    public class Modeling3dReconstructUploadListener : AndroidJavaProxy
    {
        //wrapper for com.huawei.hms.objreconstructsdk.cloud.IModeling3dReconstructUploadListener
        //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructuploadlistener-0000001153093115

        private readonly IModeling3dReconstructUploadListener _IModeling3dReconstructUploadListener;

        public Modeling3dReconstructUploadListener(IModeling3dReconstructUploadListener IModeling3dReconstructUploadListener) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructDownloadListener")
        {
            _IModeling3dReconstructUploadListener = IModeling3dReconstructUploadListener;
        }

        public void onUploadProgress(String taskId, double progress, AndroidJavaObject javaObject)
        {
            _IModeling3dReconstructUploadListener.onDownloadProgress(taskId, progress, javaObject);
        }

        public void onError(String taskId, int errorCode, String errorMsg)
        {
            _IModeling3dReconstructUploadListener.onError(taskId, errorCode, errorMsg);
        }

        public void OnResult(String taskId, Modeling3dReconstructUploadResult result, AndroidJavaObject javaObject)
        {
            _IModeling3dReconstructUploadListener.OnResult(taskId, result, javaObject);
        }

    }

    public interface IModeling3dReconstructUploadListener
    {
        //JavaObject maybe make problems be careful doing test.
        void onDownloadProgress(String taskId, double progress, AndroidJavaObject javaObject);

        void onError(String taskId, int errorCode, String errorMessage);

        void OnResult(String taskId, Modeling3dReconstructUploadResult result, AndroidJavaObject javaObject);

    }
}