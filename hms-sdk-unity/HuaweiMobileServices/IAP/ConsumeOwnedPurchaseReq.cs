namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq
    public class ConsumeOwnedPurchaseReq : JavaObjectWrapper
    {

        public ConsumeOwnedPurchaseReq() : base("com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq") { }

        public string PurchaseToken
        {
            get => CallAsString("getPurchaseToken");
            set => Call("setPurchaseToken", value.AsJavaString());
        }

        public string DeveloperChallenge
        {
            get => CallAsString("getDeveloperChallenge");
            set => Call("setDeveloperChallenge", value.AsJavaString());
        }

        public string SignatureAlgorithm
        {
            get => CallAsString("getSignatureAlgorithm");
            set => Call("setSignatureAlgorithm", value.AsJavaString());
        }

    }
}