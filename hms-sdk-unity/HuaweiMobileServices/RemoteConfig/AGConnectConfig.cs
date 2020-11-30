using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.RemoteConfig
{
    public class AGConnectConfig
    {
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.remoteConfig.RemoteConfig");

        public static IAGConnectConfig agc = null;

        public static IAGConnectConfig GetInstance()
        {
            if (agc == null)
            {
                agc = sJavaClass.CallStaticAsWrapper<AGConnectConfigWrapper>("getInstance");
            }
            return agc;
        }
    }
}
