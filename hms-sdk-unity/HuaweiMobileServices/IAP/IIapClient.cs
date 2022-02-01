﻿namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.iap.IapClient
    public interface IIapClient
    {
        ITask<EnvReadyResult> EnvReady { get; }

        ITask<IsSandboxActivatedResult> SandboxActivated { get; }

        ITask<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq);

        ITask<ConsumeOwnedPurchaseResult> ConsumeOwnedPurchase(ConsumeOwnedPurchaseReq consumeOwnedPurchaseReq);

        ITask<OwnedPurchasesResult> ObtainOwnedPurchases(OwnedPurchasesReq ownedPurchasesReq);

        ITask<OwnedPurchasesResult> ObtainOwnedPurchaseRecord(OwnedPurchasesReq ownedPurchasesReq);

        ITask<PurchaseIntentResult> CreatePurchaseIntentWithPrice(PurchaseIntentWithPriceReq purchaseIntentWithPriceReq);

        ITask<PurchaseIntentResult> CreatePurchaseIntent(PurchaseIntentReq purchaseIntentReq);

        ITask<StartIapActivityResult> StartIapActivity(StartIapActivityReq startIapActivityReq);

        PurchaseResultInfo ParsePurchaseResultInfoFromIntent(AndroidIntent paramIntent);

        void EnablePendingPurchase();
    }

}