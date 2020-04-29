namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.api.HuaweiMobileServicesUtil
    public static class HuaweiMobileServicesUtil
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.api.HuaweiMobileServicesUtil");

        public static void SetApplication()
        {
            sJavaClass.CallStatic("setApplication", AndroidContext.ApplicationContext);
        }
    }
}
