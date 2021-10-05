namespace HuaweiMobileServices.IAP
{
    using UnityEngine;

    public static class SignAlgorithmConstant
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.iap.entity.SignAlgorithmContant");

        public static string SIGNATURE_ALGORITHM_SHA256WITHRSA_PSS = sJavaClass.GetStatic<string>("SIGNATURE_ALGORITHM_SHA256WITHRSA_PSS");
    }
}
