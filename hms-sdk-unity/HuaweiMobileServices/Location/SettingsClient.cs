using HuaweiMobileServices.Base;
using HuaweiMobileServices.Location.Location;
using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location
{
    public class SettingsClient : JavaObjectWrapper
    {
        public SettingsClient(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.SettingsClient");

        public ITask<Void> SetLogConfig(LogConfig logConfig)
        => CallAsWrapper<TaskVoidWrapper>("setLogConfig", logConfig);

        public ITask<LocationSettingsResponse> CheckLocationSettings(LocationSettingsRequest locationSettingsRequest) => CallAsWrapper<TaskJavaObjectWrapper<LocationSettingsResponse>>("checkLocationSettings", locationSettingsRequest);

    }

}
