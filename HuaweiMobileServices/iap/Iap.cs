using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    public class Iap
    {

        private static AndroidJavaClass mIapClass = new AndroidJavaClass("com.huawei.hms.iap.Iap");

        private Iap() { }

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
        }
    }
}