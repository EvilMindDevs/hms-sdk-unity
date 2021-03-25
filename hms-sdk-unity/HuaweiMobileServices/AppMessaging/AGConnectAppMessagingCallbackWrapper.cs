using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    internal class AGConnectAppMessagingCallbackWrapper : AndroidJavaProxy
    {
        private Action<AppMessage> mOnMessageClick;
        private Action<AppMessage> mOnMessageDisplay;
        private Action<AppMessage> monMessageError;

        public AGConnectAppMessagingCallbackWrapper(Action<AppMessage> onMessageClick, Action<AppMessage> OnMessageDisplay, Action<AppMessage> OnMessageError)
                : base("com.huawei.agconnect.appmessaging.AGConnectAppMessagingCallback")
        {
            mOnMessageClick = onMessageClick;
            mOnMessageDisplay = OnMessageDisplay;
            monMessageError = OnMessageError;
        }
        public void onMessageClick(AndroidJavaObject appMessage)
        {
            mOnMessageClick.Invoke(appMessage.AsWrapper<AppMessage>());
        }
        public void onMessageDisplay(AndroidJavaObject appMessage)
        {
            mOnMessageDisplay.Invoke(appMessage.AsWrapper<AppMessage>());
        }
        public void onMessageError(AndroidJavaObject appMessage)
        {
            monMessageError.Invoke(appMessage.AsWrapper<AppMessage>());
        }
    }
}
 
