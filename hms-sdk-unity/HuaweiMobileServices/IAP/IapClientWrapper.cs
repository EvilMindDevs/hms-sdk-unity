namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class IapClientWrapper : JavaObjectWrapper, IIapClient
    {

        [UnityEngine.Scripting.Preserve]
        public IapClientWrapper(AndroidJavaObject iapClientJava) : base(iapClientJava) { }

        public ITask<EnvReadyResult> EnvReady
        {
            get
            {
                var javaTask = Call<AndroidJavaObject>("isEnvReady");
                return new TaskJavaObjectWrapper<EnvReadyResult>(javaTask);
            }
        }

        public ITask<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq)
        {
            var javaTask = Call<AndroidJavaObject>("obtainProductInfo", productInfoReq.JavaObject);
            return new TaskJavaObjectWrapper<ProductInfoResult>(javaTask);
        }

        public ITask<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq consumeOwnedPurchaseReq)
        {
            var javaTask = Call<AndroidJavaObject>("consumeOwnedPurchase", consumeOwnedPurchaseReq.JavaObject);
            return new TaskJavaObjectWrapper<ConsumeOwnedPurchaseResult>(javaTask);
        }

        public ITask<OwnedPurchasesResult> ObtainOwnedPurchases(OwnedPurchasesReq ownedPurchasesReq)
        {
            var javaTask = Call<AndroidJavaObject>("obtainOwnedPurchases", ownedPurchasesReq.JavaObject);
            return new TaskJavaObjectWrapper<OwnedPurchasesResult>(javaTask);
        }

        public ITask<OwnedPurchasesResult> ObtainOwnedPurchaseRecord(OwnedPurchasesReq ownedPurchasesReq)
        {
            var javaTask = Call<AndroidJavaObject>("obtainOwnedPurchaseRecord", ownedPurchasesReq.JavaObject);
            return new TaskJavaObjectWrapper<OwnedPurchasesResult>(javaTask);
        }

        public ITask<PurchaseIntentResult> CreatePurchaseIntentWithPrice(PurchaseIntentWithPriceReq purchaseIntentWithPriceReq)
        {
            var javaTask = Call<AndroidJavaObject>("createPurchaseIntentWithPrice", purchaseIntentWithPriceReq.JavaObject);
            return new TaskJavaObjectWrapper<PurchaseIntentResult>(javaTask);
        }

        public ITask<PurchaseIntentResult> CreatePurchaseIntent(PurchaseIntentReq purchaseIntentReq) =>
            CallAsWrapper<TaskJavaObjectWrapper<PurchaseIntentResult>>("createPurchaseIntent", purchaseIntentReq.JavaObject);

        public PurchaseResultInfo ParsePurchaseResultInfoFromIntent(AndroidIntent paramIntent) =>
            CallAsWrapper<PurchaseResultInfo>("parsePurchaseResultInfoFromIntent", paramIntent);

    }
}
