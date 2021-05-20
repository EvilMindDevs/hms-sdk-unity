namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class IsSandboxActivatedResult : JavaObjectWrapper
    {
        
        public IsSandboxActivatedResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => Call<int>("getReturnCode");
        }

        public virtual string ErrMsg
        {
            get => Call<string>("getErrMsg");
        }

        public virtual bool SandboxUser
        {
            get => Call<bool>("getIsSandboxUser");
        }

        public virtual bool SandboxApk
        {
            get => Call<bool>("getIsSandboxApk");
        }

        public virtual string VersionInApk
        {
            get => Call<string>("getVersionInApk");
        }

        public virtual string VersionFrMarket
        {
            get => Call<string>("getVersionFrMarket");
        }
    }
}
