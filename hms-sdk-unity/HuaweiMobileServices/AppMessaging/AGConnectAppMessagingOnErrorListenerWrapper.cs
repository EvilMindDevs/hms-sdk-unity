using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
namespace HuaweiMobileServices.AppMessaging
{
    internal class AGConnectAppMessagingOnErrorListenerWrapper : AndroidJavaProxy
    { 
        private Action<AppMessage> mListener;

        public AGConnectAppMessagingOnErrorListenerWrapper(Action<AppMessage> listener) : base("com.huawei.agconnect.appmessaging.AGConnectAppMessagingOnErrorListener")
        {
            mListener = listener;
        }
        public void onMessageError(AndroidJavaObject appMessage)
        {
            this.CallOnMainThread(() => { mListener.Invoke(appMessage.AsWrapper<AppMessage>()); });
        }
    }
}
