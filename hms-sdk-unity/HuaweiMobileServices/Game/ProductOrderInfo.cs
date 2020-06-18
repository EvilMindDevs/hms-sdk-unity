namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.product.ProductOrderInfo
    public class ProductOrderInfo : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public ProductOrderInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string TradeId => CallAsString("getTradeId");

        public virtual string ProductNo => CallAsString("getProductNo");

        public virtual string OrderId => CallAsString("getOrderId");

        public virtual string Sign => CallAsString("getSign");

    }

}