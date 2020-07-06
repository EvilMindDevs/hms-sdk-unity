using System;

namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.ads.identifier.AdvertisingIdClient
    public class AdvertisingIdClient : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AdvertisingIdClient(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool verifyAdId(String adId, bool isLimitAdTrackin)
        {
            return Call<bool>("verifyAdId", adId, isLimitAdTrackin);
        }

        [UnityEngine.Scripting.Preserve]
        public static Info AdVertisingIdInfo() => new Info();
      


        // Wrapper for com.huawei.hms.ads.identifier.AdvertisingIdClient.Info
        [UnityEngine.Scripting.Preserve]
        public class Info : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Info(AndroidJavaObject javaObject) : base(javaObject) { }

            [UnityEngine.Scripting.Preserve]
            public Info() : base("com.huawei.hms.ads.identifier.AdvertisingIdClient$Info") { }

            [UnityEngine.Scripting.Preserve]
            public String Id() => CallAsString("getId");
            
            [UnityEngine.Scripting.Preserve]
            public bool LimitAdTrackingEnabled() => Call<bool>("isLimitAdTrackingEnabled");

        }
    }

    
}
