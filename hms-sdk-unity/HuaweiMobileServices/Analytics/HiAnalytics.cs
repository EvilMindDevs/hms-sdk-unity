using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Analystics
{
    public class HiAnalytics : JavaObjectWrapper
    {
        private static AndroidJavaClass analyticsClass = new AndroidJavaClass("com.huawei.hms.analytics.HiAnalytics");    

        private static HiAnalyticsInstance hiAnalyticsInstance = null;

        public HiAnalytics( ) : base("com.huawei.hms.analytics.HiAnalytics") { }

        public static HiAnalyticsInstance GetInstance(AndroidJavaObject context)
        {
            if (hiAnalyticsInstance == null)
            {
                hiAnalyticsInstance = analyticsClass.CallStaticAsWrapper<HiAnalyticsInstance>("getInstance", context);
            }
            return hiAnalyticsInstance;
        }

        public static HiAnalyticsInstance GetInstance(AndroidJavaObject context, string routePolicy)
        {
            if (hiAnalyticsInstance == null)
            {
                hiAnalyticsInstance = analyticsClass.CallStaticAsWrapper<HiAnalyticsInstance>("getInstance", context, routePolicy);
            }
            return hiAnalyticsInstance;
        }

    }
}
