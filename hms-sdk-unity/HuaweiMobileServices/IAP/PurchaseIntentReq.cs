namespace HuaweiMobileServices.IAP
{

    using HuaweiMobileServices.Utils;

    public class PurchaseIntentReq : JavaObjectWrapper
    {

        public PurchaseIntentReq() : base("com.huawei.hms.iap.entity.PurchaseIntentReq") { }

        public virtual string DeveloperPayload
        {
            get => CallAsString("getDeveloperPayload");
            set => Call("setDeveloperPayload", value.AsJavaString());
        }

        public virtual int PriceType
        {
            get => Call<int>("getPriceType");
            set => Call("setPriceType", value);
        }

        public virtual string ProductId
        {
            get => CallAsString("getProductId");
            set => Call("setProductId", value.AsJavaString());
        }

    }
}
