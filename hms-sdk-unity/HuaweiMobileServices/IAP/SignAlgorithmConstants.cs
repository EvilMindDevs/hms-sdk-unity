namespace HuaweiMobileServices.IAP
{
    using UnityEngine;

    public static class SignAlgorithmConstants
    {
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.iap.entity.SignAlgorithmConstants");

        public static string SIGNATURE_ALGORITHM_SHA256WITHRSA_PSS = sJavaClass.GetStatic<string>("SIGNATURE_ALGORITHM_SHA256WITHRSA_PSS");
    }
}
