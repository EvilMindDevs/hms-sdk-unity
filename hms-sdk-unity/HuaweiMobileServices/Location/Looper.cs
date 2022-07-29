using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location
{
    public class Looper : JavaObjectWrapper
    {
        public Looper(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("android.os.Looper");

        public static Looper GetMainLooper() => javaClass.CallStaticAsWrapper<Looper>("getMainLooper");

    }
}
