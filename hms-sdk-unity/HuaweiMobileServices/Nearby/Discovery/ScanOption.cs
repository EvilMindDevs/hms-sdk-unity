using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Discovery
{
    public class ScanOption : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public ScanOption(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.discovery.ScanOption");

        public bool Equals(JavaObjectWrapper javaObject) => androidJavaClass.Call<bool>("equals", javaObject);
        public Policy Policy => androidJavaClass.Call<Policy>("getPolicy");
        public int HashCode => androidJavaClass.Call<int>("hashCode");
        public void WriteToParce(Parcel dest, int flags) => androidJavaClass.Call("writeToParcel", dest, flags);
        public int DescribeContents => androidJavaClass.Call<int>("describeContents");
        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.discovery.ScanOption$Builder") { }
            public ScanOption Build() => CallAsWrapper<ScanOption>("build");
            public Builder SetPolicy(Policy policy)
            {
                JavaObject = Call<AndroidJavaObject>("setPolicy", policy);
                return this;
            }

        }
    }
}