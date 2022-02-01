using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Common
{
    public class AGConnectOptions : JavaObjectWrapper
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.AGConnectOptions");

        public AGConnectOptions(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AGCRoutePolicy GetRoutePolicy() => javaClass.Call<AGCRoutePolicy>("getRoutePolicy");
        public static string GetPackageName() => javaClass.Call<string>("getPackageName");
        public static string GetString(string path) => javaClass.Call<string>("getString",path.AsJavaString());
        public static string GetString(string path, string def) => javaClass.Call<string>("getString", path.AsJavaString(), def.AsJavaString());

    }
}