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

    }
}
