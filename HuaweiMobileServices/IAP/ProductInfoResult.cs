using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    // Wrapper for com.huawei.hms.iap.entity.ProductInfoResult
    public class ProductInfoResult : JavaObjectWrapper
    {

        internal ProductInfoResult(AndroidJavaObject javaObject) : base(javaObject) { }

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
                    .AsList<AndroidJavaObject>()
                    .Map((javaObject) => new ProductInfo(javaObject));
        }

    }

}