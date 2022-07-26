using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class StorageException : JavaObjectWrapper
    {
        public StorageException(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.StorageException");

        public static readonly int ERROR_UNKNOWN = javaClass.GetStatic<int>("ERROR_UNKNOWN");
        public static readonly int ERROR_PROJECT_NOT_FOUND = javaClass.GetStatic<int>("ERROR_PROJECT_NOT_FOUND");
        public static readonly int ERROR_BUCKET_NOT_FOUND = javaClass.GetStatic<int>("ERROR_BUCKET_NOT_FOUND");
        public static readonly int ERROR_OBJECT_NOT_FOUND = javaClass.GetStatic<int>("ERROR_OBJECT_NOT_FOUND");
        public static readonly int ERROR_QUOTA_EXCEEDED = javaClass.GetStatic<int>("ERROR_QUOTA_EXCEEDED");
        public static readonly int ERROR_NOT_AUTHENTICATED = javaClass.GetStatic<int>("ERROR_NOT_AUTHENTICATED");
        public static readonly int ERROR_NOT_PERMISSION = javaClass.GetStatic<int>("ERROR_NOT_PERMISSION");
        public static readonly int ERROR_OPERATION_FREQUENT = javaClass.GetStatic<int>("ERROR_OPERATION_FREQUENT");
        public static readonly int ERROR_INVALID_HASH_VERIFY = javaClass.GetStatic<int>("ERROR_INVALID_HASH_VERIFY");
        public static readonly int ERROR_CANCELED = javaClass.GetStatic<int>("ERROR_CANCELED");
        public static readonly int ERROR_REQUEST_TIMEOUT = javaClass.GetStatic<int>("ERROR_REQUEST_TIMEOUT");
        public static readonly int ERROR_FILE_ACCESS = javaClass.GetStatic<int>("ERROR_FILE_ACCESS");
        public static readonly int ERROR_SERVER_RSP_INVALID = javaClass.GetStatic<int>("ERROR_SERVER_RSP_INVALID");
        public static readonly int ERROR_META_SHA_EMPTY = javaClass.GetStatic<int>("ERROR_META_SHA_EMPTY");
        public static readonly int ERROR_NETWORK_UNAVAILABLE = javaClass.GetStatic<int>("ERROR_NETWORK_UNAVAILABLE");
        public static readonly int ERROR_RANGE_UNSATISFIABLE = javaClass.GetStatic<int>("ERROR_RANGE_UNSATISFIABLE");
        public static readonly int ERROR_REQUEST_DENIED = javaClass.GetStatic<int>("ERROR_REQUEST_DENIED");
        public static readonly int ERROR_PARAM_INVALID = javaClass.GetStatic<int>("ERROR_PARAM_INVALID");

        public static StorageException FromErrorStatus(int status) =>
            javaClass.CallStaticAsWrapper<StorageException>("fromErrorStatus", status);

        public static StorageException FromErrorAndRequestId(int status, string requestId) =>
            javaClass.CallStaticAsWrapper<StorageException>("fromErrorAndRequestId", status, requestId);

        public static StorageException FromHttpCodeAndRequestId(int httpStatusCode, int httpErrorCode, string requestId) =>
            javaClass.CallStaticAsWrapper<StorageException>("fromHttpCodeAndRequestId", httpStatusCode, httpErrorCode, requestId);
        public static StorageException fromHttpCodeAndRequestId(AndroidJavaObject exception, int httpStatusCode, int httpErrorCode, string requestId) =>
            javaClass.CallStaticAsWrapper<StorageException>("fromHttpCodeAndRequestId", exception, httpStatusCode, httpErrorCode, requestId);
        public static StorageException FromException(AndroidJavaObject exception) =>
            javaClass.CallStaticAsWrapper<StorageException>("fromException", exception);
        public static StorageException FromException(AndroidJavaObject exception, int httpStatusCode) =>
            javaClass.CallStaticAsWrapper<StorageException>("FromException", exception, httpStatusCode);

        public int ErrorCode
        {
            get => Call<int>("getErrorCode");
        }

        public int HttpCode
        {
            get => Call<int>("getHttpCode");
        }

        public AndroidJavaObject Cause
        {
            get => Call<AndroidJavaObject>("getCause"); // TODO CallAsWrapper test this?
        }

        public bool OverRetryTimes
        {
            get => Call<bool>("overRetryTimes");
        }

    }
}
