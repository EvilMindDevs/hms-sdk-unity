namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    // Wrapper for android.accounts.Account
    public class AndroidAccount : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public static AndroidAccount NewInstance(AndroidJavaObject javaObject) => new AndroidAccount(javaObject);

        public AndroidAccount(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual AndroidJavaObject Account => JavaObject;

    }
}
