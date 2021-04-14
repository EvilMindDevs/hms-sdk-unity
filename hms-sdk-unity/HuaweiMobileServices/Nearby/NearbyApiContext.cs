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
        
        public NearbyApiContext(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.NearbyApiContext");
        public static NearbyApiContext Instance => androidJavaClass.CallStaticAsWrapper<NearbyApiContext>("getInstance");

        public string ApiKey
        {
            get => Call<string>("getApiKey");
            set => Call("setApiKey", value);
        }

    }
}
