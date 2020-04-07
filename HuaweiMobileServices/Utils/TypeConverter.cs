namespace HuaweiMobileServices.Utils
{
    using System;
    using UnityEngine;

    internal static class TypeWrapper
    {
        public static T AsWrapper<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapper =>
            Activator.CreateInstance(typeof(T), javaObject) as T;
    }
}
