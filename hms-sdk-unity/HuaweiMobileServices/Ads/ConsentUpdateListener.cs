namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;
    using static HuaweiMobileServices.Ads.Consent;

    // Wrapper for com.huawei.hms.ads.consent.inter.ConsentUpdateListener
    internal class ConsentUpdateListener : JavaObjectWrapper
    {

        private class ConsentUpdateListenerInterfaceWrapper : AndroidJavaProxy
        {

            private readonly IConsentUpdateListener mListener;

            public ConsentUpdateListenerInterfaceWrapper(IConsentUpdateListener listener) : base("org.m0skit0.android.hms.unity.ads.ConsentUpdateListener")
            {
                mListener = listener;
            }

            public void onFail(string desc)
            {
                mListener.OnFail(desc);
            }

            public void onSuccess(ConsentStatus consentStatus, bool isNeedConsent, List<AdProvider> adProviders)
            {
                mListener.OnSuccess(consentStatus, isNeedConsent, adProviders);
            }
        }

        public ConsentUpdateListener(IConsentUpdateListener listener)
            : base("org.m0skit0.android.hms.unity.ads.ConsentUpdateListenerWrapper", new ConsentUpdateListenerInterfaceWrapper(listener)) { }

    }

}