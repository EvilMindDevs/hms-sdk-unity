namespace com.huawei.hms.jos.product
{
    using System.Collections.Generic;
    using HuaweiMobileServices.Base;

    // Wrapper for com.huawei.hms.jos.product.IProductClient
    public interface IProductClient : IHuaweiApiInterface
    {
        ITask<IList<ProductOrderInfo>> GetMissProductOrder(Context paramContext);
    }

}