using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class AdProvider : JavaObjectWrapper
    {
        public AdProvider(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.ads.consent.bean.AdProvider");

        public string GetId => Call<string>("getId");

        public string GetName => Call<string>("getName");

        public string GetPrivacyPolicyUrl => Call<string>("getPrivacyPolicyUrl");

        public string GetServiceArea => Call<string>("getServiceArea(");

        public void SetId(string id) => Call("setId", id);

        public void SetName(string name) => Call("setName", name);

        public void SetPrivacyPolicyUrl(string privacyPolicyUrl) => Call("setPrivacyPolicyUrl", privacyPolicyUrl);

        public void SetServiceArea(string serviceArea) => Call("setServiceArea", serviceArea);

    }
}