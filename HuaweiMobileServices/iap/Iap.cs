using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    public class Iap
    {

        private static AndroidJavaClass mIap = new AndroidJavaClass("com.huawei.hms.iap.Iap");

        public static IapClient getIapClient()
        {
            AndroidJavaObject iapClient = mIap.Call<AndroidJavaObject>("getIapClient", AndroidContext.getActivityContext());
            return new IapClientWrapper(iapClient);
        }

        private class IapClientWrapper : IapClient
        {

            private readonly AndroidJavaObject mJavaIapClient;

            public IapClientWrapper(AndroidJavaObject javaIapClient)
            {
                mJavaIapClient = javaIapClient;
            }

            public Task<IsEnvReadyResult> EnvReady => throw new System.NotImplementedException();

            public Task<ConsumeOwnedPurchaseResult> consumeOwnedPurchase(ConsumeOwnedPurchaseReq paramConsumeOwnedPurchaseReq)
            {
                throw new System.NotImplementedException();
            }

            public Task<PurchaseIntentResult> createPurchaseIntent(PurchaseIntentReq paramPurchaseIntentReq)
            {
                throw new System.NotImplementedException();
            }

            public Task<PurchaseIntentResult> createPurchaseIntentWithPrice(PurchaseIntentWithPriceReq paramPurchaseIntentWithPriceReq)
            {
                throw new System.NotImplementedException();
            }

            public Task<OwnedPurchasesResult> obtainOwnedPurchaseRecord(OwnedPurchasesReq paramOwnedPurchasesReq)
            {
                throw new System.NotImplementedException();
            }

            public Task<OwnedPurchasesResult> obtainOwnedPurchases(OwnedPurchasesReq paramOwnedPurchasesReq)
            {
                throw new System.NotImplementedException();
            }

            public Task<ProductInfoResult> obtainProductInfo(ProductInfoReq paramProductInfoReq)
            {
                throw new System.NotImplementedException();
            }

            public PurchaseResultInfo parsePurchaseResultInfoFromIntent(Intent paramIntent)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}