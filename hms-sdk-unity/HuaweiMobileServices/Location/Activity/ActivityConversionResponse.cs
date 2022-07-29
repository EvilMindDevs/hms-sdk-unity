using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class ActivityConversionResponse : JavaObjectWrapper
    {
        public ActivityConversionResponse(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityConversionResponse");

        public ActivityConversionResponse() : base("com.huawei.hms.location.ActivityConversionResponse") { }

        public ActivityConversionResponse(List<ActivityConversionData> activityConversionDatas)
            : base("com.huawei.hms.location.ActivityConversionInfo", activityConversionDatas) { }

        public static bool ContainDataFromIntent(AndroidIntent intent)
            => javaClass.CallStatic<bool>("containDataFromIntent", intent.JavaObject);

        public IList<ActivityConversionData> GetActivityConversionDatas()
            => Call<AndroidJavaObject>("getActivityConversionDatas").AsListFromWrappable<ActivityConversionData>();

        public static ActivityConversionResponse GetDataFromIntent(AndroidIntent intent)
            => javaClass.CallStaticAsWrapper<ActivityConversionResponse>("getDataFromIntent", intent.JavaObject);

    }
}
