using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Location.Geofences
{
    public class GeofenceService : JavaObjectWrapper
    {
        public GeofenceService(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.GeofenceService");

        public ITask<Void> CreateGeofenceList(GeofenceRequest geofenceRequest, AndroidPendingIntent pendingIntent)
         => CallAsWrapper<TaskVoidWrapper>("createGeofenceList", geofenceRequest,pendingIntent);

        public ITask<Void> DeleteGeofenceList(List<string> geofenceRequestIds)
        => CallAsWrapper<TaskVoidWrapper>("DeleteGeofenceList", geofenceRequestIds.AsJavaStringList());

        public ITask<Void> DeleteGeofenceList(AndroidPendingIntent pendingIntent)
        => CallAsWrapper<TaskVoidWrapper>("deleteGeofenceList", pendingIntent);

    }
}
