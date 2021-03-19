namespace HuaweiMobileServices.AppMessaging
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;
    internal class AGConnectAppMessagingOnDismissListenerWrapper : AndroidJavaProxy
    {
        private Action<AppMessage> mListener;

        public AGConnectAppMessagingOnDismissListenerWrapper(Action<AppMessage> listener) : base("com.huawei.agconnect.appmessaging.AGConnectAppMessagingOnDismissListener")
        {
            mListener = listener;
        }
        public void onMessageDismiss(AndroidJavaObject appMessage, AGConnectAppMessagingCallbackWrapper.DismissType dismissType)
        {
            Debug.Log("AppMessaging onMessageClick");
            mListener.Invoke(appMessage.AsWrapper<AppMessage>());
        }
    }
}