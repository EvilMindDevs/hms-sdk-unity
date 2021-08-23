using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ConnectOption : JavaObjectWrapper
    {
        public ConnectOption(AndroidJavaObject javaObject) : base(javaObject) { }
        public ChannelPolicy Policy => CallAsWrapper<ChannelPolicy>("getPolicy");
        public class Builder : JavaObjectWrapper
        {

            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.discovery.ConnectOption$Builder") { }
            public ConnectOption Build() => CallAsWrapper<ConnectOption>("build");
            public Builder SetPolicy(ChannelPolicy policy) => CallAsWrapper<Builder>("setPolicy", policy);
        }
    }
}
