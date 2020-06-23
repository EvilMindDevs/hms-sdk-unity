namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidBitmap : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public static AndroidBitmap NewInstance(AndroidJavaObject javaObject) => new AndroidBitmap(javaObject);

        public AndroidBitmap(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Bitmap => JavaObject;
    }
}
