using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class LocationBroadcastListener : JavaObjectWrapper
    {
        public LocationBroadcastListener(Action<AndroidIntent> intent)
         : base("org.m0skit0.android.hms.unity.location.LocationBroadcastWrapper", new LocationBroadcastListenerInterfaceWrapper(intent)) { }

        private class LocationBroadcastListenerInterfaceWrapper : AndroidJavaProxy
        {
            private readonly Action<AndroidIntent> m_Intent;

            public LocationBroadcastListenerInterfaceWrapper(Action<AndroidIntent> intent) :
                base("org.m0skit0.android.hms.unity.location.LocationBroadcastListener")
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
