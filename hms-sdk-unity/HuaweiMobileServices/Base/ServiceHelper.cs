namespace HuaweiMobileServices.Base
{
    using System;
    using UnityEngine;

    public static class ServiceHelper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.helper.ServiceHelper");

        public static bool GMSAvailable => sJavaClass.CallStatic<bool>("isGMSAvailable");

        public static bool HMSAvailable => sJavaClass.CallStatic<bool>("isHMSAvailable");

        public static int ServicesVersionCode => sJavaClass.CallStatic<int>("getServicesVersionCode");
        public static void SetServicesVersionCode(int var0) => sJavaClass.CallStatic("setServicesVersionCode",var0);
        public static int IsHuaweiMobileServicesAvailable => sJavaClass.CallStatic<int>("isHuaweiMobileServicesAvailable");
        public static int IsHuaweiMobileServicesAvailableParameter(int var0) => sJavaClass.CallStatic<int>("isHuaweiMobileServicesAvailable",var0);
        public static int IsHuaweiMobileNoticeAvailable(int var1)=> sJavaClass.CallStatic<int>("isHuaweiMobileNoticeAvailable",var1); 
        public static bool IsUserResolvableError(int var0) => sJavaClass.CallStatic<bool>("isUserResolvableError", var0);
        public static void ResolveError(int var0,int var1) => sJavaClass.CallStatic("resolveError", var0,var1);
        public static string ErrorString(int var0) => sJavaClass.CallStatic<string>("getErrorString", var0);
        public static void ShowErrorNotification(int var0) => sJavaClass.CallStatic("showErrorNotification", var0);
        public static string APPIDHMS => sJavaClass.GetStatic<string>("APPIDHMS");
        public static string APPIDHMSTV => sJavaClass.GetStatic<string>("APPIDHMSTV");
        public static int NOTICEVERSIONCODE => sJavaClass.GetStatic<int>("NOTICEVERSIONCODE");
        public static int HMSVERSIONMIN => sJavaClass.GetStatic<int>("HMSVERSIONMIN");
        public static int HMSJSONVERSIONMIN => sJavaClass.GetStatic<int>("HMSJSONVERSIONMIN");
        public static int HMSVERSIONMAX => sJavaClass.GetStatic<int>("HMSVERSIONMAX");
        public static int HMSVERSIONCODEMIN => sJavaClass.GetStatic<int>("HMSVERSIONCODEMIN");
        public static string HMSAPINAMEID => sJavaClass.GetStatic<string>("HMSAPINAMEID");
        public static int HMSVERSIONCODEID => sJavaClass.GetStatic<int>("HMSVERSIONCODEID");
        public static string HMSAPINAMESNS => sJavaClass.GetStatic<string>("HMSAPINAMESNS");
        public static int HMSVERSIONCODESNS => sJavaClass.GetStatic<int>("HMSVERSIONCODESNS");
        public static string HMSAPINAMEPAY => sJavaClass.GetStatic<string>("HMSAPINAMEPAY");
        public static int HMSVERSIONCODEPAY => sJavaClass.GetStatic<int>("HMSVERSIONCODEPAY");
        public static string HMSAPINAMEPUSH => sJavaClass.GetStatic<string>("HMSAPINAMEPUSH");
        public static int HMSVERSIONCODEPUSH => sJavaClass.GetStatic<int>("HMSVERSIONCODEPUSH");
        public static string HMSAPINAMEGAME => sJavaClass.GetStatic<string>("HMSAPINAMEGAME");
        public static int HMSVERSIONCODEGAME => sJavaClass.GetStatic<int>("HMSVERSIONCODEGAME");
        public static string HMSAPINAMEOD => sJavaClass.GetStatic<string>("HMSAPINAMEOD");
        public static int HMSVERSIONCODEOD => sJavaClass.GetStatic<int>("HMSVERSIONCODEOD");
        public static string HMSAPINAMEIAP => sJavaClass.GetStatic<string>("HMSAPINAMEIAP");
        public static int HMSVERSIONCODEIAP => sJavaClass.GetStatic<int>("HMSVERSIONCODEIAP");
        public static string HMSAPINAMEPPS => sJavaClass.GetStatic<string>("HMSAPINAMEPPS");
        public static int HMSVERSIONCODEPPS => sJavaClass.GetStatic<int>("HMSVERSIONCODEPPS");
        public static int SERVICESVERSIONCODE => sJavaClass.GetStatic<int>("SERVICESVERSIONCODE");
        public static int HMSSDKVERSIONCODE => sJavaClass.GetStatic<int>("HMSSDKVERSIONCODE");
        public static string HMSSDKVERSIONNAME => sJavaClass.GetStatic<string>("HMSSDKVERSIONNAME");

    }

}
