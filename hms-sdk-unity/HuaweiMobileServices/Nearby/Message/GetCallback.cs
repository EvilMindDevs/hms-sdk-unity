using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class GetCallback : AndroidJavaProxy
    {
        private Action OnTimeout;
        public GetCallback(Action onTimeout) : base("com.huawei.hms.nearby.message.GetCallback")
        {
            OnTimeout = onTimeout;
        }
        public void onTimeout()
        {
            OnTimeout.Invoke();
        }
    }
}
