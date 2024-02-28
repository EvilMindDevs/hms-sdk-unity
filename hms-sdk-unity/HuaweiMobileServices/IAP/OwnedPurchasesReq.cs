namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;

    public class OwnedPurchasesReq : BaseReq
    {

        public OwnedPurchasesReq() : base("com.huawei.hms.iap.entity.OwnedPurchasesReq") { }

        public virtual string ContinuationToken
        {
            get => CallAsString("getContinuationToken");
            set => Call("setContinuationToken", value.AsJavaString());
        }

        public virtual PriceType PriceType
        {
            get => new PriceType(Call<int>("getPriceType"));
            set => Call("setPriceType", value.Value);
        }

        public string SignatureAlgorithm
        {
            get => CallAsString("getSignatureAlgorithm");
            set => Call("setSignatureAlgorithm", value.AsJavaString());
        }
    }
}