namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    // Wrapper for android.accounts.Account
    public class AndroidAccount : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AndroidAccount(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual AndroidJavaObject Account => JavaObject;

    }
}
