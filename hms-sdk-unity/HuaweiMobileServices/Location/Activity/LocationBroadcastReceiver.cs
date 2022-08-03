using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class LocationBroadcastReceiver : JavaObjectWrapper
    {
        public LocationBroadcastReceiver(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass =
            new AndroidJavaClass("org.m0skit0.android.hms.unity.location.LocationBroadcastReceiver");

        public static AndroidPendingIntent GetPendingIntent() => sJavaClass.CallStaticAsWrapper<AndroidPendingIntent>("getPendingIntent", AndroidContext.ActivityContext);

        public static void SetLocationCallbackListener(BroadcastListener listener) => sJavaClass.CallStatic("setLocationBroadcastListener", listener.JavaObject);
    }
}
