using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ScanEndpointInfo : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public ScanEndpointInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.ScanEndpointInfo");
        public String Name => androidJavaClass.Call<String>("getName");
        public String ServiceID => androidJavaClass.Call<String>("getServiceID");
        public void WriteToParce(Parcel dest, int flags) => androidJavaClass.Call("writeToParcel", dest, flags);
        public int DescribeContents() => androidJavaClass.Call<int>("describeContents");

    }
}