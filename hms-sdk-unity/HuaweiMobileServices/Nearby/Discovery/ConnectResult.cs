namespace HuaweiMobileServices.Nearby.Discovery
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    public class ConnectResult : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public ConnectResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.ConnectResult");
        public Status GetStatus() => androidJavaClass.Call<Status>("getStatus");
        public void WriteToParce(Parcel dest, int flags) => androidJavaClass.Call("writeToParcel", dest, flags);
        public int DescribeContents() => androidJavaClass.Call<int>("describeContents");


    }
}