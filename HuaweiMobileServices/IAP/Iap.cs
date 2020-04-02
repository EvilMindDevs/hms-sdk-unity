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

        private class IapClientWrapper : IapClient
        {

            private readonly AndroidJavaObject mIapClientJava;

            public IapClientWrapper(AndroidJavaObject iapClientJava)
            {
                mIapClientJava = iapClientJava;
            }

            public Task<IsEnvReadyResult> EnvReady
            {
                get
                {
                    var javaTask = mIapClientJava.Call<AndroidJavaObject>("isEnvReady");
                    return new TaskImpl<AndroidJavaObject>(javaTask);
                }
            }

            public Task<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq)
            {
                var javaTask = mIapClientJava.Call<AndroidJavaObject>("obtainProductInfo", productInfoReq.mJavaObject);
                return new TaskImpl<AndroidJavaObject>(javaTask);
            }

            public Task<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq consumeOwnedPurchaseReq)
            {
                var javaTask = mIapClientJava.Call<AndroidJavaObject>("consumeOwnedPurchase", consumeOwnedPurchaseReq.mJavaObject);
                return new TaskImpl<AndroidJavaObject>(javaTask);
            }
        }
    }
}