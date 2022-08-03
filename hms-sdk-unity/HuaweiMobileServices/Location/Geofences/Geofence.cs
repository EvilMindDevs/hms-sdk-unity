namespace HuaweiMobileServices.Location.Geofences
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class Geofence : JavaObjectWrapper
    {
        public Geofence(AndroidJavaObject javaObject) : base(javaObject) { }
        
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.Geofence");

        public const int ENTER_GEOFENCE_CONVERSION = 1;
        public const int EXIT_GEOFENCE_CONVERSION = 2;
        public const int DWELL_GEOFENCE_CONVERSION = 4;
        public const long GEOFENCE_NEVER_EXPIRE = -1L;

        public string GetUniqueId() => CallAsString("getUniqueId");

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Geofence Build() => CallAsWrapper<Geofence>("build");

            public Builder() : base("com.huawei.hms.location.Geofence$Builder") { }

            public Builder SetConversions(int conversions) => CallAsWrapper<Builder>("setConversions", conversions);

            public Builder SetDwellDelayTime(int dwellDelayTime) => CallAsWrapper<Builder>("setDwellDelayTime", dwellDelayTime);

            public Builder SetNotificationInterval(int notificationInterval) => CallAsWrapper<Builder>("setNotificationInterval", notificationInterval);

            public Builder SetRoundArea(double latitude, double longitude, float radius) => CallAsWrapper<Builder>("setRoundArea", latitude, longitude, radius);

            public Builder SetUniqueId(string uniqueId) => CallAsWrapper<Builder>("setUniqueId", uniqueId.AsJavaString());

            public Builder SetValidContinueTime(long validContinueTime) => CallAsWrapper<Builder>("setValidContinueTime", validContinueTime);
        }
    }
}
