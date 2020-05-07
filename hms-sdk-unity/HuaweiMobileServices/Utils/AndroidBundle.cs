namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidBundle : JavaObjectWrapper
    {
        public AndroidBundle(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Bundle => JavaObject;
    }
}
