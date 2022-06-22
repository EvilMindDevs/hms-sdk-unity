using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    class ActivityConversionInfo : JavaObjectWrapper
    {
        public ActivityConversionInfo(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityConversionInfo");

        public static int ENTER_ACTIVITY_CONVERSION = 0;
        public static int EXIT_ACTIVITY_CONVERSION = 1;

        public ActivityConversionInfo() : base("com.huawei.hms.location.ActivityConversionInfo") { }

        public ActivityConversionInfo(int activityType, int conversionTypet) : base("com.huawei.hms.location.ActivityConversionInfo") { }

        public int getActivityType => Call<int>("getActivityType");
        public int GetConversionType => Call<int>("getConversionType");


    }
}
