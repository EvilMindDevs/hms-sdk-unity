namespace HuaweiMobileServices.Ads
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using System;

    public class SplashAdDisplayListener : JavaObjectWrapper
    {
        private class SplashAdDisplayListenerInterfaceWrapper : AndroidJavaProxy
        {
            private readonly Action m_OnAdShowed;
            private readonly Action m_OnAdClick;

            public SplashAdDisplayListenerInterfaceWrapper(Action onAdShowed, Action onAdClick) : base("org.m0skit0.android.hms.unity.ads.SplashAdDisplayListener")
            {
                m_OnAdShowed = onAdShowed;
                m_OnAdClick = onAdClick;
            }

            public void onAdShowed()
            {
                m_OnAdShowed?.Invoke();
            }

            public void onAdClick()
            {
                m_OnAdClick?.Invoke();
            }
        }

        public SplashAdDisplayListener(Action onAdShowed, Action onAdClick)
           : base("org.m0skit0.android.hms.unity.ads.SplashAdDisplayListenerWrapper", new SplashAdDisplayListenerInterfaceWrapper(onAdShowed, onAdClick)) { }
    }
}
