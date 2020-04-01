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
                var javaList = mJavaObject.Call<AndroidJavaObject>("getProductIds");
                var objectList = AndroidTypes.GetList<AndroidJavaObject>(javaList);
                return ListUtils.Map<AndroidJavaObject, string>(objectList, (javaObject) => {
                    return AndroidTypes.GetString(javaObject);
                });
            }
            set
            {
                var objectList = ListUtils.Map<string, AndroidJavaObject>(value, (valueString) => {
                    return AndroidTypes.GetString(valueString);
                });
                var javaList = AndroidTypes.GetList<AndroidJavaObject>(objectList);
                mJavaObject.Call<AndroidJavaObject>("setProductIds", javaList);
            }
        }


    }

}