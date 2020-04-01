using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{
    // Wrapper for com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq
    public class ConsumeOwnedPurchaseReq
    {

        private AndroidJavaObject mJavaObject = new AndroidJavaObject("com.huawei.hms.iap.entity.ConsumeOwnedPurchaseReq");

        public virtual string PurchaseToken
        {
            set
            {
                mJavaObject.Call("setPurchaseToken", AndroidTypes.GetString(value));
            }
            get
            {
                var value = mJavaObject.Call<AndroidJavaObject>("getPurchaseToken");
                return AndroidTypes.GetString(value);
            }
        }

        public virtual string DeveloperChallenge
        {
            set
            {
                mJavaObject.Call("setDeveloperChallenge", AndroidTypes.GetString(value));
            }
            get
            {
                var value = mJavaObject.Call<AndroidJavaObject>("getDeveloperChallenge");
                return AndroidTypes.GetString(value);
            }
        }

    }

}