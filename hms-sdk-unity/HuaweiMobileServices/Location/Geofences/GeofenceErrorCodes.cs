using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location.Geofences
{
    public class GeofenceErrorCodes : JavaObjectWrapper
    {
        public GeofenceErrorCodes(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.GeofenceErrorCodes");

        public static int GEOFENCE_INSUFFICIENT_PERMISSION => javaClass.GetStatic<int>("GEOFENCE_INSUFFICIENT_PERMISSION");

        public static int GEOFENCE_NUMBER_OVER_LIMIT => javaClass.GetStatic<int>("GEOFENCE_NUMBER_OVER_LIMIT");

        public static int GEOFENCE_PENDINGINTENT_OVER_LIMIT => javaClass.GetStatic<int>("GEOFENCE_PENDINGINTENT_OVER_LIMIT");

        public static int GEOFENCE_REQUEST_TOO_OFTEN => javaClass.GetStatic<int>("GEOFENCE_REQUEST_TOO_OFTEN");

        public static int GEOFENCE_UNAVAILABLE => javaClass.GetStatic<int>("GEOFENCE_UNAVAILABLE");

        public static string GetErrorMessage(int statusCode) => javaClass.CallStaticAsString("getErrorMessage", statusCode);

    }

}
