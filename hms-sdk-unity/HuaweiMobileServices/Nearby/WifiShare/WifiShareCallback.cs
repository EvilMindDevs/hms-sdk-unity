using HuaweiMobileServices.Nearby.Discovery;
using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.WifiShare
{
    public class WifiShareCallback : JavaObjectWrapper
    {
        private class WifiShareCallbackInterface : AndroidJavaProxy
        {

            private readonly IWifiShareCallback mListener;

            public WifiShareCallbackInterface(IWifiShareCallback listener) : base("org.m0skit0.android.hms.unity.nearby.WifiShareListener")
            {
                mListener = listener;
            }

            public void OnFound(String endpointId, AndroidJavaObject info)
            {
                mListener.onFound(endpointId, info.AsWrapper<ScanEndpointInfo>());
            }

            public void OnLost(String endpointId)
            {
                mListener.onLost(endpointId);
            }
            public void OnFetchAuthCode(String endpointId, String authCode)
            {
                mListener.onFetchAuthCode(endpointId, authCode);
            }
            public void OnWifiShareResult(String endpointId, int statusCode)
            {
                mListener.onWifiShareResult(endpointId, statusCode);
            }

        }
        public WifiShareCallback(IWifiShareCallback listener)
                : base("org.m0skit0.android.hms.unity.nearby.WifiShareListenerWrapper", new WifiShareCallbackInterface(listener)) { }

    }
}
