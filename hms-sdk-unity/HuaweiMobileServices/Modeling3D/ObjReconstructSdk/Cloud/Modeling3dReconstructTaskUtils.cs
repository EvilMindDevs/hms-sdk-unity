
using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructTaskUtils
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructtaskutils-0000001153213069
    public class Modeling3dReconstructTaskUtils : JavaObjectWrapper
    {
        public Modeling3dReconstructTaskUtils(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructTaskUtils");

        public static Modeling3dReconstructTaskUtils GetInstance() => javaClass.CallStaticAsWrapper<Modeling3dReconstructTaskUtils>("getInstance",AndroidContext.ApplicationContext);

        public int DeleteTask(string taskId) => Call<int>("deleteTask", taskId.AsJavaString());
        
        /// <summary>
        /// Queries the status of a 3D object reconstruction task.
        /// </summary>
        /// <param name="taskId">Task ID.</param>
        /// <returns>Query result.</returns>
        public Modeling3dReconstructQueryResult QueryTask(string taskId) => CallAsWrapper<Modeling3dReconstructQueryResult>("queryTask", taskId.AsJavaString());

        /// <summary>
        /// Queries the restriction status of a 3D object reconstruction task using its ID.
        /// </summary>
        /// <param name="taskId">Task ID.</param>
        /// <returns>
        /// Restriction status. 0 indicates that the task is not restricted. 1 indicates that the task is restricted. Other values indicate a query failure.
        /// <see cref="Other values:" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/error-code-0000001153097761"/>
        /// </returns>
        public int QueryTaskRestrictStatus(string taskId) => Call<int>("queryTaskRestrictStatus", taskId.AsJavaString());

        /// <summary>
        /// Sets the restriction status of a 3D object reconstruction task using its ID.
        /// </summary>
        /// <param name="taskId">Task ID.</param>
        /// <param name="restrictStatus"Restriction status.</param>"
        /// <returns> Restriction status setting result. 0 indicates success, and other values indicate failure. </returns>
        public int SetTaskRestrictStatus(string taskId, int restrictStatus) => Call<int>("setTaskRestrictStatus", taskId.AsJavaString(), restrictStatus);

    }
}