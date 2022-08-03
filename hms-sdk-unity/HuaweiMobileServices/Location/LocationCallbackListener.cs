using HuaweiMobileServices.Location.Location;
using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class LocationCallbackListener : JavaObjectWrapper
    {
        private class LocationCallbackListenerInterfaceWrapper : AndroidJavaProxy
        {
            private readonly Action<LocationResult> m_OnLocationResult;
            private readonly Action<LocationAvailability> m_OnLocationAvailability;

            public LocationCallbackListenerInterfaceWrapper(Action<LocationResult> onLocationResult, Action<LocationAvailability> onLocationAvailability) :
                base("org.m0skit0.android.hms.unity.location.LocationCallbackListener")
            {
                m_OnLocationResult = onLocationResult;
                m_OnLocationAvailability = onLocationAvailability;
            }
            public void onLocationResult(AndroidJavaObject locationResult)
            {
                m_OnLocationResult?.Invoke(locationResult.AsWrapper<LocationResult>());
            }
            public void onLocationAvailability(AndroidJavaObject locationAvailability)
            {
                m_OnLocationAvailability?.Invoke(locationAvailability.AsWrapper<LocationAvailability>());
            }
        }
        public LocationCallbackListener(Action<LocationResult> onLocationResult, Action<LocationAvailability> onLocationAvailability)
          : base("org.m0skit0.android.hms.unity.location.LocationCallbackWrapper", new LocationCallbackListenerInterfaceWrapper(onLocationResult, onLocationAvailability)) { }
    }
}


