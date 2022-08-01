namespace HuaweiMobileServices.Ads.InstallReferrer
{
    using HuaweiMobileServices.Utils;

    using UnityEngine;

    public class InstallReferrerStateListener : JavaObjectWrapper
    {
        public InstallReferrerStateListener(AndroidJavaObject javaObject) : base(javaObject) { }

        private class InstallReferrerStateCallbackInterface : AndroidJavaProxy
        {
            private readonly IInstallReferrerStateCallback mListener;

            public InstallReferrerStateCallbackInterface(IInstallReferrerStateCallback listener) : base("org.m0skit0.android.hms.unity.ads.installreferrer.bridge.InstallReferrerStateCallbackListener")
            {
                mListener = listener;
            }

            public void OnInstallReferrerSetupFinished(int responseCode)
            {
                this.CallOnMainThread(() => { mListener.onInstallReferrerSetupFinished(responseCode); });
            }

            public void OnInstallReferrerServiceDisconnected()
            {
                this.CallOnMainThread(() => { mListener.onInstallReferrerServiceDisconnected(); });
            }
        }

        public InstallReferrerStateListener(IInstallReferrerStateCallback listener)
       : base("org.m0skit0.android.hms.unity.ads.installreferrer.bridge.InstallReferrerStateCallbackWrapper", new InstallReferrerStateCallbackInterface(listener)) { }
    }

}