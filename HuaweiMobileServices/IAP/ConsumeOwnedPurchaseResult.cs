using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    // Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseResult
    public class ConsumeOwnedPurchaseResult : JavaObjectWrapper
    {

        internal ConsumeOwnedPurchaseResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string ConsumePurchaseData
        {
            get => Call<AndroidJavaObject>("getConsumePurchaseData").AsString();
        }


        public virtual string DataSignature
        {
            get => Call<AndroidJavaObject>("getDataSignature").AsString();
        }


        public virtual int ReturnCode
        {
            get => Call<int>("getReturnCode");
        }


        public virtual string ErrMsg
        {
            get => Call<AndroidJavaObject>("getErrMsg").AsString();
        }

    }

}