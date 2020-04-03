using System;
using UnityEngine;
using HuaweiMobileServices.Base;

namespace HuaweiMobileServices.Base
{

    internal static class TypeConverter
    {
        public static T AsType<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapperByConstructor =>
            Activator.CreateInstance(typeof(T), javaObject) as T;
    }
}
