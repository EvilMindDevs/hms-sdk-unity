using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructUploadResult
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructuploadresult-0000001106453244
    public class Modeling3dReconstructUploadResult : JavaObjectWrapper
    {
        public Modeling3dReconstructUploadResult(string taskId, bool isComplate) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructUploadResult", taskId.AsJavaString(), isComplate) { }

        /// <summary>
        /// Obtains the ID of a 3D object reconstruction task.
        /// </summary>
        /// <returns>ID of a 3D object reconstruction task. A unique task ID is generated each time the 3D object reconstruction API is called.</returns>
        public string TaskId => CallAsString("getTaskId");
        /// <summary>
        /// Obtains the model download result.
        /// </summary>
        /// <returns>
        /// Model download result. true: The model is downloaded successfully. false: The model fails to be downloaded.
        /// </returns>
        public bool IsComplate => Call<bool>("isComplate");

        public void SetTaskId(string taskId) => Call("setTaskId", taskId.AsJavaString());

        public void SetComplate(bool isComplate) => Call("setComplate", isComplate);


    
    }
}