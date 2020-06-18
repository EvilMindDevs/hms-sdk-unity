namespace HuaweiMobileServices.IAP
{

    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.ProductInfoResult
    public class ProductInfoResult : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public ProductInfoResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode => Call<int>("getReturnCode");

        public virtual string ErrMsg => CallAsString("getErrMsg");

        public virtual IList<ProductInfo> ProductInfoList =>
            Call<AndroidJavaObject>("getProductInfoList").AsListFromWrappable<ProductInfo>();

    }

}