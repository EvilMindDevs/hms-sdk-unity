namespace HuaweiMobileServices.IAP
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class StartIapActivityResult : JavaObjectWrapper
    {
        
        public StartIapActivityResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public StartIapActivityResult(AndroidIntent intent) : base("com.huawei.hms.iap.entity.StartIapActivityResult", intent) { }

        public void StartActivity()
        {
            Call("startActivity", AndroidContext.ActivityContext);
        }

    }
}
