using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class ActivityIdentificationResponse : JavaObjectWrapper
    {
        public ActivityIdentificationResponse(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityIdentificationResponse");

        //TODO Creator field

        public ActivityIdentificationResponse() : base("com.huawei.hms.location.ActivityIdentificationResponse") { }

        public ActivityIdentificationResponse(ActivityIdentificationData mostActivityIdentificationData, long time, long elapsedTimeFromReboot)
            : base("com.huawei.hms.location.ActivityIdentificationResponse") { }

        public ActivityIdentificationResponse(List<ActivityIdentificationData> activityIdentificationDatas, long time, long elapsedTimeFromReboot)
            : base("com.huawei.hms.location.ActivityIdentificationResponse") { }

        public static bool ContainDataFromIntent(AndroidIntent intent)
            => javaClass.CallStatic<bool>("containDataFromIntent", intent);

        public List<ActivityConversionData> GetActivityConversionDatas()
            => Call<List<ActivityConversionData>>("getActivityConversionDatas");

        public static ActivityConversionResponse GetDataFromIntent(AndroidIntent intent)
            => javaClass.CallStatic<ActivityConversionResponse>("getDataFromIntent", intent);

        public int GetActivityPosibility(int activityType)
            => Call<int>("getActivityPosibility");

        public ActivityIdentificationData GetMostActivityIdentificationData()
            => Call<ActivityIdentificationData>("getMostActivityIdentificationData");

        public long GetElapsedTimeFromReboot()
            => Call<long>("getElapsedTimeFromReboot");

        public long getTime() => Call<long>("getTime");

        public void SetElapsedTimeFromReboot(long elapsedTimeFromReboot)
            => Call("setElapsedTimeFromReboot", elapsedTimeFromReboot);

        public void SetTime(long time) => Call("setTime", time);

    }
}
