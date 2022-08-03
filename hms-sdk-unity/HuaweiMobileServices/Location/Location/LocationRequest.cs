using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationRequest : JavaObjectWrapper
    {
        public LocationRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        
        public static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationRequest");

        public LocationRequest() : base("com.huawei.hms.location.LocationRequest") { }

        public static int PRIORITY_BALANCED_POWER_ACCURACY => javaClass.GetStatic<int>("PRIORITY_BALANCED_POWER_ACCURACY");
        public static int PRIORITY_HIGH_ACCURACY => javaClass.GetStatic<int>("PRIORITY_HIGH_ACCURACY");
        public static int PRIORITY_LOW_POWER => javaClass.GetStatic<int>("PRIORITY_LOW_POWER");
        public static int PRIORITY_NO_POWER => javaClass.GetStatic<int>("PRIORITY_NO_POWER");
        public static int PRIORITY_INDOOR => javaClass.GetStatic<int>("PRIORITY_INDOOR");

        public static LocationRequest Create() => javaClass.CallStaticAsWrapper<LocationRequest>("create");

        public bool IsFastestIntervalExplicitlySet => Call<bool>("isFastestIntervalExplicitlySet");

        public LocationRequest SetCountryCode(string countryCode) => CallAsWrapper<LocationRequest>("setCountryCode", countryCode.AsJavaString());

        public LocationRequest SetExpirationDuration(long millis) => CallAsWrapper<LocationRequest>("setExpirationDuration", millis);

        public LocationRequest SetExpirationTime(long millis) => CallAsWrapper<LocationRequest>("setExpirationTime", millis);

        public LocationRequest SetFastestInterval(long millis) => CallAsWrapper<LocationRequest>("setFastestInterval", millis);

        public LocationRequest SetInterval(long millis) => CallAsWrapper<LocationRequest>("setInterval", millis);

        public LocationRequest SetLanguage(string language) => CallAsWrapper<LocationRequest>("setLanguage", language.AsJavaString());

        public LocationRequest SetMaxWaitTime(long millis) => CallAsWrapper<LocationRequest>("setMaxWaitTime", millis);

        public LocationRequest SetNeedAddress(bool needAddress) => CallAsWrapper<LocationRequest>("setNeedAddress", needAddress);

        public LocationRequest SetNumUpdates(int numUpdates) => CallAsWrapper<LocationRequest>("setNumUpdates", numUpdates);

        public LocationRequest SetSmallestDisplacement(float smallestDisplacement) => CallAsWrapper<LocationRequest>("setSmallestDisplacement", smallestDisplacement);

    }
}
