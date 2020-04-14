namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq
    public class ConsumeOwnedPurchaseReq : JavaObjectWrapper
    {

        public ConsumeOwnedPurchaseReq() : base("com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq") { }

        public virtual string PurchaseToken
        {
            set => Call("setPurchaseToken", value.AsJavaString());
            get => Call<AndroidJavaObject>("getPurchaseToken").AsString();
        }

        public virtual string DeveloperChallenge
        {
            set => Call("setDeveloperChallenge", value.AsJavaString());
            get => Call<AndroidJavaObject>("getDeveloperChallenge").AsString();
        }

    }

}