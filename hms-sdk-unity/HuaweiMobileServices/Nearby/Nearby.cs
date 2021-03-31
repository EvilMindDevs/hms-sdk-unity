using UnityEngine;
using System.Collections;
using HuaweiMobileServices.Utils;
using HuaweiMobileServices.Nearby.Message;
using HuaweiMobileServices.Nearby.Discovery;
using HuaweiMobileServices.Nearby.Transfer;
using System;
using HuaweiMobileServices.Nearby.WifiShare;

namespace HuaweiMobileServices.Nearby
{
    // Wrapper for com.huawei.hms.nearby.Nearby
    public static class Nearby  
    {

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.Nearby");
        public static DiscoveryEngine DiscoveryEngine => androidJavaClass.CallStaticAsWrapper<DiscoveryEngine>("getDiscoveryEngine", AndroidContext.ApplicationContext);
        public static TransferEngine TransferEngine => androidJavaClass.CallStaticAsWrapper<TransferEngine>("getTransferEngine", AndroidContext.ApplicationContext);
        public static MessageEngine MessageEngine => androidJavaClass.CallStaticAsWrapper<MessageEngine>("getMessageEngine", AndroidContext.ActivityContext);
        public static MessageEngine MessageEngineWithOption(MessageOption messageOption) => androidJavaClass.CallStaticAsWrapper<MessageEngine>("getMessageEngine", AndroidContext.ApplicationContext, messageOption);
        public static String Version => androidJavaClass.CallStatic<String>("getVersion");
        public static WifiShareEngine WifiShareEngine => androidJavaClass.CallStaticAsWrapper<WifiShareEngine>("getWifiShareEngine", AndroidContext.ApplicationContext);
 
    }
}
