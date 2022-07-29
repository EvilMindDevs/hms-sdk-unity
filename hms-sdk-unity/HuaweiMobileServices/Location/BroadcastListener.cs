using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class BroadcastListener : JavaObjectWrapper
    {
        public BroadcastListener(Action<AndroidIntent> intent)
         : base("org.m0skit0.android.hms.unity.location.BroadcastWrapper", new BroadcastListenerInterfaceWrapper(intent)) { }

        private class BroadcastListenerInterfaceWrapper : AndroidJavaProxy
        {
            private readonly Action<AndroidIntent> m_Intent;

            public BroadcastListenerInterfaceWrapper(Action<AndroidIntent> intent) :
                base("org.m0skit0.android.hms.unity.location.BroadcastListener")
            {
                m_Intent = intent;
            }
            public void onReceive(AndroidJavaObject intent)
            {
                m_Intent?.Invoke(intent.AsWrapper<AndroidIntent>());
            }
        }

    }
}
