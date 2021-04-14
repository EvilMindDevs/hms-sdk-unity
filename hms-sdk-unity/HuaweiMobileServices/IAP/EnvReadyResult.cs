namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class EnvReadyResult : JavaObjectWrapper
    {
        
        public EnvReadyResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => Call<int>("getReturnCode");
        }

        public virtual int AccountFlag
        {
            get => Call<int>("getAccountFlag");
        }
    }
}
