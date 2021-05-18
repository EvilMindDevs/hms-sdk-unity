namespace HuaweiMobileServices.Ads
{
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.Gender
    public static class Gender
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.Gender");

        public static string UNKNOWN = sJavaClass.GetStatic<string>("UNKNOWN");

        public static string MALE = sJavaClass.GetStatic<string>("MALE");

        public static string FEMALE = sJavaClass.GetStatic<string>("FEMALE");
    }
}
