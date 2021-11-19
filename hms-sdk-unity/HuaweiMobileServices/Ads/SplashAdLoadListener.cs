using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;

namespace HuaweiMobileServices.Ads
{
    public class SplashAdLoadListener : JavaObjectWrapper
    {
        private class SplashAdLoadListenerInterfaceWrapper : AndroidJavaProxy
        {
            private readonly Action m_OnAdDismissed;
            private readonly Action<int> m_OnAdFailedToLoad;
            private readonly Action m_OnAdLoaded;

            public SplashAdLoadListenerInterfaceWrapper(Action onAdDismissed, Action<int> onAdFailedToLoad, Action onAdLoaded) : base("org.m0skit0.android.hms.unity.ads.SplashAdLoadListener")
            {
                m_OnAdDismissed = onAdDismissed;
                m_OnAdFailedToLoad = onAdFailedToLoad;
                m_OnAdLoaded = onAdLoaded;
            }

            public void onAdDismissed()
            {
                m_OnAdDismissed?.Invoke();
            }

            public void onAdFailedToLoad(int errorCode)
            {
                m_OnAdFailedToLoad?.Invoke(errorCode);
            }

            public void onAdLoaded()
            {
                m_OnAdLoaded?.Invoke();
            }
        }

        public SplashAdLoadListener(Action onAdDismissed, Action<int> onAdFailedToLoad, Action onAdLoaded)
          : base("org.m0skit0.android.hms.unity.ads.SplashAdLoadListenerWrapper", new SplashAdLoadListenerInterfaceWrapper(onAdDismissed, onAdFailedToLoad, onAdLoaded)) { }
    }
}
