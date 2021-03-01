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
    public class Nearby : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Nearby(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.Nearby");

        public static DiscoveryEngine GetDiscoveryEngine(AndroidJavaObject activity)
        {
            AndroidJavaObject androidJavaObject = androidJavaClass.CallStatic<AndroidJavaObject>("getDiscoveryEngine", activity);
            return new DiscoveryEngine(androidJavaObject);   
        }
        public static TransferEngine GetTransferEngine(AndroidJavaObject activity) => androidJavaClass.CallStatic<TransferEngine>("getTransferEngine", activity);
        public static MessageEngine GetMessageEngine(AndroidJavaObject context) => androidJavaClass.CallStatic<MessageEngine>("getMessageEngine", context);
        public static MessageEngine GetMessageEngine(AndroidJavaObject context, MessageOption messageOption)
                            => androidJavaClass.CallStatic<MessageEngine>("getMessageEngine", context, messageOption);
        public static String Version => androidJavaClass.CallStatic<String>("getVersion");
        public static WifiShareEngine GetWifiShareEngine(AndroidJavaObject context) =>
                    androidJavaClass.CallStatic<WifiShareEngine>("getWifiShareEngine", context);


    }
}