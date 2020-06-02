namespace HuaweiMobileServices.Ads
{
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.TagForChild
    public static class TagForChild
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.TagForChild");

        public static int TAG_FOR_CHILD_PROTECTION_UNSPECIFIED = sJavaClass.GetStatic<int>("TAG_FOR_CHILD_PROTECTION_UNSPECIFIED");

        public static int TAG_FOR_CHILD_PROTECTION_FALSE = sJavaClass.GetStatic<int>("TAG_FOR_CHILD_PROTECTION_FALSE");

        public static int TAG_FOR_CHILD_PROTECTION_TRUE = sJavaClass.GetStatic<int>("TAG_FOR_CHILD_PROTECTION_TRUE");

    }

}
