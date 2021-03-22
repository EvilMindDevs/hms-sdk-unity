namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class StartIapActivityResult : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public StartIapActivityResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public StartIapActivityResult(AndroidIntent intent) : base("com.huawei.hms.iap.entity.StartIapActivityResult", intent) { }

    }
}
