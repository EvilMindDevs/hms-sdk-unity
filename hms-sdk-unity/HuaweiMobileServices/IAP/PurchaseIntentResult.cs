namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Base;
    using UnityEngine;

    public class PurchaseIntentResult : Result
    {

        [UnityEngine.Scripting.Preserve]
        public PurchaseIntentResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode => Call<int>("getReturnCode");

        public virtual string ErrMsg => CallAsString("getErrMsg");

        public virtual string PaymentData => CallAsString("getPaymentData");

        public virtual string PaymentSignature => CallAsString("getPaymentSignature");

    }

}