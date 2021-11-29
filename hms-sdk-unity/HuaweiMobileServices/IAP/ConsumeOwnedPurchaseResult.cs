namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseResult
    public class ConsumeOwnedPurchaseResult : JavaObjectWrapper
    {
        public ConsumeOwnedPurchaseResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public InAppPurchaseData ConsumePurchaseData => new InAppPurchaseData(CallAsString("getConsumePurchaseData"));

        public string ConsumePurchaseDataRaw => CallAsString("getConsumePurchaseData");

        public string DataSignature => CallAsString("getDataSignature");

        public string SignatureAlgorithm => CallAsString("getSignatureAlgorithm");

        public int ReturnCode => Call<int>("getReturnCode");

        public string ErrMsg => CallAsString("getErrMsg");
    }
}