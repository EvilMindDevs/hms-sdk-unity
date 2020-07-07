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

        public bool verifyAdId(string adId, bool isLimitAdTracking) => Call<bool>("verifyAdId", adId, isLimitAdTracking);
   
        public static Info AdVertisingIdInfo() => new Info();
      
        // Wrapper for com.huawei.hms.ads.identifier.AdvertisingIdClient.Info
        public class Info : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Info(AndroidJavaObject javaObject) : base(javaObject) { }

            public Info() : base("com.huawei.hms.ads.identifier.AdvertisingIdClient$Info") { }

            public string Id => CallAsString("getId");
           
            public bool LimitAdTrackingEnabled => Call<bool>("isLimitAdTrackingEnabled");

        }
    }

}
