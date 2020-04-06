using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.IAP
{

    public class PurchaseIntentReq : JavaObjectWrapper
    {

        public PurchaseIntentReq() : base("com.huawei.hms.iap.entity.PurchaseIntentReq") { }

        public virtual string DeveloperPayload
        {
            get => Call<AndroidJavaObject>("getDeveloperPayload").AsString();
            set => Call("setDeveloperPayload", value.AsJavaString());
        }

        public virtual int PriceType
        {
            get => Call<int>("getPriceType");
            set => Call("setPriceType", value);
        }

        public virtual string ProductId
        {
            get => Call<AndroidJavaObject>("getProductId").AsString();
            set => Call("setProductId", value.AsJavaString());
        }

    }
}
