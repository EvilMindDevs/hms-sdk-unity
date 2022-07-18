using HuaweiMobileServices.AuthService;
using HuaweiMobileServices.Base;
using HuaweiMobileServices.Location.Location;
using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Location.Geofence.Geofences
{
    public class GeocoderService : JavaObjectWrapper
    {
        public GeocoderService(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.GeocoderService");

        public GeocoderService() : base("com.huawei.hms.location.GeocoderService") { }

          public GeocoderService(Locale locale)
            : base("com.huawei.hms.location.GeocoderService",AndroidContext.ApplicationContext,locale) { }
               
          /* public GeocoderService(Locale locale)
           : base("com.huawei.hms.location.GeocoderService", AndroidContext.ActivityContext, locale) { }  */


        public ITask<IList<HWLocation>> GetFromLocation(GetFromLocationRequest getFromLocationRequest)
        {
            var javaTask = Call<AndroidJavaObject>("getFromLocation", getFromLocationRequest);
            return new TaskWrapper<IList<HWLocation>>(javaTask, AndroidJavaObjectExtensions.AsListFromWrappable<HWLocation>);
        }

        public ITask<IList<HWLocation>> GetFromLocationName(GetFromLocationNameRequest getFromLocationNameRequest)
        {
            var javaTask = Call<AndroidJavaObject>("getFromLocationName", getFromLocationNameRequest);
            return new TaskWrapper<IList<HWLocation>>(javaTask, AndroidJavaObjectExtensions.AsListFromWrappable<HWLocation>);
        }

    }
}
