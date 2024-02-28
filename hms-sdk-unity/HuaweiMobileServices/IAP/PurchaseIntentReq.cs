namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;

    public class PurchaseIntentReq : BaseReq
    {
        public PurchaseIntentReq() : base("com.huawei.hms.iap.entity.PurchaseIntentReq") { }

        public virtual string DeveloperPayload
        {
            get => CallAsString("getDeveloperPayload");
            set => Call("setDeveloperPayload", value.AsJavaString());
        }

        public virtual PriceType PriceType
        {
            get => new PriceType(Call<int>("getPriceType"));
            set => Call("setPriceType", value.Value);
        }

        public virtual string ProductId
        {
            get => CallAsString("getProductId");
            set => Call("setProductId", value.AsJavaString());
        }


        public string SignatureAlgorithm
        {
            get => CallAsString("getSignatureAlgorithm");
            set => Call("setSignatureAlgorithm", value.AsJavaString());
        }
    }
}
