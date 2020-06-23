namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidBundle : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public static AndroidBundle NewInstance(AndroidJavaObject javaObject) => new AndroidBundle(javaObject);

        public AndroidBundle(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Bundle => JavaObject;
    }
}
