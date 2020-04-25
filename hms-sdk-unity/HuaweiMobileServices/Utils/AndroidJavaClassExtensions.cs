namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    internal static class AndroidJavaClassExtensions
    {
        public static T CallStaticAsWrapper<T>(this AndroidJavaClass javaClass, string methodName, params object[] args) where T : JavaObjectWrapper =>
            javaClass.CallStatic<AndroidJavaObject>(methodName, args.AsAutoParams()).AsWrapper<T>();

        public static string CallStaticAsString(this AndroidJavaClass javaClass, string methodName, params object[] args) =>
            javaClass.CallStatic<AndroidJavaObject>(methodName, args.AsAutoParams()).AsString();

        public static T GetStaticAsWrapper<T>(this AndroidJavaClass javaClass, string fieldName) where T : JavaObjectWrapper =>
            javaClass.GetStatic<AndroidJavaObject>(fieldName).AsWrapper<T>();
    }
}
