using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ScanEndpointInfo : JavaObjectWrapper
    {
        
        public ScanEndpointInfo(AndroidJavaObject javaObject) : base(javaObject) { }
        public String Name => Call<String>("getName");
        public String ServiceID => Call<String>("getServiceID");
    }
}
