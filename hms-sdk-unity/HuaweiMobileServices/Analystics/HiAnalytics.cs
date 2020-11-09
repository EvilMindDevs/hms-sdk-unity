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

        public static HiAnalyticsInstance getInstance(AndroidJavaObject context)
        {
            if (hiAnalyticsInstance == null)
            {
                AndroidJavaObject analyticsClassObject = analyticsClass.CallStatic<AndroidJavaObject>("getInstance", context);//vgetInstance
                hiAnalyticsInstance = new HiAnalyticsInstance(analyticsClassObject);
            }
            return hiAnalyticsInstance;
        }
    
    }
}
