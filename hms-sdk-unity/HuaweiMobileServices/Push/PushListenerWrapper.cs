namespace HuaweiMobileServices.Push
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

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
            mListener?.OnTokenError(e.AsException());
        }

        public void onMessageReceived(AndroidJavaObject remoteMessage)
        {
            mListener?.OnMessageReceived(remoteMessage.AsWrapper<RemoteMessage>());
        }
    }
}
