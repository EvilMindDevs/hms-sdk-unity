using HuaweiMobileServices.Nearby.Discovery;
using HuaweiMobileServices.Nearby.Transfer;
using System;
using HuaweiMobileServices.Nearby.WifiShare;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby
{
    public class NearbyApiContext : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public NearbyApiContext(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.NearbyApiContext");
        private static NearbyApiContext nearbyApiContextInstance = null;
        public static NearbyApiContext GetInstance()
        {
            if (nearbyApiContextInstance == null)
            {
                nearbyApiContextInstance = androidJavaClass.CallStaticAsWrapper<NearbyApiContext>("getInstance");
            }
            return nearbyApiContextInstance;
        }
        public void SetApiKey(String apiKey) => Call("setApiKey", apiKey);
        public String GetApiKey => Call<String>("getApiKey");

    }
}
