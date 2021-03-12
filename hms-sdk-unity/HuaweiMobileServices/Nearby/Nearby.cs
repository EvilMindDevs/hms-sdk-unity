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
        public static DiscoveryEngine GetDiscoveryEngine(AndroidJavaObject activity)
        {
            AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getDiscoveryEngine", activity);
            return new DiscoveryEngine(androidJavaObject);   
        }
        public static TransferEngine GetTransferEngine(AndroidJavaObject activity)
        {
            AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getTransferEngine", activity);
            return new TransferEngine(androidJavaObject);
        }
        public static MessageEngine GetMessageEngine(AndroidJavaObject context)
        {
            AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getMessageEngine", context);
            return new MessageEngine(androidJavaObject);
        }
        public static MessageEngine GetMessageEngine(AndroidJavaObject context, MessageOption messageOption)
        {
            AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getMessageEngine", context, messageOption;
            return new MessageEngine(androidJavaObject);
        }
        public static String Version => androidJavaClass.CallStatic<String>("getVersion");
        public static WifiShareEngine GetWifiShareEngine(AndroidJavaObject context)
        {
            AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getWifiShareEngine", context);
            return new WifiShareEngine(androidJavaObject);
        }
    }
}