using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Crash
{
    public class AGConnectCrash
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.crash.AGConnectCrash");

        public static IAGConnectCrash GetInstance()
        {
            return sJavaClass.CallStaticAsWrapper<AGConnectCrashWrapper>("getInstance");
        }
    }
}
