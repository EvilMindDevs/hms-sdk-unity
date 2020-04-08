namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using HuaweiMobileServices.Id;

    // Wrapper for com.huawei.hms.jos.JosApps
    public static class JosApps
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.jos.JosApps");

        public static IJosAppsClient GetJosAppsClient(AuthHuaweiId authHuaweiId)
        {
            var josAppsClient = sJavaClass.CallStatic<AndroidJavaObject>(
                    "getJosAppsClient",
                    AndroidContext.GetActivityContext(),
                    authHuaweiId.JavaObject
                );
            return new JosAppsClientWrapper(josAppsClient);
        }

        public static IProductClient GetProductClient()
        {
            var productClient = sJavaClass.CallStatic<AndroidJavaObject>("getProductClient", AndroidContext.GetApplicationContext());
            return new ProductClientImpl(productClient);
        }
    }

}