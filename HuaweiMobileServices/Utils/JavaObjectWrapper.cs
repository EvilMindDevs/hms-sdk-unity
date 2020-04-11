namespace HuaweiMobileServices.Utils
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class JavaObjectWrapper
    {

        public JavaObjectWrapper(AndroidJavaObject javaObject)
        {
            JavaObject = javaObject;
        }

        internal protected JavaObjectWrapper(string javaObjectCanonicalName, params object[] args)
        {
            JavaObject = new AndroidJavaObject(javaObjectCanonicalName, args);
        }

        private static object[] AsAutoParams(object[] args)
        {
            var newArgs = new object[args.Length];
            for (int i = 0; i < args.Length; i++)
            {
                newArgs[i] = AsAutoType(args[i]);
            }
            return newArgs;
        }

        private static object AsAutoType(object arg)
        {
            if (arg is JavaObjectWrapper) return (arg as JavaObjectWrapper).JavaObject;
            if (arg is string) return (arg as string).AsJavaString();
            return arg;
        }

        private T AsAutoType<T>(object arg) where T : class
        {
            if (typeof(T).Equals(typeof(JavaObjectWrapper))) return Activator.CreateInstance(typeof(T), arg) as T;
            if (typeof(T).Equals(typeof(string))) return (arg as AndroidJavaObject).AsString() as T;
            return arg as T;
        }

        internal protected virtual AndroidJavaObject JavaObject { get; set; }

        internal protected T CallAuto<T>(string methodName, params object[] args) where T : class
        {
            var result = Call<T>(methodName, args);
            return AsAutoType<T>(result);
        }

        // Consider using CallAuto instead
        internal protected T Call<T>(string methodName, params object[] args) => JavaObject.Call<T>(methodName, AsAutoParams(args));

        internal protected void Call(string methodName, params object[] args) => JavaObject.Call(methodName, AsAutoParams(args));

        // Use CallAuto instead
        [Obsolete]
        internal protected string CallAsString(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args).AsString();

        // Use CallAuto instead
        [Obsolete]
        internal protected T CallAsWrapper<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args).AsWrapper<T>();

        internal protected string CallAsUriString(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args).Call<AndroidJavaObject>("toString").AsString();

        internal protected IList<T> CallAsWrapperList<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args).AsListFromWrappable<T>();

        internal protected T[] CallAsWrapperArray<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args).AsArray<T>();
    }
}
