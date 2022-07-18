using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Activity
{
    public class ActivityConversionInfo : JavaObjectWrapper
    {
        public ActivityConversionInfo(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityConversionInfo");

       // public static int ENTER_ACTIVITY_CONVERSION = 0;
       // public static int EXIT_ACTIVITY_CONVERSION = 1;

        public static int ENTER_ACTIVITY_CONVERSION => javaClass.GetStatic<int>("ENTER_ACTIVITY_CONVERSION");
        public static int EXIT_ACTIVITY_CONVERSION => javaClass.GetStatic<int>("EXIT_ACTIVITY_CONVERSION");
        
        //Creator public field CREATOR

        public ActivityConversionInfo() : base("com.huawei.hms.location.ActivityConversionInfo") { }

        public ActivityConversionInfo(int activityType, int conversionType) : base("com.huawei.hms.location.ActivityConversionInfo", activityType, conversionType) { }

        public int GetActivityType => Call<int>("getActivityType");

        public int GetConversionType => Call<int>("getConversionType");

        public void SetActivityType(int activityType) => Call("setActivityType", activityType);

        public void SetConversionType(int conversionType) => Call("setConversionType", conversionType);

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.location.ActivityConversionInfo$Builder") { }

            public ActivityConversionInfo Build() => CallAsWrapper<ActivityConversionInfo>("build");

            public Builder SetActivityType(int activityType) => CallAsWrapper<Builder>("setActivityType", activityType);

            public Builder SetConversionType(int conversionType) => CallAsWrapper<Builder>("setConversionType", conversionType);
        }
    }
}
