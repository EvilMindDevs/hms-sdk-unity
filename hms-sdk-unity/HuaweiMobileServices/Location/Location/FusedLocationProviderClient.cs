using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location.Location
{
    public class FusedLocationProviderClient : JavaObjectWrapper
    {
        public FusedLocationProviderClient(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.FusedLocationProviderClient");

        public static string KEY_MOCK_LOCATION => javaClass.GetStatic<string>("KEY_MOCK_LOCATION");

        public static string KEY_VERTICAL_ACCURACY => javaClass.GetStatic<string>("KEY_VERTICAL_ACCURACY");

        public ITask<Ads.Location> GetLastLocation() => CallAsWrapper<TaskJavaObjectWrapper<Ads.Location>>("getLastLocation");

        public ITask<HWLocation> GetLastLocationWithAddress(LocationRequest locationRequest) => CallAsWrapper<TaskJavaObjectWrapper<HWLocation>>("getLastLocationWithAddress", locationRequest);

        public ITask<LocationAvailability> GetLocationAvailability() => CallAsWrapper<TaskJavaObjectWrapper<LocationAvailability>>("getLocationAvailability");

        public ITask<Void> RemoveLocationUpdates(LocationCallback locationCallBack) => CallAsWrapper<TaskVoidWrapper>("removeLocationUpdates", locationCallBack);

        public ITask<Void> RemoveLocationUpdates(AndroidPendingIntent pendingIntent) => CallAsWrapper<TaskVoidWrapper>("removeLocationUpdates", pendingIntent);

        public ITask<Void> RequestLocationUpdates(LocationRequest request, LocationCallback callback, Looper looper) => CallAsWrapper<TaskVoidWrapper>("requestLocationUpdates", request, callback, looper);

        public ITask<Void> RequestLocationUpdates(LocationRequest request, AndroidPendingIntent callbackIntent) => CallAsWrapper<TaskVoidWrapper>("requestLocationUpdates", request, callbackIntent);

        public ITask<Void> SetMockLocation(Ads.Location mockLocation) => CallAsWrapper<TaskVoidWrapper>("setMockLocation", mockLocation);

        public ITask<Void> SetMockMode(bool isMockMode) => CallAsWrapper<TaskVoidWrapper>("setMockMode", isMockMode);
    }
}


