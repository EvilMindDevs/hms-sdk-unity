namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.ads.identifier.AdvertisingIdClient
    public class AdvertisingIdClient 
    {
        private const string CLASS_NAME = "com.huawei.hms.ads.identifier.AdvertisingIdClient";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public static bool VerifyAdId(string adId, bool isLimitAdTracking) => sJavaClass.CallStatic<bool>("verifyAdId", AndroidContext.ActivityContext, adId, isLimitAdTracking);
        
        public static Info AdVertisingIdInfo => sJavaClass.CallStaticAsWrapper<Info>("getAdvertisingIdInfo", AndroidContext.ActivityContext);
        
        // Wrapper for com.huawei.hms.ads.identifier.AdvertisingIdClient.Info
        public class Info : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Info(AndroidJavaObject javaObject) : base(javaObject) { }

            public string Id => CallAsString("getId");

            public bool LimitAdTrackingEnabled => Call<bool>("isLimitAdTrackingEnabled");

        }
    }
}
