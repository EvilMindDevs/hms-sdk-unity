namespace HuaweiMobileServices.Base
{
    using System;
    using UnityEngine;

    public static class ServiceHelper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.helper.ServiceHelper");

        public static bool GMSAvailable => sJavaClass.CallStatic<bool>("isGMSAvailable");

        public static bool HMSAvailable => sJavaClass.CallStatic<bool>("isHMSAvailable");

        public static string HMSCoreVersionName => sJavaClass.CallStatic<string>("getHMSCoreVersionName");

        public static int ServicesVersionCode => sJavaClass.CallStatic<int>("getServicesVersionCode");
        public static void SetServicesVersionCode(int servicesVersionCode) => sJavaClass.CallStatic("setServicesVersionCode", servicesVersionCode);
        public static int IsHuaweiMobileServicesAvailable => sJavaClass.CallStatic<int>("isHuaweiMobileServicesAvailable");
        public static int IsHuaweiMobileServicesAvailableParameter(int minApkVersion) => sJavaClass.CallStatic<int>("isHuaweiMobileServicesAvailable", minApkVersion);
        public static int IsHuaweiMobileNoticeAvailable(int minApkVersion) => sJavaClass.CallStatic<int>("isHuaweiMobileNoticeAvailable", minApkVersion); 
        public static bool IsUserResolvableError(int errorCode) => sJavaClass.CallStatic<bool>("isUserResolvableError", errorCode);
        public static void ResolveError(int errorCode, int requestCode) => sJavaClass.CallStatic("resolveError", errorCode, requestCode);
        public static string ErrorString(int errorCode) => sJavaClass.CallStatic<string>("getErrorString", errorCode);
        public static void ShowErrorNotification(int errorCode) => sJavaClass.CallStatic("showErrorNotification", errorCode);
        public static string APPIDHMS => sJavaClass.GetStatic<string>("APPID_HMS");
        public static string APPIDHMSTV => sJavaClass.GetStatic<string>("APPID_HMS_TV");
        public static int NOTICEVERSIONCODE => sJavaClass.GetStatic<int>("NOTICE_VERSION_CODE");
        public static int HMSVERSIONMIN => sJavaClass.GetStatic<int>("HMS_VERSION_MIN");
        public static int HMSJSONVERSIONMIN => sJavaClass.GetStatic<int>("HMS_JSON_VERSION_MIN");
        public static int HMSVERSIONMAX => sJavaClass.GetStatic<int>("HMS_VERSION_MAX");
        public static int HMSVERSIONCODEMIN => sJavaClass.GetStatic<int>("HMS_VERSION_CODE_MIN");
        public static string HMSAPINAMEID => sJavaClass.GetStatic<string>("HMS_API_NAME_ID");
        public static int HMSVERSIONCODEID => sJavaClass.GetStatic<int>("HMS_VERSION_CODE_ID");
        public static string HMSAPINAMESNS => sJavaClass.GetStatic<string>("HMS_API_NAME_SNS");
        public static int HMSVERSIONCODESNS => sJavaClass.GetStatic<int>("HMS_VERSION_CODE_SNS");
        public static string HMSAPINAMEPAY => sJavaClass.GetStatic<string>("HMS_API_NAME_PAY");
        public static int HMSVERSIONCODEPAY => sJavaClass.GetStatic<int>("HMS_VERSION_CODE_PAY");
        public static string HMSAPINAMEPUSH => sJavaClass.GetStatic<string>("HMS_API_NAME_PUSH");
        public static int HMSVERSIONCODEPUSH => sJavaClass.GetStatic<int>("HMS_VERSION_CODE_PUSH");
        public static string HMSAPINAMEGAME => sJavaClass.GetStatic<string>("HMS_API_NAME_GAME");
        public static int HMSVERSIONCODEGAME => sJavaClass.GetStatic<int>("HMS_VERSION_CODE_GAME");
        public static string HMSAPINAMEOD => sJavaClass.GetStatic<string>("HMS_API_NAME_OD");
        public static int HMSVERSIONCODEOD => sJavaClass.GetStatic<int>("HMS_VERSION_CODE_OD");
        public static string HMSAPINAMEIAP => sJavaClass.GetStatic<string>("HMS_API_NAME_IAP");
        public static int HMSVERSIONCODEIAP => sJavaClass.GetStatic<int>("HMS_VERSION_CODE_IAP");
        public static string HMSAPINAMEPPS => sJavaClass.GetStatic<string>("HMS_API_NAME_PPS");
        public static int HMSVERSIONCODEPPS => sJavaClass.GetStatic<int>("HMS_VERSION_CODE_PPS");
        public static int SERVICESVERSIONCODE => sJavaClass.GetStatic<int>("SERVICES_VERSION_CODE");
        public static int HMSSDKVERSIONCODE => sJavaClass.GetStatic<int>("HMS_SDK_VERSION_CODE");
        public static string HMSSDKVERSIONNAME => sJavaClass.GetStatic<string>("HMS_SDK_VERSION_NAME");

    }

}
