using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.APM
{
    public class APMS : JavaObjectWrapper
    {
        public APMS(AndroidJavaObject javaObject) : base(javaObject) { }
        public APMS() : base("com.huawei.agconnect.apms.APMS") { }

        public static readonly AndroidJavaClass apms = new AndroidJavaClass("com.huawei.agconnect.apms.APMS");

        public static APMS GetInstance() => apms.CallStaticAsWrapper<APMS>("getInstance");
        public void EnableCollection(bool enable) => Call("enableCollection", enable);
        public void EnableAnrMonitor(bool enable) => Call("enableAnrMonitor", enable);

        public CustomTrace CreateCustomTrace(string traceName) => CallAsWrapper<CustomTrace>("createCustomTrace", traceName);
        public NetworkMeasure CreateNetworkMeasure(string url, string httpMethod) => CallAsWrapper<NetworkMeasure>("createNetworkMeasure", url, httpMethod);
        public void SetUserIdentifier(string userIdentifier) => Call("setUserIdentifier", userIdentifier);

    }
}