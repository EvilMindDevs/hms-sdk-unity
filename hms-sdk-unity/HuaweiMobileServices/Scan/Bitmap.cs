using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices
{
    public class Bitmap : JavaObjectWrapper
    {
        public Bitmap(AndroidJavaObject javaObject) : base(javaObject) { }
        public Bitmap() : base("android.graphics.Bitmap") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("android.graphics.Bitmap");
    }
}