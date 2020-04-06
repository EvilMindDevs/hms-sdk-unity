using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.entity.PriceType
    public class ProductInfoReq
    {

        internal AndroidJavaObject mJavaObject = new AndroidJavaObject("com.huawei.hms.iap.entity.ProductInfoReq");

        public virtual int PriceType
        {
            get => mJavaObject.Call<int>("getPriceType");
            set => mJavaObject.Call("setPriceType", value);
        }

        public virtual IList<string> ProductIds
        {
            get => mJavaObject
                    .Call<AndroidJavaObject>("getProductIds")
                    .AsList<AndroidJavaObject>()
                    .Map((javaObject) => javaObject.AsString());

            set => mJavaObject
                    .Call<AndroidJavaObject>(
                        "setProductIds",
                        value.Map((valueString) => valueString.AsJavaString()).AsJavaList()
                    );
        }

    }

}