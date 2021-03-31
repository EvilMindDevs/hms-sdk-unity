
namespace HuaweiMobileServices.AppMessaging
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;
    internal class AGConnectAppMessagingOnClickListenerWrapper : AndroidJavaProxy
    {
        private Action<AppMessage> mListener;

        public AGConnectAppMessagingOnClickListenerWrapper(Action<AppMessage> listener) : base("com.huawei.agconnect.appmessaging.AGConnectAppMessagingOnClickListener")
        {
            mListener = listener;
        }
        public void onMessageClick(AndroidJavaObject appMessage)
        {
            mListener.Invoke(appMessage.AsWrapper<AppMessage>());
        }
    }
}