using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location.Geofences
{
    public class GeoFenceBroadcastReceiver : JavaObjectWrapper
    {
        public GeoFenceBroadcastReceiver(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass =
        new AndroidJavaClass("org.m0skit0.android.hms.unity.location.GeoFenceBroadcastReceiver");

        public static AndroidPendingIntent GetPendingIntent()
        {
            AndroidPendingIntent androidIntent =
            sJavaClass.CallStaticAsWrapper<AndroidPendingIntent>("getPendingIntent", AndroidContext.ActivityContext);
            return androidIntent;
        }
        public static GeofenceData GetGeofenceData() =>
            sJavaClass.CallStaticAsWrapper<GeofenceData>("getGeofenceData");

    }
}

