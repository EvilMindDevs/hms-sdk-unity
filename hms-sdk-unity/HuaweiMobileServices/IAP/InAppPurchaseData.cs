namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.InAppPurchaseData
    public class InAppPurchaseData : JavaObjectWrapper
    {
        public const int NOT_PRESENT = int.MinValue;

        public InAppPurchaseData(string paramString) : base("com.huawei.hms.iap.entity.InAppPurchaseData", paramString) { }

        public string ApplicationId => Call<string>("getApplicationId");

        public bool AutoRenewing => Call<bool>("isAutoRenewing");

        public string OrderID => CallAsString("getOrderID");

        public string PackageName => CallAsString("getPackageName");

        public string ProductId => CallAsString("getProductId");

        public string ProductName => CallAsString("getProductName");

        public long PurchaseTime => Call<long>("getPurchaseTime");

        public int PurchaseState => Call<int>("getPurchaseState");

        public string DeveloperPayload => CallAsString("getDeveloperPayload");

        public string PurchaseToken => CallAsString("getPurchaseToken");

        public int PurchaseType => Call<int>("getPurchaseType");

        public string Currency => CallAsString("getCurrency");

        public long Price => Call<long>("getPrice");

        public string Country => CallAsString("getCountry");

        public string LastOrderId => CallAsString("getLastOrderId");

        public string ProductGroup => CallAsString("getProductGroup");

        public long OriPurchaseTime => Call<long>("getOriPurchaseTime");

        public string SubscriptionId => CallAsString("getSubscriptionId");

        public int Quantity => Call<int>("getQuantity");

        public long DaysLasted => Call<long>("getDaysLasted");

        public long NumOfPeriods => Call<long>("getNumOfPeriods");

        public long NumOfDiscount => Call<long>("getNumOfDiscount");

        public long ExpirationDate => Call<long>("getExpirationDate");

        public int ExpirationIntent => Call<int>("getExpirationIntent");

        public int RetryFlag => Call<int>("getRetryFlag");

        public int IntroductoryFlag => Call<int>("getIntroductoryFlag");

        public int TrialFlag => Call<int>("getTrialFlag");

        public long CancelTime => Call<long>("getCancelTime");

        public int CancelReason => Call<int>("getCancelReason");

        public string AppInfo => CallAsString("getAppInfo");

        public int NotifyClosed => Call<int>("getNotifyClosed");

        public int RenewStatus => Call<int>("getRenewStatus");

        public int PriceConsentStatus => Call<int>("getPriceConsentStatus");

        public long RenewPrice => Call<long>("getRenewPrice");

        public bool SubValid => Call<bool>("isSubValid");

        public int CancelledSubKeepDays => Call<int>("getCancelledSubKeepDays");

        public int Kind => Call<int>("getKind");

        public string DeveloperChallenge => CallAsString("getDeveloperChallenge");

        public int ConsumptionState => Call<int>("getConsumptionState");

        public string PayOrderId => CallAsString("getPayOrderId");

        public string PayType => CallAsString("getPayType");

        public int DeferFlag => Call<int>("getDeferFlag");

        public string OriSubscriptionId => CallAsString("getOriSubscriptionId");

        public int CancelWay => Call<int>("getCancelWay");

        public long CancellationTime => Call<long>("getCancellationTime");

        public long ResumeTime => Call<long>("getResumeTime");

        public long GraceExpirationTime => Call<long>("getGraceExpirationTime");

        public int AccountFlag => Call<int>("getAccountFlag");
    }
}