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

        public string TestDeviceId => Call<string>("getTestDeviceId");

        public void RequestConsentUpdate(IConsentUpdateListener listener) => Call("requestConsentUpdate", new ConsentUpdateListener(listener));

        public void SetConsentStatus(ConsentStatusWrapper consentStatus) => Call("setConsentStatus", consentStatus);

        public void SetDebugNeedConsent(DebugNeedConsentWrapper debugNeedConsent) => Call("setDebugNeedConsent", debugNeedConsent);

        public void SetUnderAgeOfPromise(bool underAgeOfPromise) => Call("setUnderAgeOfPromise", underAgeOfPromise);

    }

    //com.huawei.hms.ads.consent.constant.ConsentStatus
    public class ConsentStatusWrapper : JavaObjectWrapper
    {
        public ConsentStatusWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.ads.consent.constant.ConsentStatus");

        public int Value => Call<int>("getValue");

        public static ConsentStatusWrapper ForValue(int value) => javaClass.CallStaticAsWrapper<ConsentStatusWrapper>("forValue", value);
    }

    public enum ConsentStatus : int
    {
        PERSONALIZED = 0,
        NON_PERSONALIZED = 1,
        UNKNOWN = 2
    }

    //com.huawei.hms.ads.consent.constant.DebugNeedConsent
    public class DebugNeedConsentWrapper : JavaObjectWrapper
    {
        public DebugNeedConsentWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.ads.consent.constant.DebugNeedConsent");

        public int Value => Call<int>("getValue");

        public static DebugNeedConsentWrapper ForValue(int value) => javaClass.CallStaticAsWrapper<DebugNeedConsentWrapper>("forValue", value);
    }

    public enum DebugNeedConsent : int
    {
        DEBUG_DISABLED = 0,
        DEBUG_NEED_CONSENT = 1,
        DEBUG_NOT_NEED_CONSENT = 2
    }
}
