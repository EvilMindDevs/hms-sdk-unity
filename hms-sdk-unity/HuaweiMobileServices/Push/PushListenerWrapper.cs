using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Push
{
    using UnityEngine;
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;

    internal class PushListenerWrapper : AndroidJavaProxy
    {

        private readonly IPushListener mListener;

        public PushListenerWrapper(IPushListener listener) : base("org.m0skit0.android.hms.unity.push.PushListener")
        {
            mListener = listener;
        }

        public void onNewToken(string token)
        {
            mListener?.OnNewToken(token);
        }

        public void onTokenError(AndroidJavaObject e)
        {
            mListener?.OnTokenError(e.AsHMSException());
        }

        public void onMessageReceived(AndroidJavaObject remoteMessage)
        {
            mListener?.OnMessageReceived(remoteMessage.AsWrapper<RemoteMessage>());
        }
    }
}
