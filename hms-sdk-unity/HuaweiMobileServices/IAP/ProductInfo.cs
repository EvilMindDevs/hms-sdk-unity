namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.ProductInfo
    public class ProductInfo : JavaObjectWrapper
    {
        public ProductInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string ProductId
        {
            get => Call<AndroidJavaObject>("getProductId").AsString();
        }

        public virtual int PriceType
        {
            get => Call<int>("getPriceType");
        }

        public virtual string Price
        {
            get => Call<AndroidJavaObject>("getPrice").AsString();
        }

        public virtual long MicrosPrice
        {
            get => Call<long>("getMicrosPrice");
        }

        public virtual string OriginalLocalPrice
        {
            get => Call<AndroidJavaObject>("getOriginalLocalPrice").AsString();
        }

        public virtual long OriginalMicroPrice
        {
            get => Call<long>("getOriginalMicroPrice");
        }

        public virtual string Currency
        {
            get => Call<AndroidJavaObject>("getCurrency").AsString();
        }

        public virtual string ProductName
        {
            get => Call<AndroidJavaObject>("getProductName").AsString();
        }

        public virtual string ProductDesc
        {
            get => Call<AndroidJavaObject>("getProductDesc").AsString();
        }

        public virtual string SubPeriod
        {
            get => Call<AndroidJavaObject>("getSubPeriod").AsString();
        }

        public virtual string SubSpecialPrice
        {
            get => Call<AndroidJavaObject>("getSubSpecialPrice").AsString();
        }

        public virtual long SubSpecialPriceMicros
        {
            get => Call<long>("getSubSpecialPriceMicros");
        }

        public virtual string SubSpecialPeriod
        {
            get => Call<AndroidJavaObject>("getSubSpecialPeriod").AsString();
        }

        public virtual int SubSpecialPeriodCycles
        {
            get => Call<int>("getSubSpecialPeriodCycles");
        }

        public virtual string SubFreeTrialPeriod
        {
            get => Call<AndroidJavaObject>("getSubFreeTrialPeriod").AsString();
        }

        public virtual string SubGroupId
        {
            get => Call<AndroidJavaObject>("getSubGroupId").AsString();
        }

        public virtual string SubGroupTitle
        {
            get => Call<AndroidJavaObject>("getSubGroupTitle").AsString();
        }

        public virtual int SubProductLevel
        {
            get => Call<int>("getSubProductLevel");
        }

    }

}