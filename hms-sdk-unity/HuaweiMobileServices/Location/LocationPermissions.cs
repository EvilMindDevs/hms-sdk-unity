using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class LocationPermissions : JavaObjectWrapper
    {
        public LocationPermissions(AndroidJavaObject javaObject) : base(javaObject) { }
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.location.LocationPermissions");


        public static void ApplyBackgroundLocationPermissions()
         => sJavaClass.CallStatic("applyBackgroundLocationPermissions", AndroidContext.ActivityContext);

        public static void RequestLocationPermission()
       => sJavaClass.CallStatic("requestLocationPermission", AndroidContext.ApplicationContext);


    }
}
