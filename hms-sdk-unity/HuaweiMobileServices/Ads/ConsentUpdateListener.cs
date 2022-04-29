namespace HuaweiMobileServices.Ads
{
    using HuaweiMobileServices.Utils;
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.ads.consent.inter.ConsentUpdateListener
     internal class ConsentUpdateListener : AndroidJavaProxy
        {

            private readonly IConsentUpdateListener mListener;

            public ConsentUpdateListener(IConsentUpdateListener listener) : base("com.huawei.hms.ads.consent.inter.ConsentUpdateListener")
            {
                mListener = listener;
            }

            public void onFail(string desc)
            {
                mListener.OnFail(desc);
            }

            public void onSuccess(AndroidJavaObject consentStatus, bool isNeedConsent, AndroidJavaObject adProviderList)
            {
                mListener.OnSuccess((ConsentStatus)consentStatus.AsWrapper<ConsentStatusWrapper>().Value, isNeedConsent, adProviderList.AsList<AndroidJavaObject>().Map(HelperClass.AsWrapper<AdProvider>));
            }
    }

    static class HelperClass
    {
        public static T AsWrapper<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapper =>
            Activator.CreateInstance(typeof(T), javaObject) as T;
    }
}