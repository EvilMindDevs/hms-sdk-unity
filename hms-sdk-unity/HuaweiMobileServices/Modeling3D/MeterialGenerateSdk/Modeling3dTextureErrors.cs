using HuaweiMobileServices.Utils;
using UnityEngine;
namespace HuaweiMobileServices.Modeling3D.MeterialGenerateSdk
{
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.Modeling3dTextureErrors.
    /// <see cref="Modeling3dTextureErrors" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureerrors-0000001106293434"/>
    /// </summary>
    public class Modeling3dTextureErrors : JavaObjectWrapper
    {
        public Modeling3dTextureErrors(AndroidJavaObject javaObject) : base(javaObject)
        {
        }
        //Not necessary to implement this because class name is the same as the java class name
        //private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.materialgeneratesdk.Modeling3dTextureErrors");

        /// <summary>
        /// Authentication failed.
        /// </summary>
        /// <returns>1201</returns>
        public int ERR_AUTHORIZE_FAILED => CallStatic<int>("ERR_AUTHORIZE_FAILED");
        /// <summary>
        /// The data processing location is not set.
        /// </summary>
        /// <return>1203</return>
        public int ERR_DATA_PROCESSING_LOCATION_NOT_SET => CallStatic<int>("ERR_DATA_PROCESSING_LOCATION_NOT_SET");
        /// <summary>
        /// Failed to delete the uploaded files from the cloud.
        /// </summary>
        /// <returns>1231</returns>
        public int ERR_DELETE_REMOTE_TASK_FAILED => CallStatic<int>("ERR_DELETE_REMOTE_TASK_FAILED");
        /// <summary>
        /// Failed to cancel the download.
        /// </summary>
        /// <returns>1229</returns>
        public int ERR_DOWNLOAD_CANCEL_FAILED => CallStatic<int>("ERR_DOWNLOAD_CANCEL_FAILED");
        /// <summary>
        /// Download failed.
        /// </summary>
        /// <returns>1227</returns>
        public int ERR_DOWNLOAD_FAILED => CallStatic<int>("ERR_DOWNLOAD_FAILED");
        /// <summary>
        /// The material generation engine is busy.
        /// </summary>
        /// <returns>1220</returns>
        public int ERR_ENGINE_BUSY => CallStatic<int>("ERR_ENGINE_BUSY");
        /// <summary>
        /// The image file does not exist.
        /// </summary>
        /// <returns>1213</returns>
        public int ERR_FILE_NOT_FOUND => CallStatic<int>("ERR_FILE_NOT_FOUND");
        /// <summary>
        /// The number of images exceeds the maximum.
        /// </summary>
        /// <returns>1211</returns>
        public int ERR_FILE_NUM_OVERFLOW => CallStatic<int>("ERR_FILE_NUM_OVERFLOW");
        /// <summary>
        /// The image file size is too large.
        /// </summary>
        /// <returns>1212</returns>
        public int ERR_FILE_SIZE_OVERFLOW => CallStatic<int>("ERR_FILE_SIZE_OVERFLOW");
        /// <summary>
        /// Invalid parameter.
        /// </summary>
        /// <returns>1200</returns>
        public int ERR_ILLEGAL_PARAMETER => CallStatic<int>("ERR_ILLEGAL_PARAMETER");
        /// <summary>
        /// Invalid task status.
        /// </summary>
        /// <returns>1205</returns>
        public int ERR_ILLEGAL_TASK_STATUS => CallStatic<int>("ERR_ILLEGAL_TASK_STATUS");
        /// <summary>
        /// The access token is invalid or has expired.
        /// </summary>
        /// <returns>1202</returns>
        public int ERR_ILLEGAL_TOKEN => CallStatic<int>("ERR_ILLEGAL_TOKEN");
        /// <summary>
        /// Unsupported image format.
        /// </summary>
        /// <returns>1210</returns>
        public int ERR_IMAGE_FILE_NOTSUPPORTED => CallStatic<int>("ERR_IMAGE_FILE_NOTSUPPORTED");
        /// <summary>
        /// Unsupported input image resolution.
        /// </summary>
        /// <returns>1214</returns>
        public int ERR_IMAGE_RESOLUTION_NOTSUPPORTED => CallStatic<int>("ERR_IMAGE_RESOLUTION_NOTSUPPORTED");
        /// <summary>
        /// Insufficient device storage space.
        /// </summary>
        /// <returns>1226</returns>
        public int ERR_INSUFFICIENT_SPACE => CallStatic<int>("ERR_INSUFFICIENT_SPACE");
        /// <summary>
        /// Internal error.
        /// </summary>
        /// <returns>1298</returns>
        public int ERR_INTERNAL => CallStatic<int>("ERR_INTERNAL");
        /// <summary>
        /// Failed to preview the generated material.
        /// </summary>
        /// <returns>1230</returns>
        public int ERR_MODEL_PREVIEW_FAILED => CallStatic<int>("ERR_MODEL_PREVIEW_FAILED");
        /// <summary>
        /// Network connection error.
        /// </summary>
        /// <returns>1221</returns>
        public int ERR_NETCONNECT_FAILED => CallStatic<int>("ERR_NETCONNECT_FAILED");
        /// <summary>
        /// Query failed.
        /// </summary>
        /// <returns>1225</returns>
        public int ERR_QUERY_FAILED => CallStatic<int>("ERR_QUERY_FAILED");
        /// <summary>
        /// The number of API calls exceeds the maximum.
        /// </summary>
        /// <returns>1208</returns>
        public int ERR_RET_OVER_MAX_LIMIT => CallStatic<int>("ERR_RET_OVER_MAX_LIMIT");
        /// <summary>
        /// Server error.
        /// </summary>
        /// <returns>1206</returns>
        public int ERR_SERVICE_EXCEPTION => CallStatic<int>("ERR_SERVICE_EXCEPTION");
        /// <summary>
        /// The task result has expired.
        /// </summary>
        /// <returns>1207</returns>
        public int ERR_TASK_EXPIRED => CallStatic<int>("ERR_TASK_EXPIRED");
        /// <summary>
        /// Task initialization failed.
        /// </summary>
        /// <returns>1222</returns>
        public int ERR_TASK_INIT_FAILED => CallStatic<int>("ERR_TASK_INIT_FAILED");
        /// <summary>
        /// The task is restricted.
        /// </summary>
        /// <returns>1209</returns>
        public int ERR_TASK_RESTRICTED => CallStatic<int>("ERR_TASK_RESTRICTED");
        /// <summary>
        /// The task is being executed and cannot be submitted again.
        /// </summary>
        /// <returns>1223</returns>
        public int ERR_TASKID_ALREADY_INPROGRESS => CallStatic<int>("ERR_TASKID_ALREADY_INPROGRESS");
        /// <summary>
        /// The task does not exist.
        /// </summary>
        /// <returns>1204</returns>
        public int ERR_TASKID_NOT_EXISTED => CallStatic<int>("ERR_TASKID_NOT_EXISTED");
        /// <summary>
        /// Failed to cancel the upload.
        /// </summary>
        /// <returns>1228</returns>
        public int ERR_UPLOAD_CANCEL_FAILED => CallStatic<int>("ERR_UPLOAD_CANCEL_FAILED");
        /// <summary>
        /// File upload failed.
        /// </summary>
        /// <returns>1224</returns>
        public int ERR_UPLOAD_FILE_FAILED => CallStatic<int>("ERR_UPLOAD_FILE_FAILED");
        /// <summary>
        /// Unknown error.
        /// </summary>
        /// <returns>1299</returns>
        public int ERR_UNKNOWN => CallStatic<int>("ERR_UNKNOWN");


    }
}