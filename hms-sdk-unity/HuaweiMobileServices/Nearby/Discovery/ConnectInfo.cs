using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ConnectInfo : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public ConnectInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.ConnectInfo");
        public String AuthCode => androidJavaClass.Call<String>("getAuthCode");
        public String EndpointName => androidJavaClass.Call<String>("getEndpointName");
        public bool IsRemoteConnect => androidJavaClass.Call<bool>("isRemoteConnect");

    }
}