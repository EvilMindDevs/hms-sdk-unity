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
    public class Nearby  
    {
        [UnityEngine.Scripting.Preserve]
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.Nearby");
        public static DiscoveryEngine GetDiscoveryEngine() => androidJavaClass.CallStaticAsWrapper<DiscoveryEngine>("getDiscoveryEngine", AndroidContext.ApplicationContext);
        public static TransferEngine GetTransferEngine() => androidJavaClass.CallStaticAsWrapper<TransferEngine>("getTransferEngine", AndroidContext.ApplicationContext);
        public static MessageEngine GetMessageEngine() => androidJavaClass.CallStaticAsWrapper<MessageEngine>("getMessageEngine", AndroidContext.ActivityContext);
        public static MessageEngine GetMessageEngine(MessageOption messageOption) => androidJavaClass.CallStaticAsWrapper<MessageEngine>("getMessageEngine", AndroidContext.ApplicationContext, messageOption);
        public static String Version => androidJavaClass.CallStatic<String>("getVersion");
        public static WifiShareEngine GetWifiShareEngine() => androidJavaClass.CallStaticAsWrapper<WifiShareEngine>("getWifiShareEngine", AndroidContext.ApplicationContext);
 
    }
}
