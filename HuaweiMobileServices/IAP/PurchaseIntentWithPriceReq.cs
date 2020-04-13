namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class PurchaseIntentWithPriceReq : JavaObjectWrapper
    {

        private readonly static string CLASS_NAME = "com.huawei.hms.iap.entity.PurchaseIntentWithPriceReq";

        private static AndroidJavaClass javaClass = new AndroidJavaClass(CLASS_NAME);

        public PurchaseIntentWithPriceReq() : base(CLASS_NAME) { }

        public virtual string ProductId
        {
            get => Call<AndroidJavaObject>("getProductId").AsString();
            set => Call("setProductId", value.AsJavaString());
        }

        public virtual int PriceType
        {
            get => Call<int>("getPriceType");
            set => Call("setPriceType", value);
        }

        public virtual string ProductName
        {
            get => Call<AndroidJavaObject>("getProductName").AsString();
            set => Call("setProductName", value.AsJavaString());
        }

        public virtual string Amount
        {
            get => Call<AndroidJavaObject>("getAmount").AsString();
            set => Call("setAmount", value.AsJavaString());
        }

        public virtual string Country
        {
            get => Call<AndroidJavaObject>("getCountry").AsString();
            set => Call("setCountry", value.AsJavaString());
        }

        public virtual string Currency
        {
            get => Call<AndroidJavaObject>("getCurrency").AsString();
            set => Call("setCurrency", value.AsJavaString());
        }

        public virtual string SdkChannel
        {
            get => Call<AndroidJavaObject>("getSdkChannel").AsString();
            set => Call("setSdkChannel", value.AsJavaString());
        }

        public virtual string ServiceCatalog
        {
            get => Call<AndroidJavaObject>("getServiceCatalog").AsString();
            set => Call("setServiceCatalog", value.AsJavaString());
        }

        public string DeveloperPayload
        {
            get => Call<AndroidJavaObject>("getDeveloperPayload").AsString();
            set => Call("setDeveloperPayload", value.AsJavaString());
        }
    }

}