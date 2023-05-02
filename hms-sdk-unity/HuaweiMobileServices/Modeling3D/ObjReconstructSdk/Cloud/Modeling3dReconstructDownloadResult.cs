using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructDownloadResult
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructdownloadresult-0000001106293440
    public class Modeling3dReconstructDownloadResult : JavaObjectWrapper
    {
        public Modeling3dReconstructDownloadResult(AndroidJavaObject javaObject) : base(javaObject) { }
        public Modeling3dReconstructDownloadResult(string taskId, bool isComplate) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructDownloadResult", taskId, isComplate) { }

        public static explicit operator Modeling3dReconstructDownloadResult(AndroidJavaObject v) => new Modeling3dReconstructDownloadResult(v);


        /// <summary>
        /// Obtains the model download result.
        /// </summary>
        /// <returns>
        /// Model download result. true: The model is downloaded successfully. false: The model fails to be downloaded.
        /// </returns>
        public bool Complate {
            get => Call<bool>("isComplate");
            set => Call("setComplate", value);
        }
        /// <summary>
        /// Obtains the ID of a 3D object reconstruction task.
        /// </summary>
        /// <returns>ID of a 3D object reconstruction task. A unique task ID is generated each time the 3D object reconstruction API is called.</returns>
        public string TaskId
        {
            get => CallAsString("getTaskId");
            set => Call("setTaskId", value.AsJavaString());
        }

    }
}