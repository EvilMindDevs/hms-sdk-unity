using System;
using HuaweiMobileServices.Utils;
using UnityEngine;
namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk
{
    //wrapper for com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructconstants-0000001153012999
    public class Modeling3dReconstructConstants : JavaObjectWrapper
    {
        //private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants");

        public Modeling3dReconstructConstants(AndroidJavaObject javaObject) : base(javaObject)
        {
        }
        public static explicit operator Modeling3dReconstructConstants(AndroidJavaObject javaObject) => javaObject == null ? null : new Modeling3dReconstructConstants(javaObject);

        /// <summary>
        /// Reason for a failed 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class ReconstructFailCode : JavaObjectWrapper
        {
            //Not necessary to implement this because class name is the same as the java class name
            //private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants");
            public ReconstructFailCode(AndroidJavaObject javaObject) : base(javaObject) { }

            public ReconstructFailCode() : base("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$ReconstructFailCode", AndroidContext.ActivityContext) { }

            /// <summary>
            /// Internal error.
            /// <returns>Error code = 1 </returns>
            /// </summary>
            public int INNER_ERROR => CallStatic<int>("INNER_ERROR");
            /// <summary>
            /// Image file verification failed.
            /// <returns>Error code = 2 </returns>
            /// </summary>
            public int FILE_CHECK_FAILED => CallStatic<int>("FILE_CHECK_FAILED");
            /// <summary>
            /// Invalid image.
            /// </summary>
            /// <returns>Error code = 3 </returns>
            public int PICTURE_ILLEGAL => CallStatic<int>("PICTURE_ILLEGAL");
            /// <summary>
            /// The algorithm processing failed.
            /// </summary>
            /// <returns>Error code = 4 </returns>s
            public int ALGORITHM_FAILED => CallStatic<int>("ALGORITHM_FAILED");
            /// <summary>
            /// The quota of API calls is used up.
            /// </summary>
            /// <returns>Error code = 5 </returns>
            public int BILLING_QUOTA_EXHAUSTED => CallStatic<int>("BILLING_QUOTA_EXHAUSTED");
            /// <summary>
            /// The project is in arrears.
            /// </summary>
            /// <returns>Error code = 6 </returns>
            public int BILLING_OVERDUE => CallStatic<int>("BILLING_OVERDUE");
            public int MEP_CREATE_TASK_FAILED => CallStatic<int>("MEP_CREATE_TASK_FAILED");
            public int MEP_QUERY_TASK_FAILED => CallStatic<int>("MEP_QUERY_TASK_FAILED");

        }
        /// <summary>
        /// Mesh count level for a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class FaceLevel : JavaObjectWrapper
        {
            public FaceLevel(AndroidJavaObject javaObject) : base(javaObject) { }

            public FaceLevel() : base("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$FaceLevel", AndroidContext.ActivityContext) { }

            /// <summary>
            /// Low face level.
            /// </summary>
            /// <returns>Face level = 2 </returns>
            public int LOW => CallStatic<int>("LOW");
            /// <summary>
            /// Medium face level.
            /// </summary>
            /// <returns>Face level = 1 </returns>
            public int MEDIUM => CallStatic<int>("MEDIUM");
            /// <summary>
            /// High face level.
            /// </summary>
            /// <returns>Face level = 0 </returns>
            public int HIGH => CallStatic<int>("HIGH");

        }
        /// <summary>
        /// Extra scanning status of a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class NeedRescan : JavaObjectWrapper
        {
            public NeedRescan(AndroidJavaObject javaObject) : base(javaObject) { }

            public NeedRescan() : base("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$NeedRescan", AndroidContext.ActivityContext) { }

            /// <summary>
            /// Enabled.
            /// </summary>
            /// <returns>true</returns>
            public bool OPEN => Convert.ToBoolean(CallAsString("OPEN"));
            /// <summary>
            /// Disabled.
            /// </summary>
            /// <returns>false</returns>
            public bool CLOSE => Convert.ToBoolean(CallAsString("CLOSE"));

        }
        /// <summary>
        /// Texture map mode, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class TextureMode : JavaObjectWrapper
        {
            public TextureMode(AndroidJavaObject javaObject) : base(javaObject) { }

            public TextureMode() : base("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$TextureMode", AndroidContext.ActivityContext) { }

            /// <summary>
            /// Texture mode: NORMAL.
            /// </summary>
            /// <returns> 0 </returns>
            public int NORMAL => CallStatic<int>("NORMAL");
            /// <summary>
            /// Texture mode: PBR.
            /// </summary>
            /// <returns> 1 </returns>
            public int PBR => CallStatic<int>("PBR");

        }
        /// <summary>
        /// 3D model format, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class ModelFormat : JavaObjectWrapper
        {
            public ModelFormat(AndroidJavaObject javaObject) : base(javaObject) { }
            public ModelFormat() : base("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$ModelFormat", AndroidContext.ActivityContext) { }
            /// <summary>
            /// Model format: OBJ.
            /// </summary>
            /// <returns> OBJ </returns>
            public string OBJ => CallAsString("OBJ");
            /// <summary>
            /// Model format: GLTF.
            /// </summary>
            /// <returns> GLTF </returns>
            public string GLTF => CallAsString("GLTF");
            /// <summary>
            /// Model format: FBX.
            /// </summary>
            /// <returns> FBX </returns>
            public string FBX => CallAsString("FBX");
        
        }
        /// <summary>
        /// Type of a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class TaskType : JavaObjectWrapper
        {
            public TaskType(AndroidJavaObject javaObject) : base(javaObject) { }

            public TaskType() : base("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$TaskType", AndroidContext.ActivityContext) { }

            /// <summary>
            /// Task type: 3D object reconstruction.
            /// </summary>
            /// <returns> 0 </returns>
            public int OBJ_RECONSTRUCT => CallStatic<int>("OBJ_RECONSTRUCT");
            /// <summary>
            /// Task type: Auto rigging.
            /// </summary>
            /// <returns> 2 </returns>
            public int AUTO_RIGGING =>  CallStatic<int>("AUTO_RIGGING");


        }
        /// <summary>
        /// Restriction status of a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class RestrictStatus : JavaObjectWrapper
        {
            public RestrictStatus(AndroidJavaObject javaObject) : base(javaObject) { }

            public RestrictStatus() : base("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$RestrictStatus", AndroidContext.ActivityContext) { }

            /// <summary>
            /// Restrict status: Not restricted.
            /// </summary>
            /// <returns> 0 </returns>
            public int UNRESTRICT => CallStatic<int>("UNRESTRICT");
            /// <summary>
            /// Restrict status: Restricted.
            /// </summary>
            /// <returns> 1 </returns>
            public int RESTRICT => CallStatic<int>("RESTRICT");

        }
        /// <summary>
        /// Status of a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class ProgressStatus : JavaObjectWrapper
        {
            public ProgressStatus(AndroidJavaObject javaObject) : base(javaObject) { }

            public ProgressStatus() : base("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$ProgressStatus", AndroidContext.ActivityContext) { }

            /// <summary>
            /// Progress status: Task initialization is complete.
            /// </summary>
            /// <returns>Progress status = 0 </returns>
            public int INITED => CallStatic<int>("INITED");
            /// <summary>
            /// Progress status: File upload is complete.
            /// </summary>
            /// <returns>Progress status = 1 </returns>
            public int UPLOAD_COMPLETED => CallStatic<int>("UPLOAD_COMPLETED");
            /// <summary>
            /// Progress status: A 3D object reconstruction task starts.
            /// </summary>
            /// <returns>Progress status = 2 </returns>
            public int RECONSTRUCT_START => CallStatic<int>("RECONSTRUCT_START");
            /// <summary>
            /// Progress status: A 3D object reconstruction task is complete.
            /// </summary>
            /// <returns>Progress status = 3 </returns>
            public int RECONSTRUCT_COMPLETED => CallStatic<int>("RECONSTRUCT_COMPLETED");
            /// <summary>
            /// Progress status: A 3D object reconstruction task fails.
            /// </summary>
            /// <returns>Progress status = 4 </returns>
            public int RECONSTRUCT_FAILED => CallStatic<int>("RECONSTRUCT_FAILED");
            /// <summary>
            /// Progress status: The 3D object reconstruction task is under risk control check.
            /// </summary>
            /// <returns>Progress status = 5 </returns>
            public int RISK_CONTROL_AUDIT_IN_PROGRESS => CallStatic<int>("RISK_CONTROL_AUDIT_IN_PROGRESS");
            /// <summary>
            /// Progress status: The 3D object reconstruction task passes the risk control check.
            /// </summary>
            /// <returns>Progress status = 6 </returns>
            public int RISK_CONTROL_PASSED => CallStatic<int>("RISK_CONTROL_PASSED");
            /// <summary>
            /// Progress status: The 3D object reconstruction task failed to pass the risk control check. Submit a ticket online, and Huawei technical support will handle it in time.
            /// </summary>
            /// <returns>Progress status = 7 </returns>
            public int RISK_CONTROL_FAILED => CallStatic<int>("RISK_CONTROL_FAILED");
            /// <summary>
            /// Progress status: The task deleted.
            /// </summary>
            /// <returns>Progress status = 8 </returns>
            public int TASK_DELETED => CallStatic<int>("TASK_DELETED");
        }
        /// <summary>
        /// Working mode for 3D object reconstruction, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class ReconstructMode : JavaObjectWrapper
        {
            public ReconstructMode(AndroidJavaObject javaObject) : base(javaObject) { }

            public ReconstructMode() : base("com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$ReconstructMode", AndroidContext.ActivityContext) { }

            /// <summary>
            /// Reconstruct mode: PICTURE mode
            /// </summary>
            /// <returns>Reconstruct mode = 0 </returns>
            public int PICTURE => CallStatic<int>("PICTURE");

        }
    }
}