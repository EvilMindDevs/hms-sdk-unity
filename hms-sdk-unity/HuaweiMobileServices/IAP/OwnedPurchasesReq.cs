namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;

    public class OwnedPurchasesReq : JavaObjectWrapper
    {

        public OwnedPurchasesReq() : base("com.huawei.hms.iap.entity.OwnedPurchasesReq") { }

        public virtual string ContinuationToken
        {
            get => CallAsString("getContinuationToken");
            set => Call("setContinuationToken", value.AsJavaString());
        }

        public virtual int PriceType
        {
            get => Call<int>("getPriceType");
            set => Call("setPriceType", value);
        }
    }

}