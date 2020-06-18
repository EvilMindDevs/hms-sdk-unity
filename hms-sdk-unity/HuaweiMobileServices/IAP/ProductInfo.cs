namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.ProductInfo
    public class ProductInfo : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public ProductInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string ProductId => CallAsString("getProductId");

        public virtual int PriceType => Call<int>("getPriceType");

        public virtual string Price => CallAsString("getPrice");

        public virtual long MicrosPrice => Call<long>("getMicrosPrice");

        public virtual string OriginalLocalPrice => CallAsString("getOriginalLocalPrice");

        public virtual long OriginalMicroPrice => Call<long>("getOriginalMicroPrice");

        public virtual string Currency => CallAsString("getCurrency");

        public virtual string ProductName => CallAsString("getProductName");

        public virtual string ProductDesc => CallAsString("getProductDesc");

        public virtual string SubPeriod => CallAsString("getSubPeriod");

        public virtual string SubSpecialPrice => CallAsString("getSubSpecialPrice");

        public virtual long SubSpecialPriceMicros => Call<long>("getSubSpecialPriceMicros");

        public virtual string SubSpecialPeriod => CallAsString("getSubSpecialPeriod");

        public virtual int SubSpecialPeriodCycles => Call<int>("getSubSpecialPeriodCycles");

        public virtual string SubFreeTrialPeriod => CallAsString("getSubFreeTrialPeriod");

        public virtual string SubGroupId => CallAsString("getSubGroupId");

        public virtual string SubGroupTitle => CallAsString("getSubGroupTitle");

        public virtual int SubProductLevel => Call<int>("getSubProductLevel");

    }

}