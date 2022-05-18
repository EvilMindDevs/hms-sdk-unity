using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{

    /*
    * com.huawei.hms.support.api.entity.core.CommonCode;
    */
        public class CommonCode
        {
            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.support.api.entity.core.CommonCode");

            public static readonly int OK = sJavaClass.GetStatic<int>("OK");
            public static readonly int ERROR = sJavaClass.GetStatic<int>("ERROR");
            public static readonly int UNBIND_SERVICE = sJavaClass.GetStatic<int>("UNBIND_SERVICE");
        
            public class ErrorCode
            {
                private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.support.api.entity.core.CommonCode$ErrorCode");

                public static readonly int ARGUMENTS_INVALID = sJavaClass.GetStatic<int>("ARGUMENTS_INVALID");
                public static readonly int INTERNAL_ERROR = sJavaClass.GetStatic<int>("INTERNAL_ERROR");
                public static readonly int NAMING_INVALID = sJavaClass.GetStatic<int>("NAMING_INVALID");
                public static readonly int CLIENT_API_INVALID = sJavaClass.GetStatic<int>("CLIENT_API_INVALID");
                public static readonly int EXECUTE_TIMEOUT = sJavaClass.GetStatic<int>("EXECUTE_TIMEOUT");
                public static readonly int NOT_IN_SERVICE = sJavaClass.GetStatic<int>("NOT_IN_SERVICE");
                public static readonly int SESSION_INVALID = sJavaClass.GetStatic<int>("SESSION_INVALID");
                public static readonly int HMS_VERSION_CONFIGER_INVALID = sJavaClass.GetStatic<int>("HMS_VERSION_CONFIGER_INVALID");
            }

            public class StatusCode
            {
                private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.support.api.entity.core.CommonCode$StatusCode");

                public static readonly int API_UNAVAILABLE = sJavaClass.GetStatic<int>("API_UNAVAILABLE");
                public static readonly int API_CLIENT_EXPIRED = sJavaClass.GetStatic<int>("API_CLIENT_EXPIRED");
            }
        }


    /*
     * com.huawei.hms.adapter.internal.AvailableCode
     */
        public class AvailableCode
        {
            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.adapter.internal.AvailableCode");

            public static readonly int SUCCESS = sJavaClass.GetStatic<int>("SUCCESS");
            public static readonly int SERVICE_UNSUPPORTED = sJavaClass.GetStatic<int>("SERVICE_UNSUPPORTED");
            public static readonly int SERVICE_MISSING = sJavaClass.GetStatic<int>("SERVICE_MISSING");
            public static readonly int SERVICE_DISABLED = sJavaClass.GetStatic<int>("SERVICE_DISABLED");
            public static readonly int SERVICE_VERSION_UPDATE_REQUIRED = sJavaClass.GetStatic<int>("SERVICE_VERSION_UPDATE_REQUIRED");
            public static readonly int CANCELED = sJavaClass.GetStatic<int>("CANCELED");
            public static readonly int ERROR_ON_ACTIVITY_RESULT = sJavaClass.GetStatic<int>("ERROR_ON_ACTIVITY_RESULT");
            public static readonly int ERROR_NO_ACTIVITY = sJavaClass.GetStatic<int>("ERROR_NO_ACTIVITY");
            public static readonly int USER_IGNORE_PREVIOUS_POPUP = sJavaClass.GetStatic<int>("USER_IGNORE_PREVIOUS_POPUP");
            public static readonly int APP_IS_BACKGROUND_OR_LOCKED = sJavaClass.GetStatic<int>("APP_IS_BACKGROUND_OR_LOCKED");
            public static readonly int HMS_IS_SPOOF = sJavaClass.GetStatic<int>("HMS_IS_SPOOF");
            public static readonly int USER_ALREADY_KNOWS_SERVICE_UNAVAILABLE = sJavaClass.GetStatic<int>("USER_ALREADY_KNOWS_SERVICE_UNAVAILABLE");
            public static readonly int CURRENT_SHOWING_SERVICE_UNAVAILABLE = sJavaClass.GetStatic<int>("CURRENT_SHOWING_SERVICE_UNAVAILABLE");
        }

}
