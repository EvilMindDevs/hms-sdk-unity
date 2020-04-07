using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.Iap
    public static class Iap
    {

        private static AndroidJavaClass sIapClass = new AndroidJavaClass("com.huawei.hms.iap.Iap");

        private static IIapClient sIapClient = null;

        public static IIapClient GetIapClient()
        {
            if (sIapClient == null)
            {
                AndroidJavaObject iapClient = sIapClass.CallStatic<AndroidJavaObject>("getIapClient", AndroidContext.GetActivityContext());
                sIapClient = new IapClientWrapper(iapClient);
            }
            return sIapClient;
        }

    }
}