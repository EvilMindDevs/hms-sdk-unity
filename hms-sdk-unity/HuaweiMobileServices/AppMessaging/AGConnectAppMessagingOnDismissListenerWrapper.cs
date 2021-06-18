namespace HuaweiMobileServices.AppMessaging
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;
    internal class AGConnectAppMessagingOnDismissListenerWrapper : AndroidJavaProxy
    {
        private Action<AppMessage, DismissType> mListener;

        public AGConnectAppMessagingOnDismissListenerWrapper(Action<AppMessage,DismissType> listener) : base("com.huawei.agconnect.appmessaging.AGConnectAppMessagingOnDismissListener")
        {
            mListener = listener;
        }
        public void onMessageDismiss(AndroidJavaObject appMessage, DismissType dismissType)
        {
            this.CallOnMainThread(() => { mListener.Invoke(appMessage.AsWrapper<AppMessage>(), dismissType); });
        }
    }
}