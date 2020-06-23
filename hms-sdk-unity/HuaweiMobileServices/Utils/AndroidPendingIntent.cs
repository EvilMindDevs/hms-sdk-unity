namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidPendingIntent : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public static AndroidPendingIntent NewInstance(AndroidJavaObject javaObject) => new AndroidPendingIntent(javaObject);

        public AndroidPendingIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Intent => JavaObject;
    }
}
