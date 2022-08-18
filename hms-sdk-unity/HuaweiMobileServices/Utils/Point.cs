
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class Point : JavaObjectWrapper
    {
        public Point(AndroidJavaObject javaObject) : base(javaObject) { }
        public Point() : base("android.graphics.Point") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("android.graphics.Point");
    }
}