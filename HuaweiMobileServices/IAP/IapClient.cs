using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.IapClient
    public interface IapClient
    {
        Task<IsEnvReadyResult> EnvReady { get; }

        Task<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq);

        Task<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq consumeOwnedPurchaseReq);

        //Task<OwnedPurchasesResult> ObtainOwnedPurchases(OwnedPurchasesReq paramOwnedPurchasesReq);

        //Task<OwnedPurchasesResult> ObtainOwnedPurchaseRecord(OwnedPurchasesReq paramOwnedPurchasesReq);

        //Task<PurchaseIntentResult> CreatePurchaseIntentWithPrice(PurchaseIntentWithPriceReq paramPurchaseIntentWithPriceReq);

        //Task<PurchaseIntentResult> CreatePurchaseIntent(PurchaseIntentReq paramPurchaseIntentReq);
    }

}