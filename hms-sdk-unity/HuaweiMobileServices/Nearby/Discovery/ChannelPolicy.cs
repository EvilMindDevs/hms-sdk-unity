using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ChannelPolicy : JavaObjectWrapper
    {
        
        public ChannelPolicy(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.ChannelPolicy");
        public static ChannelPolicy CHANNEL_AUTO => androidJavaClass.GetStaticAsWrapper<ChannelPolicy>("CHANNEL_AUTO");
        public static ChannelPolicy CHANNEL_HIGH_THROUGHPUT => androidJavaClass.GetStaticAsWrapper<ChannelPolicy>("CHANNEL_HIGH_THROUGHPUT");
        public static ChannelPolicy CHANNEL_INSTANCE => androidJavaClass.GetStaticAsWrapper<ChannelPolicy>("CHANNEL_INSTANCE");
    }
}
