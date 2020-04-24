namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Id;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.JosApps
    public static class JosApps
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.jos.JosApps");

        public static IJosAppsClient GetJosAppsClient(AuthHuaweiId authHuaweiId)
        {
            var josAppsClient = sJavaClass.CallStatic<AndroidJavaObject>(
                    "getJosAppsClient",
                    AndroidContext.ActivityContext,
                    authHuaweiId.JavaObject
                );
            return new JosAppsClientWrapper(josAppsClient);
        }

        public static IProductClient GetProductClient()
        {
            var productClient = sJavaClass.CallStatic<AndroidJavaObject>("getProductClient", AndroidContext.ApplicationContext);
            return new ProductClientWrapper(productClient);
        }
    }

}