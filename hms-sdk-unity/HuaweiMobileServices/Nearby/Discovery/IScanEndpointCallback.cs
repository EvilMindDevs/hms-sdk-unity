using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public interface IScanEndpointCallback
    {
        void onFound(String endpointId, AndroidJavaObject info);
        void onLost(String endpointId);
  
    }
}
