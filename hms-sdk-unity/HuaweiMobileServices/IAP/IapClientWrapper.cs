namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class IapClientWrapper : JavaObjectWrapper, IIapClient
    {
        public IapClientWrapper(AndroidJavaObject iapClientJava) : base(iapClientJava) { }

        public ITask<EnvReadyResult> EnvReady
        {
            get
            {
                var javaTask = Call<AndroidJavaObject>("isEnvReady");
                return new TaskJavaObjectWrapper<EnvReadyResult>(javaTask);
            }
        }

        public ITask<IsSandboxActivatedResult> SandboxActivated
        {
            get
            {
                var javaTask = Call<AndroidJavaObject>("isSandboxActivated", new IsSandboxActivatedReq().JavaObject);
                return new TaskJavaObjectWrapper<IsSandboxActivatedResult>(javaTask);
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

        public ITask<StartIapActivityResult> StartIapActivity(StartIapActivityReq startIapActivityReq) =>
    CallAsWrapper<TaskJavaObjectWrapper<StartIapActivityResult>>("startIapActivity", startIapActivityReq.JavaObject);

        public PurchaseResultInfo ParsePurchaseResultInfoFromIntent(AndroidIntent paramIntent) =>
            CallAsWrapper<PurchaseResultInfo>("parsePurchaseResultInfoFromIntent", paramIntent);

    }

    public sealed class PriceType
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.iap.IapClient$PriceType");

        public static readonly PriceType IN_APP_CONSUMABLE = new PriceType(sJavaClass.GetStatic<int>("IN_APP_CONSUMABLE"));
        public static readonly PriceType IN_APP_NONCONSUMABLE = new PriceType(sJavaClass.GetStatic<int>("IN_APP_NONCONSUMABLE"));
        public static readonly PriceType IN_APP_SUBSCRIPTION = new PriceType(sJavaClass.GetStatic<int>("IN_APP_SUBSCRIPTION"));

        private int value;

        public int Value { get => value; set => this.value = value; }

        public PriceType(int value)
        {
            Value = value;
        }
    }
}