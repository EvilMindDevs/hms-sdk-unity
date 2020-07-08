using System;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.ads.identifier.AdvertisingIdClient
    public class AdvertisingIdClient : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public static AdvertisingIdClient NewInstance(AndroidJavaObject javaObject) => new AdvertisingIdClient(javaObject);

        public AdvertisingIdClient(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool verifyAdId(String adId, bool isLimitAdTrackin)
        {
            return Call<bool>("verifyAdId", adId, isLimitAdTrackin);
        }

        public static Info AdVertisingIdInfo() => new Info();

        // Wrapper for com.huawei.hms.ads.identifier.AdvertisingIdClient.Info       
        public class Info : JavaObjectWrapper
        {

            [UnityEngine.Scripting.Preserve]
            public static Info NewInstance(AndroidJavaObject javaObject) => new Info(javaObject);

            public Info(AndroidJavaObject javaObject) : base(javaObject) { }

            public Info() : base("com.huawei.hms.ads.identifier.AdvertisingIdClient$Info") { }

            public String Id() => CallAsString("getId");

            public bool LimitAdTrackingEnabled() => Call<bool>("isLimitAdTrackingEnabled");

        }
    }

}
