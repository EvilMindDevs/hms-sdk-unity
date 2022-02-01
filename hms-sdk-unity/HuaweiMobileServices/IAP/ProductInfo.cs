namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.ProductInfo
    public class ProductInfo : JavaObjectWrapper
    {
        
        public ProductInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public string ProductId => CallAsString("getProductId");

        public PriceType PriceType => new PriceType(Call<int>("getPriceType"));

        public string Price => CallAsString("getPrice");

        public long MicrosPrice => Call<long>("getMicrosPrice");

        public string OriginalLocalPrice => CallAsString("getOriginalLocalPrice");

        public long OriginalMicroPrice => Call<long>("getOriginalMicroPrice");

        public string Currency => CallAsString("getCurrency");

        public string ProductName => CallAsString("getProductName");

        public string ProductDesc => CallAsString("getProductDesc");

        public string SubPeriod => CallAsString("getSubPeriod");

        public string SubSpecialPrice => CallAsString("getSubSpecialPrice");

        public long SubSpecialPriceMicros => Call<long>("getSubSpecialPriceMicros");

        public string SubSpecialPeriod => CallAsString("getSubSpecialPeriod");

        public int SubSpecialPeriodCycles => Call<int>("getSubSpecialPeriodCycles");

        public string SubFreeTrialPeriod => CallAsString("getSubFreeTrialPeriod");

        public string SubGroupId => CallAsString("getSubGroupId");

        public string SubGroupTitle => CallAsString("getSubGroupTitle");

        public int SubProductLevel => Call<int>("getSubProductLevel");

        public int Status => Call<int>("getStatus");

        public int GetOfferUsedStatus => Call<int>("getOfferUsedStatus");

        public void SetOfferUsedStatus(int offerUsedStatus) => Call("setOfferUsedStatus", offerUsedStatus);

    }

}