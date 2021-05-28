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
            this.CallOnMainThread(() => { mListener?.OnNewToken(token); });
        }

        public void onNewToken(string token, Bundle bundle)
        {
            this.CallOnMainThread(() => { mListener?.OnNewToken(token, bundle); });
        }

        public void onTokenError(AndroidJavaObject e)
        {
            this.CallOnMainThread(() => { mListener?.OnTokenError(e.AsException()); });
        }

        public void onMessageReceived(AndroidJavaObject remoteMessage)
        {
            this.CallOnMainThread(() => { mListener?.OnMessageReceived(remoteMessage.AsWrapper<RemoteMessage>()); });
        }

        public void onTokenError(AndroidJavaObject exception, Bundle bundle)
        {
            this.CallOnMainThread(() => { mListener?.OnTokenError(exception.AsException(), bundle); });
        }

        public void onMessageSent(string msgId)
        {
            this.CallOnMainThread(() => { mListener?.OnMessageSent(msgId); });
        }

        public void onMessageDelivered(string msgId, AndroidJavaObject exception)
        {
            this.CallOnMainThread(() => { mListener?.OnMessageDelivered(msgId, exception.AsException()); });
        }

        public void onSendError(string msgId, AndroidJavaObject exception)
        {
            this.CallOnMainThread(() => { mListener?.OnSendError(msgId, exception.AsException()); });
        }
    }
}
