using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class AdProvider : JavaObjectWrapper
    {
        public AdProvider(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.ads.consent.bean.AdProvider");

        public string Id
        {
            get => Call<string>("getId");
            set => Call("setId", value);
        }

        public string Name
        {
            get => Call<string>("getName");
            set => Call("setName", value);
        }

        public string PrivacyPolicyUrl
        {
            get => Call<string>("getPrivacyPolicyUrl");
            set => Call("setPrivacyPolicyUrl", value);
        }

        public string ServiceArea
        {
            get => Call<string>("getServiceArea");
            set => Call("setServiceArea", value);
        }

    }
}