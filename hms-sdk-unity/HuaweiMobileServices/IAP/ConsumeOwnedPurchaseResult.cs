namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseResult
    public class ConsumeOwnedPurchaseResult : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public ConsumeOwnedPurchaseResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string ConsumePurchaseData
        {
            get => CallAsString("getConsumePurchaseData");
        }


        public virtual string DataSignature
        {
            get => CallAsString("getDataSignature");
        }


        public virtual int ReturnCode
        {
            get => Call<int>("getReturnCode");
        }


        public virtual string ErrMsg
        {
            get => CallAsString("getErrMsg");
        }

    }

}