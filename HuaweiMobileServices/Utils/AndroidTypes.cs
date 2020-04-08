namespace HuaweiMobileServices.Utils
{
    using HuaweiMobileServices.Base;
    using System.Collections.Generic;
    using UnityEngine;

    internal static class AndroidTypes
    {

        public static AndroidJavaObject AsJavaString(this string value) => new AndroidJavaObject("java.lang.String", value);

        public static string AsString(this AndroidJavaObject javaString) => javaString.Call<string>("toString");

        public static AndroidJavaObject AsJavaList<T>(this IList<T> list)
        {
            var javaList = new AndroidJavaObject("java.util.ArrayList");
            foreach (T element in list)
            {
                javaList.Call("add", element);
            }
            return javaList;
        }

        public static AndroidJavaObject AsJavaListFromJavaObjectWrapper<T>(this IList<T> list) where T : JavaObjectWrapper =>
            list.Map((javaWrapper) => javaWrapper.JavaObject).AsJavaList();

        public static IList<T> AsList<T>(this AndroidJavaObject javaList)
        {
            var list = new List<T>();
            int size = javaList.Call<int>("size");
            for (int i = 0; i < size; i++)
            {
                var element = javaList.Call<T>("get", i);
                list.Add(element);
            }
            return list;
        }

        public static IList<string> AsStringList(this AndroidJavaObject javaList) =>
            javaList.AsList<AndroidJavaObject>().Map((javaObject) => javaObject.AsString());

        public static AndroidJavaObject AsJavaStringList(this IList<string> list) =>
           list.Map((aString) => aString.AsJavaString()).AsJavaList();

        public static System.Exception AsException(this AndroidJavaObject javaException) =>
            new HMSException(javaException.Call<AndroidJavaObject>("getMessage").AsString());

        public static AndroidJavaObject AsJavaSet<T>(this ISet<T> set)
        {
            var javaSet = new AndroidJavaObject("java.util.HashSet");
            foreach (T element in set)
            {
                javaSet.Call("add", element);
            }
            return javaSet;
        }

        public static AndroidJavaObject AsJavaSetFromJavaObjectWrapper<T>(this ISet<T> set) where T : JavaObjectWrapper =>
            set.Map((javaWrapper) => javaWrapper.JavaObject).AsJavaSet();

        public static ISet<T> AsSet<T>(this AndroidJavaObject javaSet)
        {
            var list = new AndroidJavaObject("java.util.ArrayList", javaSet).AsList<T>();
            return new HashSet<T>(list);
        }
    }
}
