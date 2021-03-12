using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{

    public class ScanEndpointCallback : JavaObjectWrapper
    {
        private class ScanEndpointCallbackInterface : AndroidJavaProxy
        {

            private readonly IScanEndpointCallback mListener;

            public ScanEndpointCallbackInterface(IScanEndpointCallback listener) : base("org.m0skit0.android.hms.unity.nearby.ScanEndpointListener")
            {
                mListener = listener;
            }

            public void OnFound(string p0, AndroidJavaObject p1)
            {
                mListener.onFound(p0, p1);
            }

            public void OnLost(string p0)
            {
                mListener.onLost(p0);
            } 

        } 
        public ScanEndpointCallback(IScanEndpointCallback listener)
            : base("org.m0skit0.android.hms.unity.nearby.ScanEndpointWrapper", new ScanEndpointCallbackInterface(listener)) { }

    }
}
