using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ScanOption : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public ScanOption(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.ScanOption");

        public Policy Policy => androidJavaClass.Call<Policy>("getPolicy");

        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.discovery.ScanOption$Builder") { }
            public ScanOption Build() => CallAsWrapper<ScanOption>("build");
            public Builder SetPolicy(Policy policy) => CallAsWrapper<Builder>("setPolicy", policy);         }
    }
}