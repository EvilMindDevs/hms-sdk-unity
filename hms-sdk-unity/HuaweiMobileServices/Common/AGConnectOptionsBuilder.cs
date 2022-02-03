using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Common
{
    public class AGConnectOptionsBuilder : JavaObjectWrapper
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.AGConnectOptionsBuilder");

        public AGConnectOptionsBuilder(AndroidJavaObject javaObject) : base(javaObject) { }

        public AGConnectOptionsBuilder SetProductId(string productId) => CallAsWrapper<AGConnectOptionsBuilder>("setProductId", productId.AsJavaString());
        public AGConnectOptionsBuilder SetAppId(string appId) => CallAsWrapper<AGConnectOptionsBuilder>("setAppId", appId.AsJavaString());
        public AGConnectOptionsBuilder SetCPId(string cpId) => CallAsWrapper<AGConnectOptionsBuilder>("setCPId", cpId.AsJavaString());
        public AGConnectOptionsBuilder SetClientSecret(string clientSecret) => CallAsWrapper<AGConnectOptionsBuilder>("setClientSecret", clientSecret.AsJavaString());
        public AGConnectOptionsBuilder SetClientId(string clientId) => CallAsWrapper<AGConnectOptionsBuilder>("setClientId", clientId.AsJavaString());
        public AGConnectOptionsBuilder SetApiKey(string apiKey) => CallAsWrapper<AGConnectOptionsBuilder>("setApiKey", apiKey.AsJavaString());
        public AGConnectOptionsBuilder SetCustomValue(string key, string value) => CallAsWrapper<AGConnectOptionsBuilder>("setCustomValue", key.AsJavaString(), value.AsJavaString());
        public AGConnectOptionsBuilder SetRoutePolicy(AGCRoutePolicy routePolicy) => CallAsWrapper<AGConnectOptionsBuilder>("setRoutePolicy", routePolicy);
        public AGConnectOptionsBuilder SetPackageName(string packageName) => CallAsWrapper<AGConnectOptionsBuilder>("setPackageName", packageName.AsJavaString());
        public AGConnectOptionsBuilder SetInputStream(AndroidJavaObject inputStream) => CallAsWrapper<AGConnectOptionsBuilder>("setInputStream", inputStream);
        public AGConnectOptions Build() => CallAsWrapper<AGConnectOptions>("build", AndroidContext.ActivityContext);

    }
}
