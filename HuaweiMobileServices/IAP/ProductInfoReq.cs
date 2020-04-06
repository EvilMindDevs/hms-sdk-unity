using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.entity.PriceType
    public class ProductInfoReq : JavaObjectWrapper
    {

        public ProductInfoReq() : base("com.huawei.hms.iap.entity.ProductInfoReq") { }

        public virtual int PriceType
        {
            get => Call<int>("getPriceType");
            set => Call("setPriceType", value);
        }

        public virtual IList<string> ProductIds
        {
            get => Call<AndroidJavaObject>("getProductIds").AsStringList();
            set => Call<AndroidJavaObject>("setProductIds", value.AsJavaStringList());
        }

    }

}