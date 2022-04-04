using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class Consent : JavaObjectWrapper
    {
        public Consent(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.ads.consent.inter.Consent");

        public static Consent GetInstance() => javaClass.CallStaticAsWrapper<Consent>("getInstance", AndroidContext.ApplicationContext);

        public void AddTestDeviceId(string testDeviceId) => Call("addTestDeviceId", testDeviceId);

        public string GetTestDeviceId => Call<string>("getTestDeviceId");

        public void RequestConsentUpdate(IConsentUpdateListener listener) => Call("requestConsentUpdate", listener);

        public void SetConsentStatus(ConsentStatus consentStatus) => Call("setConsentStatus", consentStatus);

        public void SetDebugNeedConsent(DebugNeedConsent debugNeedConsent) => Call("setDebugNeedConsent", debugNeedConsent);

        public void SetUnderAgeOfPromise(bool underAgeOfPromise) => Call("setUnderAgeOfPromise", underAgeOfPromise);

        //com.huawei.hms.ads.consent.constant.ConsentStatus
        public enum ConsentStatus : int
        {
            PERSONALIZED = 0,
            NON_PERSONALIZED = 1,
            UNKNOWN = 2
        }

        //com.huawei.hms.ads.consent.constant.DebugNeedConsent
        public enum DebugNeedConsent : int
        {
            DEBUG_DISABLED = 0,
            DEBUG_NEED_CONSENT = 1,
            DEBUG_NOT_NEED_CONSENT = 2
        }

    }
}
