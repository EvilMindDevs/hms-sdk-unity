namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.Iap
    public static class Iap
    {

        private static AndroidJavaClass sIapClass = new AndroidJavaClass("com.huawei.hms.iap.Iap");

        private static IIapClient sIapClient = null;

        public static IIapClient GetIapClient()
        {
            if (sIapClient == null)
            {
                AndroidJavaObject iapClient = sIapClass.CallStatic<AndroidJavaObject>("getIapClient", AndroidContext.ActivityContext);
                sIapClient = new IapClientWrapper(iapClient);
            }
            return sIapClient;
        }

    }
}