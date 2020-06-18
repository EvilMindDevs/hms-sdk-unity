namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidBitmap : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AndroidBitmap(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Bitmap => JavaObject;
    }
}
