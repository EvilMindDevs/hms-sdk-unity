using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class ActivityConversionData : JavaObjectWrapper
    {
        public ActivityConversionData(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityConversionData");

        public ActivityConversionData() : base("com.huawei.hms.location.ActivityConversionData") { }

        //TODO Creator public field CREATOR

        public ActivityConversionData(int activityType, int conversionType, long elapsedTimeFromReboot) 
            : base("com.huawei.hms.location.ActivityConversionData") { }

        public int GetActivityType => Call<int>("getActivityType");
        
        public int GetConversionType => Call<int>("getConversionType");
        
        public long GetElapsedTimeFromReboot => Call<long>("getElapsedTimeFromReboot");

        public void SetActivityType(int activityType) => Call("setActivityType", activityType);

        public void SetConversionType(int conversionType) => Call("setConversionType", conversionType);
    }
}
