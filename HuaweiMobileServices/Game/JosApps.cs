namespace com.huawei.hms.jos
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using AuthHuaweiId = com.huawei.hms.support.hwid.result.AuthHuaweiId;
    using IProductClient = com.huawei.hms.jos.product.IProductClient;
    using ProductClientImpl = com.huawei.hms.jos.product.ProductClientImpl;

    // Wrapper for com.huawei.hms.jos.JosApps
    public sealed class JosApps
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.jos.JosApps");

        public static IJosAppsClient GetJosAppsClient(Activity activity, AuthHuaweiId authHuaweiId)
        {
            var josAppsClient = sJavaClass.CallStatic<AndroidJavaObject>(
                    "getJosAppsClient",
                    AndroidContext.GetActivityContext(),

                );
            return josAppsClient;
        }

        public static IProductClient GetProductClient(Context paramContext)
        {
            Checker.assertNonNull(paramContext);
            return new ProductClientImpl(paramContext);
        }
    }

}