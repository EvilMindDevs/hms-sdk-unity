namespace HuaweiMobileServices.IAP
{
	public interface IapClient
	{
	  Task<ProductInfoResult> obtainProductInfo(ProductInfoReq paramProductInfoReq);

	  Task<ConsumeOwnedPurchaseResult> consumeOwnedPurchase(ConsumeOwnedPurchaseReq paramConsumeOwnedPurchaseReq);

	  Task<OwnedPurchasesResult> obtainOwnedPurchases(OwnedPurchasesReq paramOwnedPurchasesReq);

	  Task<OwnedPurchasesResult> obtainOwnedPurchaseRecord(OwnedPurchasesReq paramOwnedPurchasesReq);

	  Task<PurchaseIntentResult> createPurchaseIntentWithPrice(PurchaseIntentWithPriceReq paramPurchaseIntentWithPriceReq);

	  Task<PurchaseIntentResult> createPurchaseIntent(PurchaseIntentReq paramPurchaseIntentReq);

	  PurchaseResultInfo parsePurchaseResultInfoFromIntent(Intent paramIntent);

	  Task<IsEnvReadyResult> EnvReady {get;}
	}

}