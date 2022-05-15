namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.HwAds
    public static class HwAds
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.HwAds");

        public static RequestOptions RequestOptions
        {
            get => sJavaClass.CallStaticAsWrapper<RequestOptions>("getRequestOptions");
            set => sJavaClass.CallStatic("setRequestOptions", value.JavaObject);
        }

        public static void Init() => sJavaClass.CallStatic("init", AndroidContext.ActivityContext);

        public static void Init(string appCode) => sJavaClass.CallStatic("init", AndroidContext.ActivityContext, appCode);

        public static string SDKVersion { get => sJavaClass.CallStatic<string>("getSDKVersion"); }

        public static void SetConsent(string param1String) => sJavaClass.CallStatic("setConsent", param1String);

        public static int AppActivateStyle
        {
            get => sJavaClass.GetStatic<int>("getAppActivateStyle");   // get method
            set => sJavaClass.CallStatic("setAppActivateStyle", value);  // set method
        }

        public static bool AppInstalledNotify
        {
            get => sJavaClass.GetStatic<bool>("isAppInstalledNotify");   // get method
            set => sJavaClass.CallStatic("setAppInstalledNotify", value);  // set method
        }
    }

    // Wrapper for Constant-class => com.huawei.hms.ads.ActivateStyle
    public class ActivateStyle
    {
        public static int BOTTOM_BANNER = 1;
        public static int CONFIRM_DIALOG = 2;
    }
}
