using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationAvailability : JavaObjectWrapper
    {
        public LocationAvailability(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationAvailability");

        public LocationAvailability() : base("com.huawei.hms.location.LocationAvailability") { }

        public static LocationAvailability ExtractLocationAvailability(AndroidIntent intent)
            => javaClass.CallStaticAsWrapper<LocationAvailability>("extractLocationAvailability", intent.JavaObject);

        public int GetLocationStatus => Call<int>("getLocationStatus");

        public static bool HasLocationAvailability(AndroidIntent intent) => javaClass.CallStatic<bool>("hasLocationAvailability", intent.JavaObject);

        public bool IsLocationAvailable => Call<bool>("isLocationAvailable");

        public void SetLocationStatus(int locationStatus) => Call("setLocationStatus", locationStatus);

    }
}
