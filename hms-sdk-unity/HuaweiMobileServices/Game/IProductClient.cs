using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;

    // Wrapper for com.huawei.hms.jos.product.ProductClient
    public interface IProductClient
    {
        ITask<IList<ProductOrderInfo>> GetMissProductOrder();
    }

}