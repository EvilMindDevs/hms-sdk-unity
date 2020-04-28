namespace HuaweiMobileServices.Utils
{
    using HuaweiMobileServices.Base;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using UnityEngine;

    internal static class AndroidJavaObjectExtensions
    {

        private static readonly AndroidJavaClass sArrays = new AndroidJavaClass("java.util.Arrays");

        public static T AsWrapper<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapper =>
            Activator.CreateInstance(typeof(T), javaObject) as T;

        public static AndroidJavaObject AsJavaString(this string value) => new AndroidJavaObject("java.lang.String", value);

        public static string AsString(this AndroidJavaObject javaString) => javaString.Call<string>("toString");

        public static AndroidJavaObject AsJavaList<T>(this IList<T> list)
        {
            var javaList = new AndroidJavaObject("java.util.ArrayList");
            foreach (T element in list)
            {
                javaList.Call<bool>("add", element);
            }
            return javaList;
        }

        public static AndroidJavaObject AsJavaListFromWrapper<T>(this IList<T> list) where T : JavaObjectWrapper =>
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

        public static IList<T> AsListFromWrappable<T>(this AndroidJavaObject javaList) where T : JavaObjectWrapper =>
            javaList.AsList<AndroidJavaObject>().Map((javaObject) => javaObject.AsWrapper<T>());

        public static IList<string> AsStringList(this AndroidJavaObject javaList) =>
            javaList.AsList<AndroidJavaObject>().Map((javaObject) => javaObject.AsString());

        public static AndroidJavaObject AsJavaStringList(this IList<string> list) =>
           list.Map((aString) => aString.AsJavaString()).AsJavaList();

        public static HMSException AsException(this AndroidJavaObject javaException) => new HMSException(javaException);

        public static AndroidJavaObject AsJavaSet<T>(this ISet<T> set)
        {
            var javaSet = new AndroidJavaObject("java.util.HashSet");
            foreach (T element in set)
            {
                javaSet.Call<bool>("add", element);
            }
            return javaSet;
        }

        public static AndroidJavaObject AsJavaSetFromWrapper<T>(this ISet<T> set) where T : JavaObjectWrapper =>
            set.Map((javaWrapper) => javaWrapper.JavaObject).AsJavaSet();

        public static ISet<T> AsSet<T>(this AndroidJavaObject javaSet)
        {
            var list = new AndroidJavaObject("java.util.ArrayList", javaSet).AsList<T>();
            return new HashSet<T>(list);
        }

        public static ISet<string> AsStringSet(this AndroidJavaObject javaSet)
        {
            var list = new AndroidJavaObject("java.util.ArrayList", javaSet).AsStringList();
            return new HashSet<string>(list);
        }

        public static AndroidJavaObject AsJavaArray<T>(this T[] array, Func<T, AndroidJavaObject> converter) =>
            new List<T>(array)
                .Map(converter)
                .AsJavaList<AndroidJavaObject>()
                .Call<AndroidJavaObject>("toArray");

        public static AndroidJavaObject AsJavaArrayFromWrapper<T>(this T[] array) where T : JavaObjectWrapper =>
            new List<T>(array)
                .Map((element) => element.JavaObject)
                .AsJavaList<AndroidJavaObject>()
                .Call<AndroidJavaObject>("toArray");

        public static T[] AsArray<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapper
        {
            var list = sArrays.CallStatic<AndroidJavaObject>("asList", javaObject).AsListFromWrappable<T>();
            var array = new T[list.Count];
            list.CopyTo(array, 0);
            return array;
        }
    }
}
