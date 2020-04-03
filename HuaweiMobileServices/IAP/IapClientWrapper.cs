using HuaweiMobileServices.Base;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    internal class IapClientWrapper : IapClient
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
                return new TaskImpl<IsEnvReadyResult>(javaTask);
            }
        }

        public Task<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq)
        {
            var javaTask = mIapClientJava.Call<AndroidJavaObject>("obtainProductInfo", productInfoReq.mJavaObject);
            return new TaskImpl<ProductInfoResult>(javaTask);
        }

        public Task<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq consumeOwnedPurchaseReq)
        {
            var javaTask = mIapClientJava.Call<AndroidJavaObject>("consumeOwnedPurchase", consumeOwnedPurchaseReq.mJavaObject);
            return new TaskImpl<ConsumeOwnedPurchaseResult>(javaTask);
        }
    }
}
