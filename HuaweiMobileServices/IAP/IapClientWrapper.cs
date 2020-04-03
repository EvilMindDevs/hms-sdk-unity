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
                return new AbstractTask<AndroidJavaObject>(javaTask);
            }
        }

        public Task<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq)
        {
            var javaTask = mIapClientJava.Call<AndroidJavaObject>("obtainProductInfo", productInfoReq.mJavaObject);
            return new AbstractTask<AndroidJavaObject>(javaTask);
        }

        public Task<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq consumeOwnedPurchaseReq)
        {
            var javaTask = mIapClientJava.Call<AndroidJavaObject>("consumeOwnedPurchase", consumeOwnedPurchaseReq.mJavaObject);
            return new AbstractTask<AndroidJavaObject>(javaTask);
        }
    }
}
