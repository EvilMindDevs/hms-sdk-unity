using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Push
{
    public interface IPushListener
    {
        void OnNewToken(string token);
        void OnTokenError(Exception e);
        void OnMessageReceived(RemoteMessage remoteMessage);
    }
}
