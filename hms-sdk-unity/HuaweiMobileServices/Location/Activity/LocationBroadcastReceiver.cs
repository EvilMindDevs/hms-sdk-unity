using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class LocationBroadcastReceiver : JavaObjectWrapper
    {

        public LocationBroadcastReceiver(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass sJavaClass =
            new AndroidJavaClass("org.m0skit0.android.hms.unity.location.LocationBroadcastReceiver");


        public static AndroidPendingIntent GetPendingIntent()
        {
            AndroidPendingIntent androidIntent =
            sJavaClass.CallStaticAsWrapper<AndroidPendingIntent>("getPendingIntent", AndroidContext.ActivityContext);
            return androidIntent;
        }

        public static IList<ActivityIdentificationData> GetActivityList()
        {
            var list = sJavaClass.CallStatic<AndroidJavaObject>("getActivityList").AsListFromWrappable<ActivityIdentificationData>();
            return list;
        }

        public static IList<ActivityConversionData> GetConversionDataList()
        {
            var list = sJavaClass.CallStatic<AndroidJavaObject>("getConversionDataList").AsListFromWrappable<ActivityConversionData>();
            return list;
        }

        public static ActivityConversionResponse GetActivityConversionResponse()
           => sJavaClass.CallStaticAsWrapper<ActivityConversionResponse>("getActivityConversionResponse");

        public static ActivityIdentificationResponse GetActivityIdentificationResponse()
           => sJavaClass.CallStaticAsWrapper<ActivityIdentificationResponse>("getActivityIdentificationResponse");

        public static void SetLocationCallbackListener(LocationBroadcastListener listener) => sJavaClass.CallStatic("setLocationBroadcastListener", listener.JavaObject);
        
    }
}
