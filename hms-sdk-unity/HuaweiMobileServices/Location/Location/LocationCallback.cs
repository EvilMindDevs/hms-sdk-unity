using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationCallback : JavaObjectWrapper
    {
        public LocationCallback(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationCallback");

        private class LocationCallbackInterface : AndroidJavaProxy
        {
            private readonly ILocationCallback mListener;

            public LocationCallbackInterface(ILocationCallback listener) : base("org.m0skit0.android.hms.unity.location.LocationCallbackListener")
            {
                mListener = listener;
            }

            public void OnLocationAvailability(LocationAvailability locationAvailability)
            {
                this.CallOnMainThread(() => { mListener.OnLocationAvailability(locationAvailability); });
            }

            public void OnLocationResult(LocationResult locationResult)
            {
                this.CallOnMainThread(() => { mListener.OnLocationResult(locationResult); });
            }



        }
        public LocationCallback(ILocationCallback listener)
       : base("org.m0skit0.android.hms.unity.location.LocationCallbackWrapper", new LocationCallbackInterface(listener)) { }

    }
}
