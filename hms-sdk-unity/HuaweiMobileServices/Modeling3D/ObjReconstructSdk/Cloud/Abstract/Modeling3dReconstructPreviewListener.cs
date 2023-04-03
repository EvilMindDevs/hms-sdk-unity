using System;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    public class Modeling3dReconstructPreviewListener : AndroidJavaProxy
    {
        //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructPreviewListener
        //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructpreviewlistener-0000001149001208

        private readonly IModeling3dReconstructPreviewListener _IModeling3dReconstructPreviewListener;

        public Modeling3dReconstructPreviewListener(IModeling3dReconstructPreviewListener IModeling3dReconstructPreviewListener) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructPreviewListener")
        {
            _IModeling3dReconstructPreviewListener = IModeling3dReconstructPreviewListener;
        }

        public void onError(string taskId, int errorCode, string errorMsg)
        {
            _IModeling3dReconstructPreviewListener.onError(taskId, errorCode, errorMsg);
        }

        public void onResult(string taskId, AndroidJavaObject javaObject)
        {
            _IModeling3dReconstructPreviewListener.onResult(taskId, javaObject);
        }

    }

    public interface IModeling3dReconstructPreviewListener
    {
        void onError(string taskId, int errorCode, string message);

        void onResult(string taskId, AndroidJavaObject javaObject);

    }
}