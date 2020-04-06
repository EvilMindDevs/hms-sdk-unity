using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.IapClient
    public interface IIapClient
    {
        Task<IsEnvReadyResult> EnvReady { get; }

        Task<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq);

        Task<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq consumeOwnedPurchaseReq);

        Task<OwnedPurchasesResult> ObtainOwnedPurchases(OwnedPurchasesReq ownedPurchasesReq);

        Task<OwnedPurchasesResult> ObtainOwnedPurchaseRecord(OwnedPurchasesReq ownedPurchasesReq);

        Task<PurchaseIntentResult> CreatePurchaseIntentWithPrice(PurchaseIntentWithPriceReq purchaseIntentWithPriceReq);

        Task<PurchaseIntentResult> CreatePurchaseIntent(PurchaseIntentReq purchaseIntentReq);
    }

}