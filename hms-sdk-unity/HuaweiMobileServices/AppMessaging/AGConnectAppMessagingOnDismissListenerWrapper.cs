namespace HuaweiMobileServices.AppMessaging
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;
    internal class AGConnectAppMessagingOnDismissListenerWrapper : AndroidJavaProxy
    {
        private Action<AppMessage, AGConnectAppMessagingCallbackWrapper.DismissType> mListener;

        public AGConnectAppMessagingOnDismissListenerWrapper(Action<AppMessage, AGConnectAppMessagingCallbackWrapper.DismissType> listener) : base("com.huawei.agconnect.appmessaging.AGConnectAppMessagingOnDismissListener")
        {
            mListener = listener;
        }
        public void onMessageDismiss(AndroidJavaObject appMessage, AGConnectAppMessagingCallbackWrapper.DismissType dismissType)
        {
            mListener.Invoke(appMessage.AsWrapper<AppMessage>(), dismissType);
        }
    }
}