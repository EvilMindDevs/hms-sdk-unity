namespace HuaweiMobileServices.Ads.InstallReferrer
{
    using HuaweiMobileServices.Utils;

    using UnityEngine;

    public class InstallReferrerClient : JavaObjectWrapper
    {
        public InstallReferrerClient(AndroidJavaObject javaObject) : base(javaObject) { }
        public InstallReferrerClient() : base("com.huawei.hms.ads.installreferrer.api.InstallReferrerClient") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ads.installreferrer.api.InstallReferrerClient");

        public void EndConnection() => Call("endConnection");

        public bool IsReady() => Call<bool>("isReady");

        public void StartConnection(InstallReferrerStateListener listener) => Call("startConnection", listener);

        public ReferrerDetails GetInstallReferrer() => CallAsWrapper<ReferrerDetails>("getInstallReferrer");

        public static Builder NewBuilder() => sJavaClass.CallStaticAsWrapper<Builder>("newBuilder", AndroidContext.ActivityContext);

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.huawei.hms.ads.installreferrer.api.InstallReferrerClient$Builder") { }
            public Builder SetTest(bool isTest) => CallAsWrapper<Builder>("setTest", isTest);
            public InstallReferrerClient Build() => CallAsWrapper<InstallReferrerClient>("build");
        }
    }
}