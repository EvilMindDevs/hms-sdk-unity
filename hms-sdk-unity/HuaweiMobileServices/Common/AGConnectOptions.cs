using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Common
{
    public class AGConnectOptions : JavaObjectWrapper
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.AGConnectOptions");

        public AGConnectOptions(AndroidJavaObject javaObject) : base(javaObject) { }

        public AGCRoutePolicy GetRoutePolicy() => CallAsWrapper<AGCRoutePolicy>("getRoutePolicy");
        public string GetPackageName() => Call<string>("getPackageName");
        public string GetString(string path) => Call<string>("getString",path.AsJavaString());
        public string GetString(string path, string def) => Call<string>("getString", path.AsJavaString(), def.AsJavaString());

        public string getType => Call<AndroidJavaObject>("getRoutePolicy").Call<AndroidJavaObject>("getClass").Call<AndroidJavaObject>("getName").Call<string>("toString");

    }
}