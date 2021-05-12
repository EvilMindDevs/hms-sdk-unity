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

        public void onNewToken(string token, Bundle bundle)
        {
            mListener?.OnNewToken(token, bundle);
        }

        public void onTokenError(AndroidJavaObject e)
        {
            mListener?.OnTokenError(e.AsException());
        }

        public void onMessageReceived(AndroidJavaObject remoteMessage)
        {
            mListener?.OnMessageReceived(remoteMessage.AsWrapper<RemoteMessage>());
        }

        public void onTokenError(AndroidJavaObject exception, Bundle bundle)
        {
            mListener?.OnTokenError(exception.AsException(), bundle);
        }

        public void onMessageSent(string msgId)
        {
            mListener?.OnMessageSent(msgId);
        }

        public void onMessageDelivered(string msgId, AndroidJavaObject exception)
        {
            mListener?.OnMessageDelivered(msgId, exception.AsException());
        }

        public void onSendError(string msgId, AndroidJavaObject exception)
        {
            mListener?.OnSendError(msgId, exception.AsException());
        }
    }
}
