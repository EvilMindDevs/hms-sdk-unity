namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidBitmap : JavaObjectWrapper
    {
        public AndroidBitmap(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Bitmap => JavaObject;
    }
}
