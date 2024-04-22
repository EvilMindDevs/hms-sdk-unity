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
            HMSDispatcher.CreateDispatcher();
        }

        internal protected JavaObjectWrapper(string javaObjectCanonicalName, params object[] args)
        {
            JavaObject = new AndroidJavaObject(javaObjectCanonicalName, args.AsAutoParams());
            HMSDispatcher.CreateDispatcher();
        }

        internal protected virtual AndroidJavaObject JavaObject { get; set; }

        internal protected T Call<T>(string methodName, params object[] args) => JavaObject.Call<T>(methodName, args.AsAutoParams());

        internal protected void Call(string methodName, params object[] args) => JavaObject.Call(methodName, args.AsAutoParams());

        internal protected T CallStatic<T>(string methodName, params object[] args) => JavaObject.CallStatic<T>(methodName, args.AsAutoParams());

        internal protected void CallStatic(string methodName, params object[] args) => JavaObject.CallStatic(methodName, args.AsAutoParams());

        internal protected void Get<T>(string methodName) => JavaObject.Get<T>(methodName);

        internal protected void GetStatic<T>(string methodName) => JavaObject.GetStatic<T>(methodName);

        internal protected void CallOnMainThread(Action action) => HMSDispatcher.InvokeAsync(action);

        internal protected string CallAsString(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsString();
        
        internal protected int CallAsInt(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsInt();

        internal protected long? CallAsLong(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsLong();

        internal protected bool CallAsBool(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams()).AsBool();

        internal protected string[] CallAsStringArray(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsStringArray();

        internal protected IList<int> CallAsIntList(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsIntList();
            
        internal protected IList<string> CallAsStringList(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsStringList();

        internal protected T CallAsWrapper<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsWrapper<T>();

        internal protected string CallAsUriString(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.Call<AndroidJavaObject>("toString")?.AsString();

        internal protected IList<T> CallAsWrapperList<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsListFromWrappable<T>();

        internal protected IList<T> CallStaticAsWrapperList<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
          JavaObject.CallStatic<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsListFromWrappable<T>();

        internal protected T[] CallAsWrapperArray<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args.AsAutoParams())?.AsArray<T>();
    }
}
