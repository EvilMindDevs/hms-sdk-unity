using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.Iap
    public static class Iap
    {

        private static AndroidJavaClass mIapClass = new AndroidJavaClass("com.huawei.hms.iap.Iap");

        public static IapClient GetIapClient()
        {
            AndroidJavaObject iapClient = mIapClass.CallStatic<AndroidJavaObject>("getIapClient", AndroidContext.GetActivityContext());
            return new IapClientWrapper(iapClient);
        }

        private class IapClientWrapper : IapClient
        {

            private readonly AndroidJavaObject mIapClientJava;

            public IapClientWrapper(AndroidJavaObject iapClientJava)
            {
                mIapClientJava = iapClientJava;
            }

            public Task<ProductInfoResult> ObtainProductInfo(ProductInfoReq productInfoReq)
            {
                var javaTask = mIapClientJava.Call<AndroidJavaObject>("obtainProductInfo", productInfoReq.ProductInfoReqJava);
                return new Task<ProductInfoResult>(javaTask);
            }
                
        }
    }
}