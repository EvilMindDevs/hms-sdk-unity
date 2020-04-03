using System;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{

    internal static class TypeWrapper
    {
        public static T AsWrapper<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapperByConstructor =>
            Activator.CreateInstance(typeof(T), javaObject) as T;
    }
}
