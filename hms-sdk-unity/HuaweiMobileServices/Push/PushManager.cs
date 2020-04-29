using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Push
{
    using UnityEngine;

    public static class PushManager
    {

        public static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.push.HMSPushService");

        public static IPushListener Listener
        {
            set
            {
                sJavaClass.CallStatic("setListener", new PushListenerWrapper(value));
            }
        }
    }
}
