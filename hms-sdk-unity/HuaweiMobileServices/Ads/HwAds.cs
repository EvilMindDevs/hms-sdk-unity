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

        public static int GetAppActivateStyle() => sJavaClass.CallStatic<int>("getAppActivateStyle");

        public static void SetAppActivateStyle(int value) => sJavaClass.CallStatic("setAppActivateStyle", value);

        public static bool IsAppInstalledNotify() => sJavaClass.CallStatic<bool>("isAppInstalledNotify");

        public static void SetAppInstalledNotify(bool value) => sJavaClass.CallStatic("setAppInstalledNotify", value);

    }

    // Wrapper for Constant-class => com.huawei.hms.ads.ActivateStyle
    public class ActivateStyle
    {
        public static int BOTTOM_BANNER = 1;
        public static int CONFIRM_DIALOG = 2;
    }
}
