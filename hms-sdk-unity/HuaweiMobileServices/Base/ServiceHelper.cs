namespace HuaweiMobileServices.Base
{
    using UnityEngine;

    public static class ServiceHelper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.helper.ServiceHelper");

        public static bool GMSAvailable => sJavaClass.CallStatic<bool>("isGMSAvailable");

        public static bool HMSAvailable => sJavaClass.CallStatic<bool>("isHMSAvailable");
    }
}
