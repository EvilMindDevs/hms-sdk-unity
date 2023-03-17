using System;
using System.Collections.Generic;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructQueryResult
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructqueryresult-0000001152893165
    public class Modeling3dReconstructQueryResult : JavaObjectWrapper
    {
        public Modeling3dReconstructQueryResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public Modeling3dReconstructQueryResult(string taskId, int retCode, string redMsg) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructQueryResult", taskId.AsJavaString(), retCode, redMsg.AsJavaString()) { }

        /// <summary>
        /// Obtains the supported model file formats.
        /// </summary>
        public IList<string> GetModelFormat() => Call<AndroidJavaObject>("getModelFormat").AsStringList();
        /// <summary>
        /// Obtains the reason why the 3D object reconstruction task fails.
        /// </summary>
        /// <returns>Failure reason.</returns>
        public string GetReconstructFailMessage() => CallAsString("getReconstructFailMessage");
        /// <summary>
        /// Obtains the result code for a 3D object reconstruction task.
        /// </summary>
        /// <returns>Result code.</returns>
        public int GetRetCode() => Call<int>("getRetCode");
        /// <summary>
        /// Obtains the description of the result code for a 3D object reconstruction task.
        /// </summary>
        /// <returns>Description of the result code.</returns>
        public string GetRetMessage() => CallAsString("getRetMessage");
        /// <summary>
        /// Obtains the status of a 3D object reconstruction task.
        /// </summary>
        /// <returns>Status of a 3D object reconstruction task. <see cref="Status Link:" href=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructconstants-progressstatus-0000001153213065" /></returns>
        public string GetStatus() => CallAsString("getStatus");
        /// <summary>
        /// Obtains the task ID of a 3D object reconstruction task.
        /// </summary>
        /// <returns>ID of a 3D object reconstruction task. A unique task ID is generated each time the 3D object reconstruction API is called.</returns> 
        public string GetTaskId() => CallAsString("getTaskId");

    }
}