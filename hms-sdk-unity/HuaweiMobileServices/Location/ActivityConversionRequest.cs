using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class ActivityConversionRequest : JavaObjectWrapper
    {
        public ActivityConversionRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityConversionRequest");

        //Creator public field CREATOR
        //Creator public field Comparator


        public ActivityConversionRequest() : base("com.huawei.hms.location.ActivityConversionRequest") { }

        public ActivityConversionRequest(List<ActivityConversionInfo> activityConversions) : base("com.huawei.hms.location.ActivityConversionInfo") { }

        public List<ActivityConversionInfo> GetActivityConversions() => Call<List<ActivityConversionInfo>>("getActivityConversions");

        public void SetActivityConversions(List<ActivityConversionInfo> activityConversions) => Call("setActivityConversions", activityConversions);

        public void SetDataToIntent(AndroidIntent intent) => Call("setDataToIntent", intent);



    }
}
