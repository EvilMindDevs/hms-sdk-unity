namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class PurchaseIntentWithPriceReq : JavaObjectWrapper
    {

        private readonly static string CLASS_NAME = "com.huawei.hms.iap.entity.PurchaseIntentWithPriceReq";

        [UnityEngine.Scripting.Preserve]
        private static AndroidJavaClass javaClass = new AndroidJavaClass(CLASS_NAME);

        public PurchaseIntentWithPriceReq() : base(CLASS_NAME) { }

        public virtual string ProductId
        {
            get => CallAsString("getProductId");
            set => Call("setProductId", value.AsJavaString());
        }

        public virtual int PriceType
        {
            get => Call<int>("getPriceType");
            set => Call("setPriceType", value);
        }

        public virtual string ProductName
        {
            get => CallAsString("getProductName");
            set => Call("setProductName", value.AsJavaString());
        }

        public virtual string Amount
        {
            get => CallAsString("getAmount");
            set => Call("setAmount", value.AsJavaString());
        }

        public virtual string Country
        {
            get => CallAsString("getCountry");
            set => Call("setCountry", value.AsJavaString());
        }

        public virtual string Currency
        {
            get => CallAsString("getCurrency");
            set => Call("setCurrency", value.AsJavaString());
        }

        public virtual string SdkChannel
        {
            get => CallAsString("getSdkChannel");
            set => Call("setSdkChannel", value.AsJavaString());
        }

        public virtual string ServiceCatalog
        {
            get => CallAsString("getServiceCatalog");
            set => Call("setServiceCatalog", value.AsJavaString());
        }

        public string DeveloperPayload
        {
            get => CallAsString("getDeveloperPayload");
            set => Call("setDeveloperPayload", value.AsJavaString());
        }
    }

}