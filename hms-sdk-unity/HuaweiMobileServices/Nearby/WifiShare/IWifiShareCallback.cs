using HuaweiMobileServices.Nearby.Discovery;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;


namespace HuaweiMobileServices.Nearby.WifiShare
{
    public interface IWifiShareCallback
    {
        void onFound(String endpointId, ScanEndpointInfo info);
        void onLost(String endpointId);
        void onFetchAuthCode(String endpointId, String authCode);
        void onWifiShareResult(String endpointId, int statusCode);

    }
}
