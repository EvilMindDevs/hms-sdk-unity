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
            : base("com.huawei.hms.location.ActivityIdentificationResponse", mostActivityIdentificationData, time, elapsedTimeFromReboot) { }

        public ActivityIdentificationResponse(List<ActivityIdentificationData> activityIdentificationDatas, long time, long elapsedTimeFromReboot)
            : base("com.huawei.hms.location.ActivityIdentificationResponse", activityIdentificationDatas.AsJavaList(), time, elapsedTimeFromReboot) { }

        public static bool ContainDataFromIntent(AndroidIntent intent)
            => javaClass.CallStatic<bool>("containDataFromIntent", intent);

        /* public List<ActivityConversionData> GetActivityConversionDatas()
             => Call<List<ActivityConversionData>>("getActivityConversionDatas"); */

        public IList<ActivityIdentificationData> GetActivityIdentificationDatas()
        {
            Debug.Log("Enes Enter GetActivityList1");
            var list = Call<AndroidJavaObject>("getActivityIdentificationDatas").AsListFromWrappable<ActivityIdentificationData>();
            Debug.Log(list[0].ToString());
            Debug.Log("Enes Enter GetActivityList2");
            return list;
        }

        public static ActivityConversionResponse GetDataFromIntent(AndroidIntent intent)
            => javaClass.CallStaticAsWrapper<ActivityConversionResponse>("getDataFromIntent", intent.JavaObject);

        public int GetActivityPossibility(int activityType)
            => Call<int>("getActivityPossibility", activityType);

        public ActivityIdentificationData GetMostActivityIdentification()
            => CallAsWrapper<ActivityIdentificationData>("getMostActivityIdentification");

        public long GetElapsedTimeFromReboot()
            => Call<long>("getElapsedTimeFromReboot");

        public long GetTime() => Call<long>("getTime");

        public void SetElapsedTimeFromReboot(long elapsedTimeFromReboot)
            => Call("setElapsedTimeFromReboot", elapsedTimeFromReboot);

        public void SetTime(long time) => Call("setTime", time);

    }
}
