using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location
{
    public class LocationManager: JavaObjectWrapper
    {
        public LocationManager(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("android.location.LocationManager");

        public static string EXTRA_LOCATION_ENABLED => javaClass.GetStatic<string>("EXTRA_LOCATION_ENABLED");
        public static string EXTRA_PROVIDER_ENABLED => javaClass.GetStatic<string>("EXTRA_PROVIDER_ENABLED");
        public static string EXTRA_PROVIDER_NAME => javaClass.GetStatic<string>("EXTRA_PROVIDER_NAME");
        public static string GPS_PROVIDER => javaClass.GetStatic<string>("GPS_PROVIDER");
        public static string KEY_LOCATION_CHANGED => javaClass.GetStatic<string>("KEY_LOCATION_CHANGED");
        public static string KEY_PROVIDER_ENABLED => javaClass.GetStatic<string>("KEY_PROVIDER_ENABLED");
        public static string KEY_PROXIMITY_ENTERING => javaClass.GetStatic<string>("KEY_PROXIMITY_ENTERING");


    }
}
