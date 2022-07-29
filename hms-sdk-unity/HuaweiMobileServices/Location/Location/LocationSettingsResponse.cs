using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationSettingsResponse : JavaObjectWrapper
    {
        public LocationSettingsResponse(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationSettingsResponse");

        public LocationSettingsResponse(LocationSettingsResult locationSettingsResultt)
        : base("com.huawei.hms.location.LocationSettingsResponse", locationSettingsResultt) { }

        public LocationSettingsStates GetLocationSettingsStates()
         => CallAsWrapper<LocationSettingsStates>("getLocationSettingsStates");
    }
}
