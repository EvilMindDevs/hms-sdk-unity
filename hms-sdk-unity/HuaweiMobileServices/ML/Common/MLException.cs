using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.Common
{
    public class MLException : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.common.MLException";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public MLException(AndroidJavaObject javaObject) : base(javaObject) { }
        public MLException(string message, int code) : base(CLASS_NAME, message, code) { }
        public MLException(string message, int code, AndroidJavaObject innerException) : base(CLASS_NAME, message, code, innerException) { }


        private static int UNKNOWN => sJavaClass.GetStatic<int>(nameof(UNKNOWN));
        private static int SUCCESS => sJavaClass.GetStatic<int>(nameof(SUCCESS));
        private static int DISCARDED => sJavaClass.GetStatic<int>(nameof(DISCARDED));
        private static int INNER => sJavaClass.GetStatic<int>(nameof(INNER));
        private static int INACTIVE => sJavaClass.GetStatic<int>(nameof(INACTIVE));
        private static int NOT_SUPPORTED => sJavaClass.GetStatic<int>(nameof(NOT_SUPPORTED));
        private static int ILLEGAL_PARAMETER => sJavaClass.GetStatic<int>(nameof(ILLEGAL_PARAMETER));
        private static int OVERDUE => sJavaClass.GetStatic<int>(nameof(OVERDUE));
        private static int NO_FOUND => sJavaClass.GetStatic<int>(nameof(NO_FOUND));
        private static int DUPLICATE_FOUND => sJavaClass.GetStatic<int>(nameof(DUPLICATE_FOUND));
        private static int NOT_PERMISSION => sJavaClass.GetStatic<int>(nameof(NOT_PERMISSION));
        private static int INSUFFICIENT_RESOURCE => sJavaClass.GetStatic<int>(nameof(INSUFFICIENT_RESOURCE));
        private static int ANALYSIS_FAILURE => sJavaClass.GetStatic<int>(nameof(ANALYSIS_FAILURE));
        private static int INTERRUPTED => sJavaClass.GetStatic<int>(nameof(INTERRUPTED));
        private static int EXCEED_RANGE => sJavaClass.GetStatic<int>(nameof(EXCEED_RANGE));
        private static int DATA_MISSING => sJavaClass.GetStatic<int>(nameof(DATA_MISSING));
        private static int AUTHENTICATION_REQUIRED => sJavaClass.GetStatic<int>(nameof(AUTHENTICATION_REQUIRED));
        private static int TFLITE_NOT_COMPATIBLE => sJavaClass.GetStatic<int>(nameof(TFLITE_NOT_COMPATIBLE));
        private static int INSUFFICIENT_SPACE => sJavaClass.GetStatic<int>(nameof(INSUFFICIENT_SPACE));
        private static int HASH_MISS => sJavaClass.GetStatic<int>(nameof(HASH_MISS));
        private static int TOKEN_INVALID => sJavaClass.GetStatic<int>(nameof(TOKEN_INVALID));

        public int ErrorCode => Call<int>("getErrCode");


    }
}
