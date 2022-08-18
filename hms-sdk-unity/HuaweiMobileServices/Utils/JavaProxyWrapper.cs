namespace HuaweiMobileServices.Utils
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    public abstract class JavaProxyWrapper
    {

        public JavaProxyWrapper(AndroidJavaProxy javaProxy)
        {
            JavaProxy = javaProxy;
            HMSDispatcher.CreateDispatcher();
        }

        internal protected JavaProxyWrapper(string javaInterface)
        {
            JavaProxy = new AndroidJavaProxy(javaInterface);
            HMSDispatcher.CreateDispatcher();
        }

        internal protected virtual AndroidJavaProxy JavaProxy { get; set; }

        internal protected AndroidJavaObject Invoke(string methodName, params object[] args) => JavaProxy.Invoke(methodName, args.AsAutoParams());
        internal protected AndroidJavaObject Invoke(string methodName, AndroidJavaObject[] javaArgs) => JavaProxy.Invoke(methodName, javaArgs.AsAutoParams());
        internal protected bool Equals(AndroidJavaObject obj) => JavaProxy.equals(obj);
    }
}
