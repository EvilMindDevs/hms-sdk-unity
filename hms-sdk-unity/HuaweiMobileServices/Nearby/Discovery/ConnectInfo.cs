using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    //com.huawei.hms.nearby.discovery.ConnectInfo 
    public class ConnectInfo : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public ConnectInfo(AndroidJavaObject javaObject) : base(javaObject) { }
        public String AuthCode => Call<String>("getAuthCode");
        public String EndpointName => Call<String>("getEndpointName");
        public bool IsRemoteConnect => Call<bool>("isRemoteConnect");

    }
}
