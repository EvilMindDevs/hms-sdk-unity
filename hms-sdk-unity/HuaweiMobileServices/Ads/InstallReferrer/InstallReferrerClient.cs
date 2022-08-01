namespace HuaweiMobileServices.Ads.InstallReferrer
{
    using HuaweiMobileServices.Utils;

    using UnityEngine;

    public class InstallReferrerClient : JavaObjectWrapper
    {
        public InstallReferrerClient(AndroidJavaObject javaObject) : base(javaObject) { }
        public InstallReferrerClient() : base("com.huawei.hms.ads.installreferrer.api.InstallReferrerClient") { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.installreferrer.api.InstallReferrerClient");

        public void EndConnection() => Call("endConnection");

        public bool IsReady() => Call<bool>("isReady");

        public void StartConnection(InstallReferrerStateListener listener) => Call("startConnection", listener);

        public ReferrerDetails getInstallReferrer() => CallAsWrapper<ReferrerDetails>("getInstallReferrer");

        public static Builder newBuilder() => sJavaClass.CallStaticAsWrapper<Builder>("newBuilder", AndroidContext.ActivityContext);

        public static bool IsHere => sJavaClass != null;

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.huawei.hms.ads.installreferrer.api.InstallReferrerClient$Builder") { }
            public Builder setTest(bool isTest) => CallAsWrapper<Builder>("setTest", isTest);
            public InstallReferrerClient build() => CallAsWrapper<InstallReferrerClient>("build");
        }
    }
}