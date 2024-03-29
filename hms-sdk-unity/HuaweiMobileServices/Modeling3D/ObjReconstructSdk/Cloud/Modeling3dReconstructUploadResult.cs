using System;
using HuaweiMobileServices.Ads.NativeAd;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructUploadResult
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructuploadresult-0000001106453244
    public class Modeling3dReconstructUploadResult : JavaObjectWrapper
    {
        public Modeling3dReconstructUploadResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public Modeling3dReconstructUploadResult(string taskId, bool isComplete) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructUploadResult", taskId, isComplete) { }

        public static explicit operator Modeling3dReconstructUploadResult(AndroidJavaObject v) => new Modeling3dReconstructUploadResult(v);

        /// <summary>
        /// Obtains the ID of a 3D object reconstruction task.
        /// </summary>
        /// <returns>ID of a 3D object reconstruction task. A unique task ID is generated each time the 3D object reconstruction API is called.</returns>
        public string TaskId
        {
            get => CallAsString("getTaskId");
            set => Call("setTaskId", value);
        }
        /// <summary>
        /// Obtains the model download result.
        /// </summary>
        /// <returns>
        /// Model download result. true: The model is downloaded successfully. false: The model fails to be downloaded.
        /// </returns>
        public bool Complate
        {
            get => Call<bool>("isComplete");
            set => Call("setComplate", value);
        }

    }
}