using HuaweiMobileServices.Utils;
using UnityEngine;
using System.Collections.Generic;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationSettingsRequest : JavaObjectWrapper
    {
        public LocationSettingsRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationSettingsRequest");

        //Creator


        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.location.LocationSettingsRequest$Builder") { }

            public LocationSettingsRequest Build() => CallAsWrapper<LocationSettingsRequest>("build");

            public Builder AddAllLocationRequests(Dictionary<string,LocationRequest> requests) => CallAsWrapper<Builder>("addAllLocationRequests", requests.Values);

            //todo dictionaty kullandım collection yerine bak hata var mı

            public Builder AddLocationRequest(LocationRequest request) => CallAsWrapper<Builder>("addLocationRequest", request);

            public Builder SetAlwaysShow(bool show) => CallAsWrapper<Builder>("setAlwaysShow", show);

            public Builder SetNeedBle(bool needBle) => CallAsWrapper<Builder>("setNeedBle", needBle);

        }

    }
}




