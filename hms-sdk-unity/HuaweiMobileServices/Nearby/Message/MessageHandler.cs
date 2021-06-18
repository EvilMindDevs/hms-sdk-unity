using HuaweiMobileServices.Nearby.Discovery;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class MessageHandler : AndroidJavaProxy
    {
        private IMessageHandler IMessageHandler;

        public MessageHandler(IMessageHandler messageHandler) : base("com.huawei.hms.nearby.message.MessageHandler")
        {
            IMessageHandler = messageHandler;
        }

        public void onBleSignalChanged(AndroidJavaObject message, AndroidJavaObject bleSignal)
        {
            this.CallOnMainThread(() => { IMessageHandler.OnBleSignalChanged(message.AsWrapper<Message>(), bleSignal.AsWrapper<BleSignal>()); });
        }

        public void onDistanceChanged(AndroidJavaObject message, AndroidJavaObject bleSignal)
        {
            this.CallOnMainThread(() => { IMessageHandler.OnDistanceChanged(message.AsWrapper<Message>(), bleSignal.AsWrapper<BleSignal>()); });
        }

        public void onFound(AndroidJavaObject message)
        {
            this.CallOnMainThread(() => { IMessageHandler.OnFound(message.AsWrapper<Message>()); });
        }

        public void onLost(AndroidJavaObject message)
        {
            this.CallOnMainThread(() => { IMessageHandler.OnLost(message.AsWrapper<Message>()); });
        }
    }
}
