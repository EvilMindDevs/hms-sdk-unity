using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.Iap
    public static class Iap
    {

        private static AndroidJavaClass mIapClass = new AndroidJavaClass("com.huawei.hms.iap.Iap");

        public static IapClient GetIapClient()
        {
            AndroidJavaObject iapClient = mIapClass.CallStatic<AndroidJavaObject>("getIapClient", AndroidContext.GetActivityContext());
            return new IapClientWrapper(iapClient);
        }

    }
}