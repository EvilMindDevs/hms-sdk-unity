using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class ActivityConversionResponse : JavaObjectWrapper
    {
        public ActivityConversionResponse(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityConversionResponse");

        //Creator public field CREATOR

        public ActivityConversionResponse() : base("com.huawei.hms.location.ActivityConversionResponse") { }

        public ActivityConversionResponse(List<ActivityConversionData> activityConversionDatas)
            : base("com.huawei.hms.location.ActivityConversionInfo") { }

        public static bool ContainDataFromIntent(AndroidIntent intent)
            => javaClass.CallStatic<bool>("containDataFromIntent", intent);

        public List<ActivityConversionData> GetActivityConversionDatas()
            => Call<List<ActivityConversionData>>("getActivityConversionDatas");

        public static ActivityConversionResponse GetDataFromIntent(AndroidIntent intent)
            => javaClass.CallStatic<ActivityConversionResponse>("getDataFromIntent", intent);

    }
}
