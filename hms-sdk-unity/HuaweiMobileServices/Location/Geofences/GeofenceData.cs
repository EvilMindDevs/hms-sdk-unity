using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;


namespace HuaweiMobileServices.Location.Geofences
{
    public class GeofenceData : JavaObjectWrapper
    {
        public GeofenceData(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.GeofenceData");

        public int GetConversion => Call<int>("getConversion");

        public IList<Geofence> GetConvertingGeofenceList() => CallAsWrapperList<Geofence>("getConvertingGeofenceList");

        public Ads.Location GetConvertingLocation() => CallAsWrapper<Ads.Location>("getConvertingLocation");

        public static GeofenceData GetDataFromIntent(AndroidIntent intent) => javaClass.CallStaticAsWrapper<GeofenceData>("getDataFromIntent", intent);

        public int GetErrorCode => Call<int>("getErrorCode");

        public bool IsFailure => Call<bool>("isFailure");

        public bool IsSuccess => Call<bool>("isSuccess");

    }
}
