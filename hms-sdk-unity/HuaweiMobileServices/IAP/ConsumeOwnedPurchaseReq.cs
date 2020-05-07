namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq
    public class ConsumeOwnedPurchaseReq : JavaObjectWrapper
    {

        public ConsumeOwnedPurchaseReq() : base("com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq") { }

        public virtual string PurchaseToken
        {
            set => Call("setPurchaseToken", value.AsJavaString());
            get => CallAsString("getPurchaseToken");
        }

        public virtual string DeveloperChallenge
        {
            set => Call("setDeveloperChallenge", value.AsJavaString());
            get => CallAsString("getDeveloperChallenge");
        }

    }

}