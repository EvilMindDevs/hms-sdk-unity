namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.product.ProductClientImpl
    public class ProductClientWrapper : JavaObjectWrapper, IProductClient
    {

        [UnityEngine.Scripting.Preserve]
        public ProductClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual ITask<IList<ProductOrderInfo>> GetMissProductOrder()
        {
            var javaResult = Call<AndroidJavaObject>("getMissProductOrder", AndroidContext.ActivityContext);
            return new TaskWrapper<IList<ProductOrderInfo>>(javaResult, AndroidJavaObjectExtensions.AsListFromWrappable<ProductOrderInfo>);
        }
    }

}