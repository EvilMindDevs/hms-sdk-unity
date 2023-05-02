using System;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    public class Modeling3dReconstructUploadListener : AndroidJavaProxy
    {
        //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructUploadListener
        //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructuploadlistener-0000001153093115

        private readonly IModeling3dReconstructUploadListener _IModeling3dReconstructUploadListener;

        public Modeling3dReconstructUploadListener(IModeling3dReconstructUploadListener IModeling3dReconstructUploadListener) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructUploadListener")
        {
            _IModeling3dReconstructUploadListener = IModeling3dReconstructUploadListener;
        }

        public void onUploadProgress(string taskId, double progress, AndroidJavaObject javaObject)
        {
            _IModeling3dReconstructUploadListener.onUploadProgress(taskId, progress, javaObject);
        }

        public void onError(string taskId, int errorCode, string errorMsg)
        {
            _IModeling3dReconstructUploadListener.onError(taskId, errorCode, errorMsg);
        }

        public void onResult(string taskId, AndroidJavaObject result, AndroidJavaObject javaObject)
        {
            _IModeling3dReconstructUploadListener.onResult(taskId, (Modeling3dReconstructUploadResult)result, javaObject);
        }

    }

    public interface IModeling3dReconstructUploadListener
    {
        //JavaObject maybe make problems be careful doing test.
        void onUploadProgress(string taskId, double progress, AndroidJavaObject javaObject);

        void onError(string taskId, int errorCode, string errorMessage);

        void onResult(string taskId, Modeling3dReconstructUploadResult result, AndroidJavaObject javaObject);

    }
}