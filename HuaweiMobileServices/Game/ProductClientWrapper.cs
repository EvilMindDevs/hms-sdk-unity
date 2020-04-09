namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.product.ProductClientImpl
    public class ProductClientWrapper : JavaObjectWrapper, IProductClient
    {

        public ProductClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual ITask<IList<ProductOrderInfo>> GetMissProductOrder()
        {
            var javaResult = Call<AndroidJavaObject>("getMissProductOrder", AndroidContext.GetActivityContext());
            return new TaskWrapper<IList<ProductOrderInfo>>(javaResult, AndroidTypes.AsListFromWrappable<ProductOrderInfo>);
        }
    }

}