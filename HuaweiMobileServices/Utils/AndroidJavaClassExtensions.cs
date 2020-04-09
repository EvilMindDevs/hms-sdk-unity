namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    internal static class AndroidJavaClassExtensions
    {
        public static T CallStaticAsWrapper<T>(this AndroidJavaClass javaClass, string methodName, params object[] args) where T : JavaObjectWrapper =>
            javaClass.CallStatic<AndroidJavaObject>(methodName, args).AsWrapper<T>();

    }
}
