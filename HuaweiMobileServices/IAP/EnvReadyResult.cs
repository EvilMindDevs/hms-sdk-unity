namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class EnvReadyResult : JavaObjectWrapper
    {

        internal EnvReadyResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => Call<int>("getReturnCode");
        }
    }
}
