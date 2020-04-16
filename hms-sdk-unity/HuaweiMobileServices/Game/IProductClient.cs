namespace HuaweiMobileServices.Game
{
    using System.Collections.Generic;
    using HuaweiMobileServices.Base;

    // Wrapper for com.huawei.hms.jos.product.ProductClient
    public interface IProductClient
    {
        ITask<IList<ProductOrderInfo>> GetMissProductOrder();
    }

}