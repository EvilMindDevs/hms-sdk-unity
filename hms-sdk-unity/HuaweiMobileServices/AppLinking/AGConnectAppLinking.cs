using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class AGConnectAppLinking
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.appLinking.AppLinking");

        public static IAGConnectAppLinking agc = null;

        public static IAGConnectAppLinking GetInstance()
        {
            if (agc == null)
            {
                agc = sJavaClass.CallStaticAsWrapper<AGConnectAppLinkingWrapper>("getInstance");
            }
            return agc;
        }

        public static void ShareLink(string agcLink)
        {
            sJavaClass.CallStatic("shareLink", agcLink);
        }

    }
}
