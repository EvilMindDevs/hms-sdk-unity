namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class JavaObjectWrapper
    {
        private AndroidJavaObject mJavaObject;

        internal protected JavaObjectWrapper(AndroidJavaObject javaObject)
        {
            mJavaObject = javaObject;
        }

        internal protected JavaObjectWrapper(string javaObjectCanonicalName, params object[] args)
        {
            mJavaObject = new AndroidJavaObject(javaObjectCanonicalName, args);
        }

        internal protected AndroidJavaObject JavaObject {
            get => mJavaObject;
            set => mJavaObject = value;
        }

        internal protected T Call<T>(string methodName, params object[] args) => Call<T>(methodName, args);

        internal protected void Call(string methodName, params object[] args) => Call(methodName, args);

        internal protected string CallAsString(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args).AsString();

        internal protected T CallAsWrapper<T>(string methodName, params object[] args) where T : JavaObjectWrapper =>
            Call<AndroidJavaObject>(methodName, args).AsWrapper<T>();

        internal protected string CallAsUriString(string methodName, params object[] args) =>
            Call<AndroidJavaObject>(methodName, args).Call<AndroidJavaObject>("toString").AsString();
    }
}
