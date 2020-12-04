using HuaweiMobileServices.Utils;
using System;
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

        public static class DEFAULT
        {
            private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.agconnect.remoteconfig.AGConnectConfig$DEFAULT");

            public static Boolean BOOLEAN_VALUE
            {
                get => sJavaClass.GetStatic<Boolean>("BOOLEAN_VALUE");
            }

            public static double DOUBLE_VALUE
            {
                get => sJavaClass.GetStatic<double>("DOUBLE_VALUE");
            }

            public static long LONG_VALUE
            {
                get => sJavaClass.GetStatic<long>("LONG_VALUE");
            }

            public static string STRING_VALUE
            {
                get => sJavaClass.GetStatic<string>("STRING_VALUE");
            }

            public static byte[] BYTE_ARRAY_VALUE
            {
                get => sJavaClass.GetStatic<byte[]>("BYTE_ARRAY_VALUE");
            }
        }
    }
}
