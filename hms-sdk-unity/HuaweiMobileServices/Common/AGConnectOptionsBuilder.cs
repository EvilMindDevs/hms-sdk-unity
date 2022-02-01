using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Common
{
    public class AGConnectOptionsBuilder : JavaObjectWrapper
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.AGConnectOptionsBuilder");

        public AGConnectOptionsBuilder(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AGConnectOptionsBuilder SetProductId(string productId) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setProductId", productId.AsJavaString());
        public static AGConnectOptionsBuilder SetAppId(string appId) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setAppId", appId.AsJavaString());
        public static AGConnectOptionsBuilder SetCPId(string cpId) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setCPId", cpId.AsJavaString());
        public static AGConnectOptionsBuilder SetClientSecret(string clientSecret) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setClientSecret", clientSecret.AsJavaString());
        public static AGConnectOptionsBuilder SetClientId(string clientId) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setClientId", clientId.AsJavaString());
        public static AGConnectOptionsBuilder SetApiKey(string apiKey) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setApiKey", apiKey.AsJavaString());
        public static AGConnectOptionsBuilder SetCustomValue(string key, string value) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setCustomValue", key.AsJavaString(), value.AsJavaString());
        public static AGConnectOptionsBuilder SetRoutePolicy(AGCRoutePolicy routePolicy) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setRoutePolicy", routePolicy);
        public static AGConnectOptionsBuilder SetPackageName(string packageName) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setPackageName", packageName.AsJavaString());
        public static AGConnectOptionsBuilder SetInputStream(AndroidJavaObject inputStream) => javaClass.CallStaticAsWrapper<AGConnectOptionsBuilder>("setInputStream", inputStream);
        public static AGConnectOptions Build() => javaClass.CallStaticAsWrapper<AGConnectOptions>("build", AndroidContext.ActivityContext);

    }
}
