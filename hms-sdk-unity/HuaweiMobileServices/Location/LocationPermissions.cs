using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class LocationPermissions : JavaObjectWrapper
    {
        public LocationPermissions(AndroidJavaObject javaObject) : base(javaObject) { }
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.location.LocationPermissions");

        public static void RequestBackgroundLocationPermissions()
         => sJavaClass.CallStatic("requestBackgroundLocationPermissions", AndroidContext.ActivityContext);

        public static void RequestLocationPermission()
       => sJavaClass.CallStatic("requestLocationPermission", AndroidContext.ApplicationContext);

        public static void RequestActivityRecognitionPermissions()
         => sJavaClass.CallStatic("requestActivityRecognitionPermissions", AndroidContext.ActivityContext);

    }
}
