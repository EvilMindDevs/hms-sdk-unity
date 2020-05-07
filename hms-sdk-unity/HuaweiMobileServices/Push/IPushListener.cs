using System;

namespace HuaweiMobileServices.Push
{
    public interface IPushListener
    {
        void OnNewToken(string token);
        void OnTokenError(Exception e);
        void OnMessageReceived(RemoteMessage remoteMessage);
    }
}
