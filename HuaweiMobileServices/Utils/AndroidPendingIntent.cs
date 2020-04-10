namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidPendingIntent : JavaObjectWrapper
    {
        public AndroidPendingIntent(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Intent => JavaObject;
    }
}
