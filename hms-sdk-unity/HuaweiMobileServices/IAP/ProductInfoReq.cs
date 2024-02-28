namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.PriceType
    public class ProductInfoReq : BaseReq
    {

        public ProductInfoReq() : base("com.huawei.hms.iap.entity.ProductInfoReq") { }

        public virtual PriceType PriceType
        {
            get => new PriceType(Call<int>("getPriceType"));
            set => Call("setPriceType", value.Value);
        }

        public virtual IList<string> ProductIds
        {
            get => Call<AndroidJavaObject>("getProductIds").AsStringList();
            set => Call("setProductIds", value.AsJavaStringList());
        }

    }

}