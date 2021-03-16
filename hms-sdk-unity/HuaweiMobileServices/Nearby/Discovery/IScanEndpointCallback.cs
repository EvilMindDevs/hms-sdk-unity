using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public interface IScanEndpointCallback
    {
        void onFound(String endpointId, ScanEndpointInfo info);
        void onLost(String endpointId);
  
    }
}
