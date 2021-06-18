namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class IsSandboxActivatedResult : JavaObjectWrapper
    {
        public IsSandboxActivatedResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public int ReturnCode => Call<int>("getReturnCode");

        public string ErrMsg => Call<string>("getErrMsg");

        public bool SandboxUser => CallAsBool("getIsSandboxUser");

        public bool SandboxApk => CallAsBool("getIsSandboxApk");

        public string VersionInApk => Call<string>("getVersionInApk");

        public string VersionFrMarket => Call<string>("getVersionFrMarket");
    }
}
