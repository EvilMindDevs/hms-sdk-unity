using HuaweiMobileServices.Utils;
using HuaweiMobileServices.Base;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    // Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseResult
    public class ConsumeOwnedPurchaseResult : JavaObjectWrapperByConstructor
    {

        internal ConsumeOwnedPurchaseResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string ConsumePurchaseData
        {
            get => mJavaObject.Call<AndroidJavaObject>("getConsumePurchaseData").AsString();
        }


        public virtual string DataSignature
        {
            get => mJavaObject.Call<AndroidJavaObject>("getDataSignature").AsString();
        }


        public virtual int ReturnCode
        {
            get => mJavaObject.Call<int>("getReturnCode");
        }


        public virtual string ErrMsg
        {
            get => mJavaObject.Call<AndroidJavaObject>("getErrMsg").AsString();
        }

    }

}