namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidIntent : JavaObjectWrapper
    {
        public AndroidIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Intent => JavaObject;
    }
}
