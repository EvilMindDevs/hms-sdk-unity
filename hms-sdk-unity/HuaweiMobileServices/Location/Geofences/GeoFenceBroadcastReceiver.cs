using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Geofences
{
    public class GeofenceBroadcastReceiver : JavaObjectWrapper
    {
        public GeofenceBroadcastReceiver(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass =
        new AndroidJavaClass("org.m0skit0.android.hms.unity.location.GeofenceBroadcastReceiver");

        public static AndroidPendingIntent GetPendingIntent() =>
            sJavaClass.CallStaticAsWrapper<AndroidPendingIntent>("getPendingIntent", AndroidContext.ActivityContext);

        public static void SetGeofenceBroadcastListener(BroadcastListener listener) => sJavaClass.CallStatic("setGeofenceBroadcastListener", listener.JavaObject);

    }
}

