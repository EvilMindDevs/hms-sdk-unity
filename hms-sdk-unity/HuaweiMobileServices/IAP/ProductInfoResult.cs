namespace HuaweiMobileServices.IAP
{

    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.ProductInfoResult
    public class ProductInfoResult : JavaObjectWrapper
    {

        public ProductInfoResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => Call<int>("getReturnCode");
        }


        public virtual string ErrMsg
        {
            get => Call<AndroidJavaObject>("getErrMsg").AsString();
        }


        public virtual IList<ProductInfo> ProductInfoList
        {
            get => Call<AndroidJavaObject>("getProductInfoList")
                    .AsListFromWrappable<ProductInfo>();
        }

    }

}