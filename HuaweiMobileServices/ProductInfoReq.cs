using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.entity.PriceType
    public class ProductInfoReq
    {

        private AndroidJavaObject mJavaObject = new AndroidJavaObject("com.huawei.hms.iap.entity.ProductInfoReq");

        public virtual int PriceType
        {
            get
            {
                return mJavaObject.Call<int>("getPriceType");
            }
            set
            {
                mJavaObject.Call("setPriceType", value);
            }
        }

        public virtual IList<string> ProductIds
        {
            get
            {
                return mJavaObject
                    .Call<AndroidJavaObject>("getProductIds")
                    .AsList<AndroidJavaObject>()
                    .Map<AndroidJavaObject, string>((javaObject) => {
                        return javaObject.AsString();
                    });
            }
            set
            {
                var javaList =
                    value.Map<string, AndroidJavaObject>((valueString) => {
                        return valueString.AsJavaString();
                    })
                    .AsJavaList();
                mJavaObject.Call<AndroidJavaObject>("setProductIds", javaList);
            }
        }


    }

}