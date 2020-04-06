using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    internal class IapClientWrapper : JavaObjectWrapper, IIapClient
    {

        public IapClientWrapper(AndroidJavaObject iapClientJava) : base(iapClientJava) { }

        public ITask<EnvReadyResult> EnvReady
        {
            get
            {
                var javaTask = Call<AndroidJavaObject>("isEnvReady");
                return new TaskImpl<EnvReadyResult>(javaTask);
            }
        }

        public ITask<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq)
        {
            var javaTask = Call<AndroidJavaObject>("obtainProductInfo", productInfoReq.JavaObject);
            return new TaskImpl<ProductInfoResult>(javaTask);
        }

        public ITask<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq consumeOwnedPurchaseReq)
        {
            var javaTask = Call<AndroidJavaObject>("consumeOwnedPurchase", consumeOwnedPurchaseReq.JavaObject);
            return new TaskImpl<ConsumeOwnedPurchaseResult>(javaTask);
        }

        public ITask<OwnedPurchasesResult> ObtainOwnedPurchases(OwnedPurchasesReq ownedPurchasesReq)
        {
            var javaTask = Call<AndroidJavaObject>("obtainOwnedPurchases", ownedPurchasesReq.JavaObject);
            return new TaskImpl<OwnedPurchasesResult>(javaTask);
        }

        public ITask<OwnedPurchasesResult> ObtainOwnedPurchaseRecord(OwnedPurchasesReq ownedPurchasesReq)
        {
            var javaTask = Call<AndroidJavaObject>("obtainOwnedPurchaseRecord", ownedPurchasesReq.JavaObject);
            return new TaskImpl<OwnedPurchasesResult>(javaTask);
        }

        public ITask<PurchaseIntentResult> CreatePurchaseIntentWithPrice(PurchaseIntentWithPriceReq purchaseIntentWithPriceReq)
        {
            var javaTask = Call<AndroidJavaObject>("createPurchaseIntentWithPrice", purchaseIntentWithPriceReq.JavaObject);
            return new TaskImpl<PurchaseIntentResult>(javaTask);
        }

        public ITask<PurchaseIntentResult> CreatePurchaseIntent(PurchaseIntentReq purchaseIntentReq)
        {
            throw new System.NotImplementedException();
        }
    }
}
