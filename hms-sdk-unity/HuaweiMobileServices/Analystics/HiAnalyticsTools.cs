 
using UnityEngine;

namespace HuaweiMobileServices.Analystics
{
    public static class HiAnalyticsTools
    {
        private static AndroidJavaClass sIapClass = new AndroidJavaClass("com.huawei.hms.analytics.HiAnalyticsTools");

        public static void enableLog()
        {
            sIapClass.CallStatic("enableLog");
        }
        /**
         * Log.DEBUG(3) Log.INFO(4) Log.WARN(5)  Log.ERROR(6)
         **/
        public static void enableLog(int level)
        {
            sIapClass.CallStatic("enableLog", level);
        }

        
    }
}
