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

        /// <summary>
        /// Reason for a failed 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class ReconstructFailCode : JavaObjectWrapper
        {
            //Not necessary to implement this because class name is the same as the java class name

            private const string CLASS_NAME = "com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$ReconstructFailCode";

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
            public ReconstructFailCode(AndroidJavaObject javaObject) : base(javaObject) { }

            public ReconstructFailCode() : base(CLASS_NAME, AndroidContext.ActivityContext) { }

            /// <summary>
            /// Internal error.
            /// <returns>Error code = 1 </returns>
            /// </summary>
            public static int INNER_ERROR => sJavaClass.GetStatic<int>("INNER_ERROR");
            /// <summary>
            /// Image file verification failed.
            /// <returns>Error code = 2 </returns>
            /// </summary>
            public static int FILE_CHECK_FAILED => sJavaClass.GetStatic<int>("FILE_CHECK_FAILED");
            /// <summary>
            /// Invalid image.
            /// </summary>
            /// <returns>Error code = 3 </returns>
            public static int PICTURE_ILLEGAL => sJavaClass.GetStatic<int>("PICTURE_ILLEGAL");
            /// <summary>
            /// The algorithm processing failed.
            /// </summary>
            /// <returns>Error code = 4 </returns>s
            public static int ALGORITHM_FAILED => sJavaClass.GetStatic<int>("ALGORITHM_FAILED");
            /// <summary>
            /// The quota of API calls is used up.
            /// </summary>
            /// <returns>Error code = 5 </returns>
            public static int BILLING_QUOTA_EXHAUSTED => sJavaClass.GetStatic<int>("BILLING_QUOTA_EXHAUSTED");
            /// <summary>
            /// The project is in arrears.
            /// </summary>
            /// <returns>Error code = 6 </returns>
            public static int BILLING_OVERDUE => sJavaClass.GetStatic<int>("BILLING_OVERDUE");
            public static int MEP_CREATE_TASK_FAILED => sJavaClass.GetStatic<int>("MEP_CREATE_TASK_FAILED");
            public static int MEP_QUERY_TASK_FAILED => sJavaClass.GetStatic<int>("MEP_QUERY_TASK_FAILED");

        }
        /// <summary>
        /// Mesh count level for a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class FaceLevel : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$FaceLevel";
            public FaceLevel(AndroidJavaObject javaObject) : base(javaObject) { }

            public FaceLevel() : base(CLASS_NAME, AndroidContext.ActivityContext) { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

            /// <summary>
            /// Low face level.
            /// </summary>
            /// <returns>Face level = 2 </returns>
            public static int LOW => sJavaClass.GetStatic<int>("LOW");
            /// <summary>
            /// Medium face level.
            /// </summary>
            /// <returns>Face level = 1 </returns>
            public static int MEDIUM => sJavaClass.GetStatic<int>("MEDIUM");
            /// <summary>
            /// High face level.
            /// </summary>
            /// <returns>Face level = 0 </returns>
            public static int HIGH => sJavaClass.GetStatic<int>("HIGH");

        }
        /// <summary>
        /// Extra scanning status of a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class NeedRescan : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$NeedRescan";
            public NeedRescan(AndroidJavaObject javaObject) : base(javaObject) { }

            public NeedRescan() : base(CLASS_NAME, AndroidContext.ActivityContext) { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);


            /// <summary>
            /// Enabled.
            /// </summary>
            /// <returns>true</returns>
            public static bool OPEN => Convert.ToBoolean(sJavaClass.GetStatic<string>("OPEN"));        
            /// <summary>
            /// Disabled.
            /// </summary>
            /// <returns>false</returns>
            public static bool CLOSE => Convert.ToBoolean(sJavaClass.GetStatic<string>("CLOSE"));
        }
        /// <summary>
        /// Texture map mode, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class TextureMode : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$TextureMode";

            public TextureMode(AndroidJavaObject javaObject) : base(javaObject) { }

            public TextureMode() : base(CLASS_NAME, AndroidContext.ActivityContext) { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

            /// <summary>
            /// Texture mode: NORMAL.
            /// </summary>
            /// <returns> 0 </returns>
            public static int NORMAL => sJavaClass.GetStatic<int>("NORMAL");
            /// <summary>
            /// Texture mode: PBR.
            /// </summary>
            /// <returns> 1 </returns>
            public static int PBR =>    sJavaClass.GetStatic<int>("PBR");

        }
        /// <summary>
        /// 3D model format, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class ModelFormat : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$ModelFormat";

            public ModelFormat(AndroidJavaObject javaObject) : base(javaObject) { }
            public ModelFormat() : base(CLASS_NAME, AndroidContext.ActivityContext) { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
            /// <summary>
            /// Model format: OBJ.
            /// </summary>
            /// <returns> OBJ </returns>
            public static string OBJ => sJavaClass.GetStatic<string>("OBJ");
            /// <summary>
            /// Model format: GLTF.
            /// </summary>
            /// <returns> GLTF </returns>
            public static string GLTF => sJavaClass.GetStatic<string>("OBJ");
            /// <summary>
            /// Model format: FBX.
            /// </summary>
            /// <returns> FBX </returns>
            public static string FBX => sJavaClass.GetStatic<string>("FBX");

        }
        /// <summary>
        /// Type of a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class TaskType : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$TaskType";

            public TaskType(AndroidJavaObject javaObject) : base(javaObject) { }

            public TaskType() : base(CLASS_NAME, AndroidContext.ActivityContext) { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

            /// <summary>
            /// Task type: 3D object reconstruction.
            /// </summary>
            /// <returns> 0 </returns>
            public static int OBJ_RECONSTRUCT => sJavaClass.GetStatic<int>("OBJ_RECONSTRUCT");
            /// <summary>
            /// Task type: Auto rigging.
            /// </summary>
            /// <returns> 2 </returns>
            public static int AUTO_RIGGING => sJavaClass.GetStatic<int>("AUTO_RIGGING");

        }
        /// <summary>
        /// Restriction status of a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class RestrictStatus : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$RestrictStatus";

            public RestrictStatus(AndroidJavaObject javaObject) : base(javaObject) { }

            public RestrictStatus() : base(CLASS_NAME, AndroidContext.ActivityContext) { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

            /// <summary>
            /// Restrict status: Not restricted.
            /// </summary>
            /// <returns> 0 </returns>
            public static int UNRESTRICT =>sJavaClass.GetStatic<int>("UNRESTRICT");
            /// <summary>
            /// Restrict status: Restricted.
            /// </summary>
            /// <returns> 1 </returns>
            public static int RESTRICT =>sJavaClass.GetStatic<int>("RESTRICT");
        }
        /// <summary>
        /// Status of a 3D object reconstruction task, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class ProgressStatus : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$ProgressStatus";

            public ProgressStatus(AndroidJavaObject javaObject) : base(javaObject) { }

            public ProgressStatus() : base(CLASS_NAME, AndroidContext.ActivityContext) { }

            private static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

            /// <summary>
            /// Progress status: Task initialization is complete.
            /// </summary>
            /// <returns>Progress status = 0 </returns>
            public static int INITED => sJavaClass.GetStatic<int>("INITED");
            /// <summary>
            /// Progress status: File upload is complete.
            /// </summary>
            /// <returns>Progress status = 1 </returns>
            public static int UPLOAD_COMPLETED => sJavaClass.GetStatic<int>("UPLOAD_COMPLETED");
            /// <summary>
            /// Progress status: A 3D object reconstruction task starts.
            /// </summary>
            /// <returns>Progress status = 2 </returns>
            public static int RECONSTRUCT_START => sJavaClass.GetStatic<int>("RECONSTRUCT_START");
            /// <summary>
            /// Progress status: A 3D object reconstruction task is complete.
            /// </summary>
            /// <returns>Progress status = 3 </returns>
            public static int RECONSTRUCT_COMPLETED => sJavaClass.GetStatic<int>("RECONSTRUCT_COMPLETED");
            /// <summary>
            /// Progress status: A 3D object reconstruction task fails.
            /// </summary>
            /// <returns>Progress status = 4 </returns>
            public static int RECONSTRUCT_FAILED => sJavaClass.GetStatic<int>("RECONSTRUCT_FAILED");
            /// <summary>
            /// Progress status: The 3D object reconstruction task is under risk control check.
            /// </summary>
            /// <returns>Progress status = 5 </returns>
            public static int RISK_CONTROL_AUDIT_IN_PROGRESS => sJavaClass.GetStatic<int>("RISK_CONTROL_AUDIT_IN_PROGRESS");
            /// <summary>
            /// Progress status: The 3D object reconstruction task passes the risk control check.
            /// </summary>
            /// <returns>Progress status = 6 </returns>
            public static int RISK_CONTROL_PASSED => sJavaClass.GetStatic<int>("RISK_CONTROL_PASSED");
            /// <summary>
            /// Progress status: The 3D object reconstruction task failed to pass the risk control check. Submit a ticket online, and Huawei technical support will handle it in time.
            /// </summary>
            /// <returns>Progress status = 7 </returns>
            public static int RISK_CONTROL_FAILED => sJavaClass.GetStatic<int>("RISK_CONTROL_FAILED");
            /// <summary>
            /// Progress status: The task deleted.
            /// </summary>
            /// <returns>Progress status = 8 </returns>
            public static int TASK_DELETED => sJavaClass.GetStatic<int>("TASK_DELETED");
        }
        /// <summary>
        /// Working mode for 3D object reconstruction, which is specified in Modeling3dReconstructConstants.
        /// </summary>
        public class ReconstructMode : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.objreconstructsdk.Modeling3dReconstructConstants$ReconstructMode";

            public ReconstructMode(AndroidJavaObject javaObject) : base(javaObject) { }

            public ReconstructMode() : base(CLASS_NAME, AndroidContext.ActivityContext) { }
            private static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

            /// <summary>
            /// Reconstruct mode: PICTURE mode
            /// </summary>
            /// <returns>Reconstruct mode = 0 </returns>
            public static int PICTURE => sJavaClass.GetStatic<int>("PICTURE");

        }
    }
}