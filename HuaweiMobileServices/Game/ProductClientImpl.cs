namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;

    // Wrapper for com.huawei.hms.jos.product.ProductClientImpl
    public class ProductClientImpl : JavaObjectWrapper, IProductClient
    {

        internal ProductClientImpl(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual ITask<IList<ProductOrderInfo>> GetMissProductOrder()
        {
            var javaResult = JavaObject.Call<AndroidJavaObject>("getMissProductOrder", AndroidContext.GetActivityContext());
            return new TaskWrapper<IList<ProductOrderInfo>>(javaResult, AndroidTypes.AsListFromWrappable<ProductOrderInfo>);
        }
    }

}