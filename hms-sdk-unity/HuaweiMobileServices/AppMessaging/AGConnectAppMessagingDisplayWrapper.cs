using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    internal class AGConnectAppMessagingDisplayWrapper : AndroidJavaProxy
    {
        private Action<AppMessage> mListener;

        public AGConnectAppMessagingDisplayWrapper(Action<AppMessage> listener) : base("com.huawei.agconnect.appmessaging.AGConnectAppMessagingDisplay")
        {
            mListener = listener;
        }
        public void displayMessage(AndroidJavaObject appMessage, AGConnectAppMessagingCallbackWrapper callback)
        {
            this.CallOnMainThread(() => { mListener.Invoke(appMessage.AsWrapper<AppMessage>()); });
        }
    }
}
