using UnityEngine;
using HuaweiMobileServices.Utils;

namespace com.huawei.hms.iap.entity
{
    // Wrapper for com.huawei.hms.iap.entity.ProductInfo
    public class ProductInfo
    {

        private readonly AndroidJavaObject mJavaObject;

        ProductInfo(AndroidJavaObject javaObject)
        {
            mJavaObject = javaObject;
        }

        public virtual string ProductId
        {
            get => mJavaObject.Call<AndroidJavaObject>("getProductId").AsString();
        }


        public virtual int PriceType
        {
            get => mJavaObject.Call<int>("getPriceType");
        }


        public virtual string Price
        {
            get => mJavaObject.Call<AndroidJavaObject>("getPrice").AsString();
        }


        public virtual long MicrosPrice
        {
            get => mJavaObject.Call<long>("getMicrosPrice");
        }


        public virtual string OriginalLocalPrice
        {
            get => mJavaObject.Call<AndroidJavaObject>("getOriginalLocalPrice").AsString();
        }


        public virtual long OriginalMicroPrice
        {
            get => mJavaObject.Call<long>("getOriginalMicroPrice");
        }


        public virtual string Currency
        {
            get => mJavaObject.Call<AndroidJavaObject>("getCurrency").AsString();
        }


        public virtual string ProductName
        {
            get => mJavaObject.Call<AndroidJavaObject>("getProductName").AsString();
        }


        public virtual string ProductDesc
        {
            get => mJavaObject.Call<AndroidJavaObject>("getProductDesc").AsString();
        }


        public virtual string SubPeriod
        {
            get => mJavaObject.Call<AndroidJavaObject>("getSubPeriod").AsString();
        }


        public virtual string SubSpecialPrice
        {
            get => mJavaObject.Call<AndroidJavaObject>("getSubSpecialPrice").AsString();
        }


        public virtual long SubSpecialPriceMicros
        {
            get => mJavaObject.Call<long>("getSubSpecialPriceMicros");
        }


        public virtual string SubSpecialPeriod
        {
            get => mJavaObject.Call<AndroidJavaObject>("getSubSpecialPeriod").AsString();
        }


        public virtual int SubSpecialPeriodCycles
        {
            get => mJavaObject.Call<int>("getSubSpecialPeriodCycles");
        }


        public virtual string SubFreeTrialPeriod
        {
            get => mJavaObject.Call<AndroidJavaObject>("getSubFreeTrialPeriod").AsString();
        }


        public virtual string SubGroupId
        {
            get => mJavaObject.Call<AndroidJavaObject>("getSubGroupId").AsString();
        }


        public virtual string SubGroupTitle
        {
            get => mJavaObject.Call<AndroidJavaObject>("getSubGroupTitle").AsString();
        }


        public virtual int SubProductLevel
        {
            get => mJavaObject.Call<int>("getSubProductLevel");
        }

    }

}