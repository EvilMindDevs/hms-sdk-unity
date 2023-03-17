using System;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    public class Modeling3dReconstructPreviewListener : AndroidJavaProxy
    {
        //wrapper for com.huawei.hms.objreconstructsdk.cloud.IModeling3dReconstructPreviewListener
        //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructdownloadlistener-0000001106613206

        private readonly IModeling3dReconstructPreviewListener _IModeling3dReconstructPreviewListener;

        public Modeling3dReconstructPreviewListener(IModeling3dReconstructPreviewListener IModeling3dReconstructPreviewListener) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructPreviewListener")
        {
            _IModeling3dReconstructPreviewListener = IModeling3dReconstructPreviewListener;
        }

        public void onError(String taskId, int errorCode, String errorMsg)
        {
            _IModeling3dReconstructPreviewListener.onError(taskId, errorCode, errorMsg);
        }

        public void OnResult(String taskId, AndroidJavaObject javaObject)
        {
            _IModeling3dReconstructPreviewListener.OnResult(taskId, javaObject);
        }

    }

    public interface IModeling3dReconstructPreviewListener
    {
        void onError(String taskId, int errorCode, String message);

        void OnResult(String taskId, AndroidJavaObject javaObject);

    }
}