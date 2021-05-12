namespace HuaweiMobileServices.Push
{
    using HuaweiMobileServices.Utils;
    using System;

    public interface IPushListener
    {
        void OnNewToken(string token);
        void OnNewToken(string token, Bundle bundle);
        void OnTokenError(Exception e);
        void OnMessageReceived(RemoteMessage remoteMessage);
        void OnTokenError(Exception exception, Bundle bundle);
        void OnMessageSent(String msgId);
        void OnMessageDelivered(String msgId, Exception exception);
        void OnSendError(String msgId, Exception exception);
    }
}
