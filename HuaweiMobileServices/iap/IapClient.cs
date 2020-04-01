namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.IapClient
    public interface IapClient
    {
        Task<ProductInfoResult> ObtainProductInfo(ProductInfoReq paramProductInfoReq);

        Task<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq paramConsumeOwnedPurchaseReq);

        Task<OwnedPurchasesResult> ObtainOwnedPurchases(OwnedPurchasesReq paramOwnedPurchasesReq);

        Task<OwnedPurchasesResult> ObtainOwnedPurchaseRecord(OwnedPurchasesReq paramOwnedPurchasesReq);

        Task<PurchaseIntentResult> CreatePurchaseIntentWithPrice(PurchaseIntentWithPriceReq paramPurchaseIntentWithPriceReq);

        Task<PurchaseIntentResult> CreatePurchaseIntent(PurchaseIntentReq paramPurchaseIntentReq);

        Task<IsEnvReadyResult> EnvReady { get; }
    }

}