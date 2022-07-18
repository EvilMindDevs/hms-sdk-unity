using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;
using HuaweiMobileServices.Location.Activity;

namespace HuaweiMobileServices.Location
{
    public class ActivityConversionRequest : JavaObjectWrapper
    {
        public ActivityConversionRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityConversionRequest");

        //Creator public field CREATOR
        //Creator public field Comparator

        public ActivityConversionRequest() : base("com.huawei.hms.location.ActivityConversionRequest") { }

        public ActivityConversionRequest(List<ActivityConversionInfo> activityConversions) : base("com.huawei.hms.location.ActivityConversionInfo", activityConversions) { }

        public List<ActivityConversionInfo> GetActivityConversions() => Call<List<ActivityConversionInfo>>("getActivityConversions");
        
        public void SetActivityConversions(IList<ActivityConversionInfo> list) => Call("setActivityConversions", list.AsJavaListFromWrapper());

        public void SetDataToIntent(AndroidIntent intent) => Call("setDataToIntent", intent);

    }
}
