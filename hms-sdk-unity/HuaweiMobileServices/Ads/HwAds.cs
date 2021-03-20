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
    }
}
