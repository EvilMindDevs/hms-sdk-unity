using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
    public class PutCallback : AndroidJavaProxy
    {
        private Action OnTimeout;

        public PutCallback(Action onTimeout) : base("com.huawei.hms.nearby.message.PutCallback")
        {
            OnTimeout = onTimeout;
        }

        public void onTimeout()
        {
            this.CallOnMainThread(() => { OnTimeout.Invoke(); });
        }
    }
}
