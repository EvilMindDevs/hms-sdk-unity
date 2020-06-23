namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class EnvReadyResult : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public static EnvReadyResult NewInstance(AndroidJavaObject javaObject) => new EnvReadyResult(javaObject);

        public EnvReadyResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int ReturnCode
        {
            get => Call<int>("getReturnCode");
        }
    }
}
