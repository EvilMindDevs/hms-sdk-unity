using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq
    public class ConsumeOwnedPurchaseReq
    {

        internal readonly AndroidJavaObject mJavaObject = new AndroidJavaObject("com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq");

        public virtual string PurchaseToken
        {
            set => mJavaObject.Call("setPurchaseToken", value.AsJavaString());
            get => mJavaObject.Call<AndroidJavaObject>("getPurchaseToken").AsString();
        }

        public virtual string DeveloperChallenge
        {
            set => mJavaObject.Call("setDeveloperChallenge", value.AsJavaString());
            get => mJavaObject.Call<AndroidJavaObject>("getDeveloperChallenge").AsString();
        }

    }

}