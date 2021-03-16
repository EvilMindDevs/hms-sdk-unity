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
        public static DiscoveryEngine GetDiscoveryEngine(AndroidJavaObject activity) => androidJavaClass.CallStaticAsWrapper<DiscoveryEngine>("getDiscoveryEngine", activity);
        public static TransferEngine GetTransferEngine(AndroidJavaObject activity) => androidJavaClass.CallStaticAsWrapper<TransferEngine>("getTransferEngine", activity);
        public static MessageEngine GetMessageEngine(AndroidJavaObject context) => androidJavaClass.CallStaticAsWrapper<MessageEngine>("getMessageEngine", context);
        public static MessageEngine GetMessageEngine(AndroidJavaObject context, MessageOption messageOption) => androidJavaClass.CallStaticAsWrapper<MessageEngine>("getMessageEngine", context,messageOption);
        public static String Version => androidJavaClass.CallStatic<String>("getVersion");
        public static WifiShareEngine GetWifiShareEngine(AndroidJavaObject context) => androidJavaClass.CallStaticAsWrapper<WifiShareEngine>("getWifiShareEngine", context);
 
    }
}
