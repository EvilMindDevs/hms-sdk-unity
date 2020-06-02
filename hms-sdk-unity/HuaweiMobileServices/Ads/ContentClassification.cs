namespace HuaweiMobileServices.Ads
{

    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.ContentClassification
    public static class ContentClassification
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.ContentClassification");

        public static string AD_CONTENT_CLASSIFICATION_W = sJavaClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_W");

        public static string AD_CONTENT_CLASSIFICATION_PI = sJavaClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_PI");

        public static string AD_CONTENT_CLASSIFICATION_J = sJavaClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_J");

        public static string AD_CONTENT_CLASSIFICATION_A = sJavaClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_A");

        public static string AD_CONTENT_CLASSIFICATION_UNKOWN = sJavaClass.GetStatic<string>("AD_CONTENT_CLASSIFICATION_UNKOWN");

    }

}