using System.Collections.Generic;

namespace com.huawei.hms.jos.product
{
    using Context = android.content.Context;
    using HuaweiApiInterface = com.huawei.hms.common.HuaweiApiInterface;

    public interface IProductClient : HuaweiApiInterface
    {
        Task<IList<ProductOrderInfo>> GetMissProductOrder(Context paramContext);
    }

}