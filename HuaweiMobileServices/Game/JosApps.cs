namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

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