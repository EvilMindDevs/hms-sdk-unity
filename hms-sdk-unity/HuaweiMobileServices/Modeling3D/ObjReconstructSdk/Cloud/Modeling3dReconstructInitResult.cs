using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructInitResult
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructinitresult-0000001106773056
    public class Modeling3dReconstructInitResult : JavaObjectWrapper
    {
        public Modeling3dReconstructInitResult(string taskId, int retCode, string retMsg) : 
                            base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructInitResult", taskId.AsJavaString(), retCode, retMsg.AsJavaString()) { }
        

        /// <summary>
        /// Obtains the ID of a 3D object reconstruction task.
        /// </summary>
        /// <returns>ID of a 3D object reconstruction task. A unique task ID is generated each time the 3D object reconstruction API is called.</returns>
        public string TaskId => CallAsString("getTaskId");

        /// <summary>
        /// Obtains the result code of a 3D object reconstruction task.
        /// </summary>
        /// <returns>
        /// Result code of a 3D object reconstruction task. 0: The task is initialized successfully. 1: The task fails to be initialized.
        /// </returns>
        public int RetCode => Call<int>("getRetCode");

        /// <summary>
        /// Obtains the result message of a 3D object reconstruction task.
        /// </summary>
        /// <returns>   
        /// Result message of a 3D object reconstruction task. The result message is returned when the task fails to be initialized.
        /// </returns>
        public string RetMsg => CallAsString("getRetMsg");
        

    }
}