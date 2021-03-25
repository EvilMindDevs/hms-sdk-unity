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
        public void OnBleSignalChanged(Message message, BleSignal bleSignal) => Call("onBleSignalChanged", message, bleSignal);
        public void OnDistanceChanged(Message message, Distance distance) => Call("onDistanceChanged", message, distance);
        public void OnFound(Message message) => Call("onFound", message);
        public void OnLost(Message message) => Call("onLost", message);
    }
}
