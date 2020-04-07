using System.Collections.Generic;

namespace com.huawei.hms.jos.product
{
    using Context = android.content.Context;
    using IHuaweiApiInterface = com.huawei.hms.common.IHuaweiApiInterface;

    public interface IProductClient : IHuaweiApiInterface
    {
        Task<IList<ProductOrderInfo>> GetMissProductOrder(Context paramContext);
    }

}