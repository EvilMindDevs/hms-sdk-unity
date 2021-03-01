using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ConnectInfo : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public ConnectInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.ConnectInfo");
        //public static int CREATOR => androidJavaClass.GetStatic<int>("CREATOR");
        public String GetAuthCode() => androidJavaClass.Call<String>("getAuthCode");
        public String GetEndpointName() => androidJavaClass.Call<String>("getEndpointName");
        public bool IsRemoteConnect() => androidJavaClass.Call<bool>("isRemoteConnect");
        public void WriteToParce(Parcel dest, int flags) => androidJavaClass.Call("writeToParcel", dest, flags);
        public int DescribeContents() => androidJavaClass.Call<int>("describeContents");

    }
}