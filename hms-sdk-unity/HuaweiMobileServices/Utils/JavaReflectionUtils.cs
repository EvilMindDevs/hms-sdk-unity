namespace HuaweiMobileServices.Utils
{

    using UnityEngine;

    internal static class JavaReflectionUtils
    {

        public static AndroidJavaObject GetJavaClass(this AndroidJavaObject javaObject) =>
            javaObject.Call<AndroidJavaObject>("getClass");

        public static bool InstanceOf(this AndroidJavaObject javaObject, string className) =>
            javaObject.GetJavaClass().Call<bool>("isInstance", className.AsJavaString());

    }
}
