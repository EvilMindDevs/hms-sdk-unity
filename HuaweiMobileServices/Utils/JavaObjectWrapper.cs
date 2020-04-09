namespace HuaweiMobileServices.Utils
{
    using System.Collections.Generic;
    using UnityEngine;

    public class JavaObjectWrapper
    {
        internal protected JavaObjectWrapper(AndroidJavaObject javaObject)
        {
            JavaObject = javaObject;
        }

        internal protected JavaObjectWrapper(string javaObjectCanonicalName, params object[] args)
        {
            JavaObject = new AndroidJavaObject(javaObjectCanonicalName, args);
        }

        internal protected AndroidJavaObject JavaObject { get; set; }

        internal protected T Call<T>(string methodName, params object[] args) => JavaObject.Call<T>(methodName, args);

        internal protected void Call(string methodName, params object[] args) => JavaObject.Call(methodName, args);

        internal protected string CallAsString(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args).AsString();

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
