
namespace HuaweiMobileServices.AppMessaging
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;
    internal class AGConnectAppMessagingOnDisplayListenerWrapper : AndroidJavaProxy
    {
        private Action<AppMessage> mListener;

        public AGConnectAppMessagingOnDisplayListenerWrapper(Action<AppMessage> listener) : base("com.huawei.agconnect.appmessaging.AGConnectAppMessagingOnDisplayListener")
        {
            mListener = listener;
        }
        public void onMessageDisplay(AndroidJavaObject appMessage)
        {
            mListener.Invoke(appMessage.AsWrapper<AppMessage>());
        }
    }
}