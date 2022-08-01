namespace HuaweiMobileServices.Ads.InstallReferrer
{
    using HuaweiMobileServices.Utils;

    using UnityEngine;

    public class InstallReferrerStateBridge : JavaObjectWrapper
    {
        public InstallReferrerStateBridge(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.ads.installreferrer.bridge.InstallReferrerStateBridge");
        public static InstallReferrerStateListener GetInstallReferrerStateCallback() => javaClass.CallStaticAsWrapper<InstallReferrerStateListener>("getInstallReferrerStateListener");
        public static void SetInstallReferrerCallbackListener(InstallReferrerStateCallbackListener listener) => javaClass.CallStatic("setInstallReferrerCallbackListener", listener.JavaObject);
    }
}