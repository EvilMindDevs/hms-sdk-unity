using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby
{
    public class StatusCode : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public StatusCode(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.StatusCode");
        public static int STATUS_SUCCESS => androidJavaClass.GetStatic<int>("STATUS_SUCCESS");
        public static int STATUS_FAILURE => androidJavaClass.GetStatic<int>("STATUS_FAILURE");
        public static int STATUS_API_DISORDER => androidJavaClass.GetStatic<int>("STATUS_API_DISORDER");
        public static int STATUS_NO_NETWORK => androidJavaClass.GetStatic<int>("STATUS_NO_NETWORK");
        public static int STATUS_NOT_CONNECTED => androidJavaClass.GetStatic<int>("STATUS_NOT_CONNECTED");
        public static int STATUS_TRANSFER_IO_ERROR => androidJavaClass.GetStatic<int>("STATUS_TRANSFER_IO_ERROR");
        public static int STATUS_ALREADY_BROADCASTING => androidJavaClass.GetStatic<int>("STATUS_ALREADY_BROADCASTING");
        public static int STATUS_ALREADY_CONNECTED => androidJavaClass.GetStatic<int>("STATUS_ALREADY_CONNECTED");
        public static int STATUS_ALREADY_SCANNING => androidJavaClass.GetStatic<int>("STATUS_ALREADY_SCANNING");
        public static int STATUS_POLICY_CONFLICT => androidJavaClass.GetStatic<int>("STATUS_POLICY_CONFLICT");
        public static int STATUS_BLUETOOTH_OPERATION_FAILED => androidJavaClass.GetStatic<int>("STATUS_BLUETOOTH_OPERATION_FAILED");
        public static int STATUS_CONNECT_REJECTED => androidJavaClass.GetStatic<int>("STATUS_CONNECT_REJECTED");
        public static int STATUS_CONNECT_IO_ERROR => androidJavaClass.GetStatic<int>("STATUS_CONNECT_IO_ERROR");
        public static int STATUS_ENDPOINT_UNKNOWN => androidJavaClass.GetStatic<int>("STATUS_ENDPOINT_UNKNOWN");
        public static int STATUS_API_OCCUPIED => androidJavaClass.GetStatic<int>("STATUS_API_OCCUPIED");
        public static int STATUS_MISSING_PERMISSION_ACCESS_COARSE_LOCATION => androidJavaClass.GetStatic<int>("STATUS_MISSING_PERMISSION_ACCESS_COARSE_LOCATION");
        public static int STATUS_MISSING_PERMISSION_ACCESS_WIFI_STATE => androidJavaClass.GetStatic<int>("STATUS_MISSING_PERMISSION_ACCESS_WIFI_STATE");
        public static int STATUS_MISSING_PERMISSION_BLUETOOTH => androidJavaClass.GetStatic<int>("STATUS_MISSING_PERMISSION_BLUETOOTH");
        public static int STATUS_MISSING_PERMISSION_BLUETOOTH_ADMIN => androidJavaClass.GetStatic<int>("STATUS_MISSING_PERMISSION_BLUETOOTH_ADMIN");
        public static int STATUS_MISSING_PERMISSION_CHANGE_WIFI_STATE => androidJavaClass.GetStatic<int>("STATUS_MISSING_PERMISSION_CHANGE_WIFI_STATE");
        public static int STATUS_MISSING_PERMISSION_RECORD_AUDIO => androidJavaClass.GetStatic<int>("STATUS_MISSING_PERMISSION_RECORD_AUDIO");
        public static int STATUS_MISSING_SETTING_LOCATION_ON => androidJavaClass.GetStatic<int>("STATUS_MISSING_SETTING_LOCATION_ON");
        public static int STATUS_AIRPLANE_MODE_MUST_BE_OFF => androidJavaClass.GetStatic<int>("STATUS_AIRPLANE_MODE_MUST_BE_OFF");
        public static int STATUS_MESSAGE_APP_UNREGISTERED => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_APP_UNREGISTERED");
        public static int STATUS_MESSAGE_APP_QUOTA_LIMITED => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_APP_QUOTA_LIMITED");
        public static int STATUS_MESSAGE_BLE_BROADCASTING_UNSUPPORTED => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_BLE_BROADCASTING_UNSUPPORTED");
        public static int STATUS_MESSAGE_BLE_SCANNING_UNSUPPORTED => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_BLE_SCANNING_UNSUPPORTED");
        public static int STATUS_MESSAGE_BLUETOOTH_OFF => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_BLUETOOTH_OFF");
        public static int STATUS_MESSAGE_WRONG_CONTEXT => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_WRONG_CONTEXT");
        public static int STATUS_MESSAGE_NOT_ALLOW => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_NOT_ALLOW");
        public static int STATUS_MESSAGE_MISSING_PERMISSIONS => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_MISSING_PERMISSIONS");
        public static int STATUS_MESSAGE_AUTH_FAILED => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_AUTH_FAILED");
        public static int STATUS_MESSAGE_PENDING_INTENTS_LIMITED => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_PENDING_INTENTS_LIMITED");
        public static int STATUS_INTERNAL_ERROR => androidJavaClass.GetStatic<int>("STATUS_INTERNAL_ERROR");
        public static int STATUS_FINDING_MODE_ERROR => androidJavaClass.GetStatic<int>("STATUS_FINDING_MODE_ERROR");
        public static int STATUS_MESSAGE_TASK_ALREADY_IN_PROCESSING => androidJavaClass.GetStatic<int>("STATUS_MESSAGE_TASK_ALREADY_IN_PROCESSING");
        public static int STATUS_MISSING_PERMISSION_FILE_READ_WRITE => androidJavaClass.GetStatic<int>("STATUS_MISSING_PERMISSION_FILE_READ_WRITE");
        public static int STATUS_MISSING_PERMISSION_INTERNET => androidJavaClass.GetStatic<int>("STATUS_MISSING_PERMISSION_INTERNET");
        public static int STATUS_WIFI_SHARE_USER_AUTH_FAIL => androidJavaClass.GetStatic<int>("STATUS_WIFI_SHARE_USER_AUTH_FAIL");
        public static int STATUS_WIFI_SHARE_WIFI_CLOSED => androidJavaClass.GetStatic<int>("STATUS_WIFI_SHARE_WIFI_CLOSED");
        public static int STATUS_WIFI_CONNECT_FAIL => androidJavaClass.GetStatic<int>("STATUS_WIFI_CONNECT_FAIL");
    }
}
