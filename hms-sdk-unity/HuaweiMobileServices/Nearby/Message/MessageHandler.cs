using HuaweiMobileServices.Nearby.Discovery;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class MessageHandler : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public MessageHandler(AndroidJavaObject javaObject) : base(javaObject) { }
        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.MessageHandler");
        public void OnBleSignalChanged(Message message, BleSignal bleSignal) => androidJavaClass.Call("onBleSignalChanged", message, bleSignal);
        public void OnDistanceChanged(Message message, Distance distance) => androidJavaClass.Call("onDistanceChanged", message, distance);
        public void OnFound(Message message) => androidJavaClass.Call("onFound", message);
        public void OnLost(Message message) => androidJavaClass.Call("onLost", message);
    }
}
