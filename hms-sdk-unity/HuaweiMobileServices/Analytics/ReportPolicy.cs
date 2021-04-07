using HuaweiMobileServices.Utils;
using System;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ReportPolicy : JavaObjectWrapper
    {
        public ReportPolicy() : base("com.huawei.hms.analytics.type.ReportPolicy") { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.analytics.type.ReportPolicy");
        public static ReportPolicy ON_SCHEDULED_TIME_POLICY => androidJavaClass.GetStaticAsWrapper<ReportPolicy>("ON_SCHEDULED_TIME_POLICY");
 
        public static ReportPolicy ON_APP_LAUNCH_POLICY => androidJavaClass.GetStaticAsWrapper<ReportPolicy>("ON_APP_LAUNCH_POLICY");

        public static ReportPolicy ON_MOVE_BACKGROUND_POLICY => androidJavaClass.GetStaticAsWrapper<ReportPolicy>("ON_MOVE_BACKGROUND_POLICY");
 
        public static ReportPolicy ON_CACHE_THRESHOLD_POLICY => androidJavaClass.GetStaticAsWrapper<ReportPolicy>("ON_CACHE_THRESHOLD_POLICY");
     
        public long Threshold
        {
            set => Call("setThreshold", value);
        }

    } 
}