using HuaweiMobileServices.Utils;
using UnityEngine;
namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk
{
    /// <summary>
    /// Wrapper for com.huawei.hms.objreconstructsdk.Modeling3dReconstructErrors
    /// <see cref="Modeling3dReconstructErrors" link="https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructerrors-0000001153093111"/>
    /// </summary>
    public class Modeling3dReconstructErrors : JavaObjectWrapper
    {
        public Modeling3dReconstructErrors(AndroidJavaObject javaObject) : base(javaObject)
        {
        }
        //Not necessary to implement this because class name is the same as the java class name
        //private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.objreconstructsdk.Modeling3dReconstructErrors");

        public static explicit operator Modeling3dReconstructErrors(AndroidJavaObject javaObject) => javaObject == null ? null : new Modeling3dReconstructErrors(javaObject);

        /// <summary>
        /// Unsupported image format.
        /// </summary>
        /// <returns>Error code = 1100 </returns>
        public int ERR_IMAGE_FILE_NOTSUPPORTED => CallStatic<int>("ERR_IMAGE_FILE_NOTSUPPORTED");
        /// <summary>
        /// The number of image files is not supported.
        /// </summary>
        /// <returns>Error code = 1102 </returns>
        public int ERR_FILE_NUMBER_NOT_SUPPORT => CallStatic<int>("ERR_FILE_NUMBER_NOT_SUPPORT");
        /// <summary>
        /// The image file size is too large.
        /// </summary>
        /// <returns>Error code = 1101 </returns>
        public int ERR_FILE_SIZE_OVERFLOW => CallStatic<int>("ERR_FILE_SIZE_OVERFLOW");
        /// <summary>
        /// The image file does not exist.
        /// </summary>
        /// <returns>Error code = 1103 </returns>
        public int ERR_FILE_NOT_FOUND => CallStatic<int>("ERR_FILE_NOT_FOUND");
        /// <summary>
        /// The number of API calls exceeds the daily maximum.
        /// </summary>
        /// <returns>Error code = 1118 </returns>
        public int ERR_RET_OVER_DAY_MAX_LIMIT => CallStatic<int>("ERR_RET_OVER_DAY_MAX_LIMIT");
        /// <summary>
        /// The number of API calls exceeds the monthly maximum.
        /// </summary>
        /// <returns>Error code = 1137 </returns>
        public int ERR_RET_OVER_MONTH_MAX_LIMIT => CallStatic<int>("ERR_RET_OVER_MONTH_MAX_LIMIT");
        /// <summary>
        /// Invalid parameter.
        /// </summary>
        /// <returns>Error code = 1104 </returns>
        public int ERR_ILLEGAL_PARAMETER => CallStatic<int>("ERR_ILLEGAL_PARAMETER");
        /// <summary>
        /// The reconstruction engine is busy.
        /// </summary>
        /// <returns>Error code = 1105 </returns>
        public int ERR_ENGINE_BUSY => CallStatic<int>("ERR_ENGINE_BUSY");
        /// <summary>
        /// Image upload failed.
        /// </summary>
        /// <returns>Error code = 1106 </returns>
        public int ERR_UPLOAD_FILE_FAILED => CallStatic<int>("ERR_UPLOAD_FILE_FAILED");
        /// <summary>
        /// The task is being executed and cannot be submitted again.
        /// </summary>
        /// <returns>Error code = 1107 </returns>
        public int ERR_TASK_ALREADY_INPROGRESS => CallStatic<int>("ERR_TASK_ALREADY_INPROGRESS");
        /// <summary>
        /// Query failed.
        /// </summary>
        /// <returns>Error code = 1108 </returns>
        public int ERR_QUERY_FAILED => CallStatic<int>("ERR_QUERY_FAILED");
        /// <summary>
        /// Download failed.
        /// </summary>
        /// <returns>Error code = 1109 </returns>
        public int ERR_DOWNLOAD_FAILED => CallStatic<int>("ERR_DOWNLOAD_FAILED");
        /// <summary>
        /// Network connection error.
        /// </summary>
        /// <returns>Error code = 1110 </returns>
        public int ERR_NETCONNECT_FAILED => CallStatic<int>("ERR_NETCONNECT_FAILED");
        /// <summary>
        /// Authentication failed.
        /// </summary>
        /// <returns>Error code = 1111 </returns>
        public int ERR_AUTHORIZE_FAILED => CallStatic<int>("ERR_AUTHORIZE_FAILED");
        /// <summary>
        /// Server error.
        /// </summary>
        /// <returns>Error code = 1112 </returns>
        public int ERR_SERVICE_EXCEPTION => CallStatic<int>("ERR_SERVICE_EXCEPTION");
        /// <summary>
        /// Internal error.
        /// </summary>
        /// <returns>Error code = 1113 </returns>
        public int ERR_INTERNAL => CallStatic<int>("ERR_INTERNAL");
        /// <summary>
        /// The 3D object reconstruction task does not exist.
        /// </summary>
        /// <returns>Error code = 1114 </returns>
        public int ERR_TASKID_NOT_EXISTED => CallStatic<int>("ERR_TASKID_NOT_EXISTED");
        /// <summary>
        /// Invalid task status.
        /// </summary>
        /// <returns>Error code = 1115 </returns>
        public int ERR_ILLEGAL_TASK_STATUS => CallStatic<int>("ERR_ILLEGAL_TASK_STATUS");
        /// <summary>
        /// The access token is invalid or has expired.
        /// </summary>
        /// <returns>Error code = 1116 </returns>
        public int ERR_ILLEGAL_TOKEN => CallStatic<int>("ERR_ILLEGAL_TOKEN");
        /// <summary>
        /// The task result has expired.
        /// </summary>
        /// <returns>Error code = 1117 </returns>
        public int ERR_TASK_EXPIRED => CallStatic<int>("ERR_TASK_EXPIRED");
        /// <summary>
        /// Failed to cancel the upload.
        /// </summary>
        /// <returns>Error code = 1119 </returns>
        public int ERR_UPLOAD_CANCEL_FAILED => CallStatic<int>("ERR_UPLOAD_CANCEL_FAILED");
        /// <summary>
        /// Failed to cancel the download
        /// </summary>
        /// <returns>Error code = 1120 </returns>
        public int ERR_DOWNLOAD_CANCEL_FAILED => CallStatic<int>("ERR_DOWNLOAD_CANCEL_FAILED");
        /// <summary>
        /// Task initialization failed.
        /// </summary>
        /// <returns>Error code = 1121 </returns>
        public int ERR_INIT_TASK_FAILED => CallStatic<int>("ERR_INIT_TASK_FAILED");
        /// <summary>
        /// Unknown error.
        /// </summary>
        /// <returns>Error code = 1122 </returns>
        public int ERR_UNKNOWN => CallStatic<int>("ERR_UNKNOWN");
        /// <summary>
        /// Unsupported input image resolution.
        /// </summary>
        /// <returns>Error code = 1123 </returns>
        public int ERR_IMAGE_RESOLUTION_NOTSUPPORTED => CallStatic<int>("ERR_IMAGE_RESOLUTION_NOTSUPPORTED");
        /// <summary>
        /// Inconsistent input image resolutions.
        /// </summary>
        /// <returns>Error code = 1124 </returns>
        public int ERR_IMAGE_RESOLUTION_INCONSISTENT => CallStatic<int>("ERR_IMAGE_RESOLUTION_INCONSISTENT");
        /// <summary>
        /// Unsupported input image format.
        /// </summary>
        /// <returns>Error code = 1125 </returns>
        public int ERR_IMAGE_TYPE_INCONSISTENT => CallStatic<int>("ERR_IMAGE_TYPE_INCONSISTENT");
        /// <summary>
        /// Failed to preview the model.
        /// </summary>
        /// <returns>Error code = 1126 </returns>
        public int ERR_MODEL_PREVIEW_FAILED => CallStatic<int>("ERR_MODEL_PREVIEW_FAILED");
        /// <summary>
        /// Failed to delete the uploaded files from the cloud.
        /// </summary>
        /// <returns>Error code = 1127 </returns>
        public int ERR_DELETE_REMOTE_FILE_FAILED => CallStatic<int>("ERR_DELETE_REMOTE_FILE_FAILED");
        /// <summary>
        /// The task is restricted.
        /// </summary>
        /// <returns>Error code = 1128 </returns>
        public int ERR_TASK_RESTRICTED => CallStatic<int>("ERR_TASK_RESTRICTED");
        /// <summary>
        /// The data processing location is not set.
        /// </summary>
        /// <returns>Error code = 1129 </returns>
        public int ERR_DATA_PROCESSING_LOCATION_NOT_SET => CallStatic<int>("ERR_DATA_PROCESSING_LOCATION_NOT_SET");
        /// <summary>
        /// The glTF format is not supported under the PBR mode.
        /// </summary>
        /// <returns>Error code = 1130 </returns>
        public int ERR_GLTF_NOT_SUPPORT_PBR_TEXTURE_MODE => CallStatic<int>("ERR_GLTF_NOT_SUPPORT_PBR_TEXTURE_MODE");
        /// <summary>
        /// Invalid parameter.
        /// </summary>
        /// <returns>Error code = 1131 </returns>
        public int ERR_PBR_MODE_NOT_EXIST => CallStatic<int>("ERR_PBR_MODE_NOT_EXIST");
        /// <summary>
        /// The free quota for 3D Modeling Kit has been used up.
        /// </summary>
        /// <returns>Error code = 1132 </returns>
        public int ERR_RET_BILLING_QUOTA_EXHAUSTED => CallStatic<int>("ERR_RET_BILLING_QUOTA_EXHAUSTED");
        /// <summary>
        /// The account balance is insufficient to use 3D Modeling Kit.
        /// </summary>
        /// <returns>Error code = 1133 </returns>
        public int ERR_RET_BILLING_OVERDUE => CallStatic<int>("ERR_RET_BILLING_OVERDUE");
        /// <summary>
        /// The free quota for 3D Modeling Kit has been used up.
        /// </summary>
        /// <returns>Error code = 1134 </returns>
        public int ERR_RET_ORDER_NOT_EXIST => CallStatic<int>("ERR_RET_ORDER_NOT_EXIST");
        /// <summary>
        /// Preview is not supported for auto rigging.
        /// </summary>
        /// <returns>Error code = 1135 </returns>
        public int ERR_AUTO_RIGGING_NOT_SUPPORT_PREVIEW => CallStatic<int>("ERR_AUTO_RIGGING_NOT_SUPPORT_PREVIEW");
        /// <summary>
        /// The number of extra scanning tasks exceeds the maximum.
        /// </summary>
        /// <returns>Error code = 1136 </returns>
        public int ERR_RET_OVER_RESCAN_LIMIT => CallStatic<int>("ERR_RET_OVER_RESCAN_LIMIT");
        /// <summary>
        /// Extra scanning is unsupported by auto rigging.
        /// </summary>
        /// <returns>Error code = 1138 </returns>
        public int ERR_RET_RIGGING_NOT_SUPPORT_RESCAN => CallStatic<int>("ERR_RET_RIGGING_NOT_SUPPORT_RESCAN");
        /// <summary>
        /// The mesh count level of an extra scanning task is inconsistent with that of the original task.
        /// </summary>
        /// <returns>Error code = 1139 </returns>
        public int ERR_RET_PARAM_FACELEVEL_NOT_CONSISTENT_WITH_RESCAN => CallStatic<int>("ERR_RET_PARAM_FACELEVEL_NOT_CONSISTENT_WITH_RESCAN");


    }
}