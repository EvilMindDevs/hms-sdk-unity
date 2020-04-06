using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class JavaObjectWrapper
    {
        private AndroidJavaObject mJavaObject;

        internal protected JavaObjectWrapper(AndroidJavaObject javaObject)
        {
            mJavaObject = javaObject;
        }

        internal protected JavaObjectWrapper(string javaObjectCanonicalName)
        {
            mJavaObject = new AndroidJavaObject(javaObjectCanonicalName);
        }

        internal protected AndroidJavaObject JavaObject {
            get => mJavaObject;
            set => mJavaObject = value;
        }

        internal protected T Call<T>(string methodName, params object[] args) => Call<T>(methodName, args);

        internal protected void Call(string methodName, params object[] args) => Call(methodName, args);
    }
}
