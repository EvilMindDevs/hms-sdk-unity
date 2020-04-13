namespace HuaweiMobileServices.Base
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.api.HuaweiMobileServicesUtil
    public static class HuaweiMobileServicesUtil
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.api.HuaweiMobileServicesUtil");

        private static void SetApplication()
        {
            sJavaClass.Call("setApplication", AndroidContext.GetApplicationContext());
        }
    }
}
