namespace HuaweiMobileServices.Nearby.Discovery
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;
    //com.huawei.hms.nearby.discovery.ConnectResult
    public class ConnectResult : JavaObjectWrapper
    {
        
        public ConnectResult(AndroidJavaObject javaObject) : base(javaObject) { }
        public Status Status => CallAsWrapper<Status>("getStatus");
    }
}