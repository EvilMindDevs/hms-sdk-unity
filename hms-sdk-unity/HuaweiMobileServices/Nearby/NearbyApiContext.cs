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
                AndroidJavaObject analyticsClassObject = androidJavaClass.CallStatic<AndroidJavaObject>("getInstance");
                nearbyApiContextInstance = new NearbyApiContext(analyticsClassObject);
            }
            return nearbyApiContextInstance;
        }
        public void SetApiKey(String apiKey) => androidJavaClass.Call("setApiKey", apiKey);
        public String GetApiKey => androidJavaClass.Call<String>("getApiKey");

    }
}
