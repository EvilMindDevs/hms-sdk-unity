namespace HuaweiMobileServices.Utils
{
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
            JavaObject = new AndroidJavaObject(javaObjectCanonicalName, args.AsAutoParams());
        }

        internal protected virtual AndroidJavaObject JavaObject { get; set; }

        internal protected T Call<T>(string methodName, params object[] args) => JavaObject.Call<T>(methodName, args.AsAutoParams());

        internal protected void Call(string methodName, params object[] args) => JavaObject.Call(methodName, args.AsAutoParams());

        internal protected string CallAsString(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsString();

        internal protected T CallAsWrapper<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsWrapper<T>();

        internal protected string CallAsUriString(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.Call<AndroidJavaObject>("toString")?.AsString();

        internal protected IList<T> CallAsWrapperList<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsListFromWrappable<T>();

        internal protected T[] CallAsWrapperArray<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsArray<T>();
    }
}
