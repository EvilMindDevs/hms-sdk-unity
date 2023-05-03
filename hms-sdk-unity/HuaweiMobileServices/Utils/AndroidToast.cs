namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    //https://developer.android.com/reference/android/widget/Toast
    public class AndroidToast : JavaObjectWrapper
    {
        public AndroidToast(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidToast() : base("android.widget.Toast", AndroidContext.ActivityContext) { }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("android.widget.Toast");

        public static implicit operator AndroidJavaObject(AndroidToast toast) => toast.JavaObject;

        public AndroidJavaObject Toast => JavaObject;

        /// <summary>
        /// Show the view or text notification for a short period of time.  This time
        /// could be user-definable.This is the default. <see cref="SetDuration"/>
        /// </summary>
        public static int LENGTH_SHORT => sJavaClass.Get<int>("LENGTH_SHORT"); //0
        /// <summary>
        /// Show the view or text notification for a long period of time.  This time
        /// could be user-definable. <see cref="SetDuration"/>
        /// </summary>
        public static int LENGTH_LONG => sJavaClass.Get<int>("LENGTH_LONG"); //1

        public static AndroidToast MakeText(string text, int duration = 1) => 
                                sJavaClass.CallStaticAsWrapper<AndroidToast>("makeText", AndroidContext.ActivityContext, text.AsJavaString(), duration);
        public void Show() => Call("show");

    }
}
