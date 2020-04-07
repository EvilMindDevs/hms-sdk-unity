namespace com.huawei.hms.jos
{
    using Activity = android.app.Activity;
    using AuthHuaweiId = com.huawei.hms.support.hwid.result.AuthHuaweiId;
    using b = com.huawei.hms.jos.games.a.b;
    using Checker = com.huawei.hms.utils.Checker;
    using Context = android.content.Context;
    using IProductClient = com.huawei.hms.jos.product.IProductClient;
    using ProductClientImpl = com.huawei.hms.jos.product.ProductClientImpl;

    public sealed class JosApps
    {
        public static JosAppsClient GetJosAppsClient(Activity paramActivity, AuthHuaweiId paramAuthHuaweiId)
        {
            Checker.assertNonNull(paramActivity);
            b.a().a(paramActivity);
            return new a(paramActivity, paramAuthHuaweiId);
        }

        public static IAppUpdateClient GetAppUpdateClient(Activity paramActivity)
        {
            Checker.assertNonNull(paramActivity);
            b.a().a(paramActivity);
            return new AppUpdateClientImpl(paramActivity);
        }

        public static IAppUpdateClient GetAppUpdateClient(Context paramContext)
        {
            Checker.assertNonNull(paramContext);
            return new AppUpdateClientImpl(paramContext);
        }

        public static IProductClient GetProductClient(Context paramContext)
        {
            Checker.assertNonNull(paramContext);
            return new ProductClientImpl(paramContext);
        }
    }

}