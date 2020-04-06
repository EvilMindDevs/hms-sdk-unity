using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    internal class IapClientWrapper : JavaObjectWrapper, IapClient
    {

        private readonly AndroidJavaObject mIapClientJava;

        public IapClientWrapper(AndroidJavaObject iapClientJava) : base(iapClientJava) { }

        public Task<IsEnvReadyResult> EnvReady
        {
            get
            {
                var javaTask = Call<AndroidJavaObject>("isEnvReady");
                return new TaskImpl<IsEnvReadyResult>(javaTask);
            }
        }

        public Task<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq)
        {
            var javaTask = Call<AndroidJavaObject>("obtainProductInfo", productInfoReq.mJavaObject);
            return new TaskImpl<ProductInfoResult>(javaTask);
        }

        public Task<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq consumeOwnedPurchaseReq)
        {
            var javaTask = Call<AndroidJavaObject>("consumeOwnedPurchase", consumeOwnedPurchaseReq.mJavaObject);
            return new TaskImpl<ConsumeOwnedPurchaseResult>(javaTask);
        }

        public Task<OwnedPurchasesResult> ObtainOwnedPurchases(OwnedPurchasesReq ownedPurchasesReq)
        {
            var javaTask = Call<AndroidJavaObject>("obtainOwnedPurchases", ownedPurchasesReq.mJavaObject);
            return new TaskImpl<OwnedPurchasesResult>(javaTask);
        }

        public Task<OwnedPurchasesResult> ObtainOwnedPurchaseRecord(OwnedPurchasesReq ownedPurchasesReq)
        {
            var javaTask = Call<AndroidJavaObject>("obtainOwnedPurchaseRecord", ownedPurchasesReq.mJavaObject);
            return new TaskImpl<OwnedPurchasesResult>(javaTask);
        }
    }
}
