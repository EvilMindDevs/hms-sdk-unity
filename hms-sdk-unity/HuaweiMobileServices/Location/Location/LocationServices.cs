using HuaweiMobileServices.AuthService;
using HuaweiMobileServices.Location.Geofence.Geofences;
using HuaweiMobileServices.Location.Geofences;
using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location.Location
{
    public class LocationServices : JavaObjectWrapper
    {
        public LocationServices(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationServices");

        public static FusedLocationProviderClient GetFusedLocationProviderClient()
            => javaClass.CallStaticAsWrapper<FusedLocationProviderClient>("getFusedLocationProviderClient", AndroidContext.ApplicationContext);

        //isim değiştirdim
        public static FusedLocationProviderClient GetFusedLocationProviderClientWithActivity()
         => javaClass.CallStaticAsWrapper<FusedLocationProviderClient>("getFusedLocationProviderClient", AndroidContext.ActivityContext);

        public static GeocoderService GetGeocoderService(Locale locale)
         => javaClass.CallStaticAsWrapper<GeocoderService>("getGeocoderService", AndroidContext.ApplicationContext, locale);

        public static GeocoderService GetGeocoderServiceWithActivity(Locale locale)
         => javaClass.CallStaticAsWrapper<GeocoderService>("getGeocoderService", AndroidContext.ActivityContext, locale);

        public static GeofenceService GetGeofenceService()
         => javaClass.CallStaticAsWrapper<GeofenceService>("getGeofenceService", AndroidContext.ApplicationContext);

        public static GeofenceService GetGeofenceServiceWithActivity()
         => javaClass.CallStaticAsWrapper<GeofenceService>("getGeofenceService", AndroidContext.ActivityContext);

        public static SettingsClient GetSettingsClient()
        => javaClass.CallStaticAsWrapper<SettingsClient>("getSettingsClient", AndroidContext.ApplicationContext);

        public static SettingsClient GetSettingsClientWithActivity()
        => javaClass.CallStaticAsWrapper<SettingsClient>("getSettingsClient", AndroidContext.ActivityContext);

    }
}
