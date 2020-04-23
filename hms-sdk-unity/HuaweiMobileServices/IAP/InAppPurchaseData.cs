namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.iap.entity.InAppPurchaseData
    public class InAppPurchaseData : JavaObjectWrapper
    {

        public const int NOT_PRESENT = -2147483648;

        public InAppPurchaseData(string paramString) : base("com.huawei.hms.iap.entity.InAppPurchaseData", paramString) { }

        public virtual long ApplicationId => Call<long>("getApplicationId");

        public virtual bool AutoRenewing => Call<bool>("getAutoRenewing");

        public virtual string OrderID => CallAsString("getOrderID");

        public virtual string PackageName => CallAsString("getPackageName");

        public virtual string ProductId => CallAsString("getProductId");

        public virtual string ProductName => CallAsString("getProductName");

        public virtual long PurchaseTime => Call<long>("getPurchaseTime");

        public virtual int PurchaseState => Call<int>("getPurchaseState");

        public virtual string DeveloperPayload => CallAsString("getDeveloperPayload");

        public virtual string PurchaseToken => CallAsString("getPurchaseToken");

        public virtual int PurchaseType => Call<int>("getPurchaseType");

        public virtual string Currency => CallAsString("getCurrency");

        public virtual long Price => Call<long>("getPrice");

        public virtual string Country => CallAsString("getCountry");

        public virtual string LastOrderId => CallAsString("getLastOrderId");

        public virtual string ProductGroup => CallAsString("getProductGroup");

        public virtual long OriPurchaseTime => Call<long>("getOriPurchaseTime");

        public virtual string SubscriptionId => CallAsString("getSubscriptionId");

        public virtual int Quantity => Call<int>("getQuantity");

        public virtual long DaysLasted => Call<long>("getDaysLasted");

        public virtual long NumOfPeriods => Call<long>("getNumOfPeriods");

        public virtual long NumOfDiscount => Call<long>("getNumOfDiscount");

        public virtual long ExpirationDate => Call<long>("getNumOfDiscount");

        public virtual int ExpirationIntent => Call<int>("getExpirationIntent");

        public virtual int RetryFlag => Call<int>("getRetryFlag");

        public virtual int IntroductoryFlag => Call<int>("getIntroductoryFlag");

        public virtual int TrialFlag => Call<int>("getTrialFlag");

        public virtual long CancelTime => Call<long>("getCancelTime");

        public virtual int CancelReason => Call<int>("getCancelReason");

        public virtual string AppInfo => CallAsString("getAppInfo");

        public virtual int NotifyClosed => Call<int>("getNotifyClosed");

        public virtual int RenewStatus => Call<int>("getRenewStatus");

        public virtual int PriceConsentStatus => Call<int>("getPriceConsentStatus");

        public virtual long RenewPrice => Call<long>("getRenewPrice");

        public virtual bool SubValid => Call<bool>("getSubValid");

        public virtual int CancelledSubKeepDays => Call<int>("getCancelledSubKeepDays");

        public virtual int Kind => Call<int>("getKind");

        public virtual string DeveloperChallenge => CallAsString("getDeveloperChallenge");

        public virtual int ConsumptionState => Call<int>("getConsumptionState");

        public virtual int Acknowledged => Call<int>("getAcknowledged");

        public virtual string PayOrderId => CallAsString("getPayOrderId");

        public virtual string PayType => CallAsString("getPayType");

        public virtual int DeferFlag => Call<int>("getDeferFlag");

        public virtual string OriSubscriptionId => CallAsString("getOriSubscriptionId");

        public virtual int CancelWay => Call<int>("getCancelWay");

        public virtual long CancellationTime => Call<long>("getCancellationTime");

    }

}