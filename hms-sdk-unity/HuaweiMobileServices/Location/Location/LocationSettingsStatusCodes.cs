using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationSettingsStatusCodes : JavaObjectWrapper
    {
        public LocationSettingsStatusCodes(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationSettingsStatusCodes");

        public static int RESOLUTION_REQUIRED => javaClass.GetStatic<int>("RESOLUTION_REQUIRED");

        public static int SETTINGS_CHANGE_UNAVAILABLE => javaClass.GetStatic<int>("SETTINGS_CHANGE_UNAVAILABLE");

    }
}