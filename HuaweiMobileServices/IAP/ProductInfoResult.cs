using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    // Wrapper for com.huawei.hms.iap.entity.ProductInfoResult
    public class ProductInfoResult : JavaObjectWrapperByConstructor
    {

        internal ProductInfoResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => mJavaObject.Call<int>("getReturnCode");
        }


        public virtual string ErrMsg
        {
            get => mJavaObject.Call<AndroidJavaObject>("getErrMsg").AsString();
        }


        public virtual IList<ProductInfo> ProductInfoList
        {
            get => mJavaObject.Call<AndroidJavaObject>("getProductInfoList")
                    .AsList<AndroidJavaObject>()
                    .Map<AndroidJavaObject, ProductInfo>((javaObject) => new ProductInfo(javaObject));
        }

    }

}