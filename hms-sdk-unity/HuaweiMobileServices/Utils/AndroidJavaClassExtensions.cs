namespace HuaweiMobileServices.Utils
{
    using System;
    using System.Collections.Generic;
    using UnityEngine;

    internal static class AndroidJavaClassExtensions
    {
        private static readonly Dictionary<string, object> cache = new Dictionary<string, object>();

        public static T CallStaticAsWrapper<T>(this AndroidJavaClass javaClass, string methodName, params object[] args) where T : JavaObjectWrapper =>
            javaClass.CallStatic<AndroidJavaObject>(methodName, args.AsAutoParams()).AsWrapper<T>();

        public static string CallStaticAsString(this AndroidJavaClass javaClass, string methodName, params object[] args) =>
            javaClass.CallStatic<AndroidJavaObject>(methodName, args.AsAutoParams()).AsString();

        public static T[] GetStaticAsArray<T>(this AndroidJavaClass javaClass, string fieldName) where T : JavaObjectWrapper =>
            javaClass.GetStatic<AndroidJavaObject>(fieldName).AsArray<T>();

        public static T GetStaticAsWrapper<T>(this AndroidJavaClass javaClass, string fieldName) where T : JavaObjectWrapper =>
            javaClass.GetStatic<AndroidJavaObject>(fieldName).AsWrapper<T>();

        public static T[] GetAsArray<T>(this AndroidJavaClass javaClass, string fieldName) where T : JavaObjectWrapper =>
            javaClass.Get<AndroidJavaObject>(fieldName).AsArray<T>();

        public static T GetStaticFieldCached<T>(this AndroidJavaClass javaClass, string fieldName)
        {
            if (cache.TryGetValue(fieldName, out var value))
            {
                return (T)value;
            }

            T fieldValue = javaClass.GetStatic<T>(fieldName);
            cache[fieldName] = fieldValue;
            return fieldValue;
        }


        public static void CallOnMainThread(this AndroidJavaProxy proxy, Action action)
        {
            if (!HMSDispatcher.InstanceExists)
                HMSDispatcher.CreateDispatcher();
            HMSDispatcher.InvokeAsync(action);
        }
    }
}
