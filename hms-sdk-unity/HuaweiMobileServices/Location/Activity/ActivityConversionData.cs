using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class ActivityConversionData : JavaObjectWrapper
    {
        public ActivityConversionData(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityConversionData");

        public ActivityConversionData() : base("com.huawei.hms.location.ActivityConversionData") { }

        public ActivityConversionData(int activityType, int conversionType, long elapsedTimeFromReboot)
            : base("com.huawei.hms.location.ActivityConversionData", activityType, conversionType, elapsedTimeFromReboot) { }

        public int GetActivityType => Call<int>("getActivityType");

        public int GetConversionType => Call<int>("getConversionType");

        public long GetElapsedTimeFromReboot => Call<long>("getElapsedTimeFromReboot");

    }
}
