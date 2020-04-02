using System.Collections.Generic;
using UnityEngine;
using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.IAP
{

    // Wrapper for com.huawei.hms.iap.entity.ProductInfoResult
    public class ProductInfoResult
    {

        private readonly AndroidJavaObject mJavaObject;

        internal ProductInfoResult(AndroidJavaObject javaObject)
        {
            mJavaObject = javaObject;
        }

        public virtual int ReturnCode
        {
            get
            {
                return mJavaObject.Call<int>("getReturnCode");
            }
        }


        public virtual string ErrMsg
        {
            get
            {
                var javaString = mJavaObject.Call<AndroidJavaObject>("getErrMsg");
                return AndroidTypes.GetString(javaString);
            }
        }


        public virtual IList<ProductInfo> ProductInfoList
        {
            get
            {
                return this.productInfoList;
            }
        }

    }

}