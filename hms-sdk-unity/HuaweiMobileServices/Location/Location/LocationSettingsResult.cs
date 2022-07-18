using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationSettingsResult : JavaObjectWrapper
    {
        public LocationSettingsResult(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationSettingsResult");

        //Creator

        public LocationSettingsResult() : base("com.huawei.hms.location.LocationSettingsResult") { }

        public LocationSettingsStates GetLocationSettingsStates()
            => CallAsWrapper<LocationSettingsStates>("getLocationSettingsStates");

        public Status GetStatus() => CallAsWrapper<Status>("getStatus");

        public void SetLocationSettingsStates(LocationSettingsStates locationSettingsStates) => Call("setLocationSettingsStates", locationSettingsStates);

        public Status SetStatus(Status status) => CallAsWrapper<Status>("setStatus", status);


    }
}





