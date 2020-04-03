using UnityEngine;
using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.IAP
{

    public class OwnedPurchasesReq
    {

        internal readonly AndroidJavaObject mJavaObject = new AndroidJavaObject("com.huawei.hms.iap.entity.OwnedPurchasesReq");

        public virtual string ContinuationToken
        {
            get => mJavaObject.Call<AndroidJavaObject>("getContinuationToken").AsString();
            set => mJavaObject.Call("setContinuationToken", value.AsJavaString());
        }

        public virtual int PriceType
        {
            get => mJavaObject.Call<int>("getPriceType");
            set => mJavaObject.Call("setPriceType", value);
        }
    }

}