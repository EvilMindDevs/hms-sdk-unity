using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ConnectOption : JavaObjectWrapper
    {
        public ConnectOption(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.ChannelPolicy");
        public static ConnectOption CHANNEL_AUTO => androidJavaClass.GetStaticAsWrapper<ConnectOption>("CHANNEL_AUTO");
        public static ConnectOption CHANNEL_HIGH_THROUGHPUT => androidJavaClass.GetStaticAsWrapper<ConnectOption>("CHANNEL_HIGH_THROUGHPUT");
        public static ConnectOption CHANNEL_INSTANCE => androidJavaClass.GetStaticAsWrapper<ConnectOption>("CHANNEL_INSTANCE");
    }
}
