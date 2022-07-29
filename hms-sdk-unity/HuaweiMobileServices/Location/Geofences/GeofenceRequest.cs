using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Location.Geofences
{
    public class GeofenceRequest : JavaObjectWrapper
    {
        public GeofenceRequest(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.GeofenceRequest");

        public static int COORDINATE_TYPE_GCJ_02 => javaClass.GetStatic<int>("COORDINATE_TYPE_GCJ_02");

        public static int COORDINATE_TYPE_WGS_84 => javaClass.GetStatic<int>("COORDINATE_TYPE_WGS_84");

        public static int DWELL_INIT_CONVERSION => javaClass.GetStatic<int>("DWELL_INIT_CONVERSION");

        public static int ENTER_INIT_CONVERSION => javaClass.GetStatic<int>("ENTER_INIT_CONVERSION");

        public static int EXIT_INIT_CONVERSION => javaClass.GetStatic<int>("EXIT_INIT_CONVERSION");

        public int GetCoordinateType => Call<int>("getCoordinateType");

        public IList<Geofence> GetGeofences() => Call<AndroidJavaObject>("getGeofences").AsListFromWrappable<Geofence>();

        public int GetInitConversions => Call<int>("getInitConversions");

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.location.GeofenceRequest$Builder") { }

            public GeofenceRequest Build() => CallAsWrapper<GeofenceRequest>("build");

            public Builder CreateGeofence(Geofence geofence) => CallAsWrapper<Builder>("createGeofence", geofence);

            public Builder CreateGeofenceList(IList<Geofence> geofences) => CallAsWrapper<Builder>("createGeofenceList", geofences.AsJavaListFromWrapper());

            public Builder SetCoordinateType(int coordinateType) => CallAsWrapper<Builder>("setCoordinateType", coordinateType);

            public Builder SetInitConversions(int initConversions) => CallAsWrapper<Builder>("setInitConversions", initConversions);

        }

    }
}
