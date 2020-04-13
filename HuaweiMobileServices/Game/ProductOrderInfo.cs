namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.product.ProductOrderInfo
    public class ProductOrderInfo : JavaObjectWrapper
    {

        public ProductOrderInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string TradeId
        {
            get => Call<AndroidJavaObject>("getTradeId").AsString();
        }

        public virtual string ProductNo
        {
            get => Call<AndroidJavaObject>("getProductNo").AsString();
        }

        public virtual string OrderId
        {
            get => Call<AndroidJavaObject>("getOrderId").AsString();
        }

        public virtual string Sign
        {
            get => Call<AndroidJavaObject>("getSign").AsString();
        }
    }

}