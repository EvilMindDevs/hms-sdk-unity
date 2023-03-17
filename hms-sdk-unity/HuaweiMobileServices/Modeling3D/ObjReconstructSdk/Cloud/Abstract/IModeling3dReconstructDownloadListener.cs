using System;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    public class Modeling3dReconstructDownloadListener : AndroidJavaProxy
    {
        //wrapper for com.huawei.hms.objreconstructsdk.cloud.IModeling3dReconstructDownloadListener
        //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructdownloadlistener-0000001106613206

        private readonly IModeling3dReconstructDownloadListener _IModeling3dReconstructDownloadListener;

        public Modeling3dReconstructDownloadListener(IModeling3dReconstructDownloadListener iModeling3dReconstructDownloadListener) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructDownloadListener")
        {
            _IModeling3dReconstructDownloadListener = iModeling3dReconstructDownloadListener;
        }

        public void onDownloadProgress(String taskId, double progress, AndroidJavaObject javaObject)
        {
            _IModeling3dReconstructDownloadListener.onDownloadProgress(taskId, progress, javaObject);
        }

        public void onError(String taskId, int errorCode, String errorMsg)
        {
            _IModeling3dReconstructDownloadListener.onError(taskId, errorCode, errorMsg);
        }

        public void OnResult(String taskId, Modeling3dReconstructDownloadResult result, AndroidJavaObject javaObject)
        {
            _IModeling3dReconstructDownloadListener.OnResult(taskId, result, javaObject);
        }

    }

    public interface IModeling3dReconstructDownloadListener
    {
        //JavaObject maybe make problems be careful doing test.
        void onDownloadProgress(String taskId, double progress, AndroidJavaObject javaObject);

        void onError(String taskId, int errorCode, String errorMessage);

        void OnResult(String taskId, Modeling3dReconstructDownloadResult result, AndroidJavaObject javaObject);

    }
}