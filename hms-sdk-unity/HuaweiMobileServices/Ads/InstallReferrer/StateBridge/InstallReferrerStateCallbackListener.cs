namespace HuaweiMobileServices.Ads.InstallReferrer
{
    using HuaweiMobileServices.Utils;

    using System;

    using UnityEngine;

    public class InstallReferrerStateCallbackListener : JavaObjectWrapper
    {
        private class InstallReferrerStateCallbackListenerInterfaceWrapper : AndroidJavaProxy, IInstallReferrerStateCallback
        {

            private readonly Action<int> m_OnInstallReferrerSetupFinished;
            private readonly Action m_OnInstallReferrerServiceDisconnected;

            public InstallReferrerStateCallbackListenerInterfaceWrapper(Action<int> onInstallReferrerSetupFinished, Action onInstallReferrerServiceDisconnected) :
            base("org.m0skit0.android.hms.unity.ads.installreferrer.bridge.InstallReferrerStateCallbackListener")
            {
                m_OnInstallReferrerSetupFinished = onInstallReferrerSetupFinished;
                m_OnInstallReferrerServiceDisconnected = onInstallReferrerServiceDisconnected;
            }

            public void onInstallReferrerServiceDisconnected()
            {
                m_OnInstallReferrerServiceDisconnected?.Invoke();
            }

            public void onInstallReferrerSetupFinished(int responseCode)
            {
                m_OnInstallReferrerSetupFinished?.Invoke(responseCode);
            }
        }

        public InstallReferrerStateCallbackListener
            (Action<int> onInstallReferrerSetupFinished, Action onInstallReferrerServiceDisconnected)
            :
            base
            (
                "org.m0skit0.android.hms.unity.ads.installreferrer.bridge.InstallReferrerStateCallbackWrapper",
                new InstallReferrerStateCallbackListenerInterfaceWrapper(onInstallReferrerSetupFinished, onInstallReferrerServiceDisconnected)
            )
        { }
    }


}