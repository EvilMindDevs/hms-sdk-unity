namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public static class MetadataHelper
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.helper.MetadataHelper");

        public static string AppId => sJavaClass.CallStaticAsString("getAppId");
    }
}
