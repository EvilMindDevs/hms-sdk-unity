using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationResult : JavaObjectWrapper
    {
        public LocationResult(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationResult");

        public static LocationResult Create(List<HWLocation> locations) => javaClass.CallStaticAsWrapper<LocationResult>("create", locations.AsJavaList());

        public static LocationResult ExtractResult(AndroidIntent intent) => javaClass.CallStaticAsWrapper<LocationResult>("extractResult", intent);

        public IList<HWLocation> GetHWLocationList() => CallAsWrapperList<HWLocation>("getHWLocationList");

        public HWLocation GetLastHWLocation() => CallAsWrapper<HWLocation>("getLastHWLocation");

        public Ads.Location GetLastLocation() => CallAsWrapper<Ads.Location>("getLastLocation");

        public IList<Ads.Location> GetLocations() => CallAsWrapperList<Ads.Location>("getLocations");

        public static bool HasResult(AndroidIntent intent) => javaClass.CallStatic<bool>("hasResult", intent);

    }
}