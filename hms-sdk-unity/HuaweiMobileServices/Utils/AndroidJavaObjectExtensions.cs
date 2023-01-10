using System;
using System.Collections.Generic;

namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    internal static class AndroidJavaObjectExtensions
    {

        private static readonly AndroidJavaClass sJavaArrays = new AndroidJavaClass("java.util.Arrays");

        public static T AsWrapper<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapper =>
            Activator.CreateInstance(typeof(T), javaObject) as T;

        public static AndroidJavaObject AsJavaString(this string value) => new AndroidJavaObject("java.lang.String", value);

        public static string AsString(this AndroidJavaObject javaString) => javaString?.Call<string>("toString");

        public static int AsInt(this AndroidJavaObject javaInt) => javaInt.Call<int>("intValue");

        public static bool AsBool(this AndroidJavaObject javaBool) => javaBool.Call<bool>("booleanValue");

        public static AndroidJavaObject AsJavaList<T>(this IList<T> list)
        {
            if (list == null) return null;
            var javaList = new AndroidJavaObject("java.util.ArrayList");
            foreach (T element in list)
            {
                javaList.Call<bool>("add", element);
            }
            return javaList;
        }

        public static AndroidJavaObject AsJavaListFromWrapper<T>(this IList<T> list) where T : JavaObjectWrapper =>
            list?.Map((javaWrapper) => javaWrapper.JavaObject).AsJavaList();

        public static IList<T> AsList<T>(this AndroidJavaObject javaList)
        {
            if (javaList == null) return null;
            var list = new List<T>();
            int size = javaList.Call<int>("size");
            for (int i = 0; i < size; i++)
            {
                var element = javaList.Call<T>("get", i);
                list.Add(element);
            }
            return list;
        }
        public static long? AsLong(this AndroidJavaObject javaLongObject)
        {
            if (javaLongObject == null)
                return null;
            return javaLongObject.Call<long>("longValue");
        }

        public static double? AsDouble(this AndroidJavaObject javaLongObject)
        {
            if (javaLongObject == null)
                return null;
            return javaLongObject.Call<double>("doubleValue");
        }

        public static IList<T> AsListFromWrappable<T>(this AndroidJavaObject javaList) where T : JavaObjectWrapper =>
            javaList?.AsList<AndroidJavaObject>().Map(AsWrapper<T>);

        public static IList<string> AsStringList(this AndroidJavaObject javaList) =>
            javaList?.AsList<AndroidJavaObject>().Map(AsString);

        public static IList<int> AsIntList(this AndroidJavaObject javaList) =>
          javaList?.AsList<AndroidJavaObject>().Map(AsInt);

        public static AndroidJavaObject AsJavaStringList(this IList<string> list) => list?.Map(AsJavaString).AsJavaList();

        public static HMSException AsException(this AndroidJavaObject javaException) => new HMSException(javaException);

        public static AndroidJavaObject AsJavaException(this HMSException hMSException) 
        {
            AndroidJavaClass javaClass = new AndroidJavaClass("java.lang.Exception");
            return javaClass.Call<AndroidJavaObject>("Exception", hMSException.Message);
        }

        public static AndroidJavaObject AsJavaSet<T>(this ISet<T> set)
        {
            if (set == null) return null;
            var javaSet = new AndroidJavaObject("java.util.HashSet");
            foreach (T element in set)
            {
                javaSet.Call<bool>("add", element);
            }
            return javaSet;
        }

        public static AndroidJavaObject AsJavaSetFromWrapper<T>(this ISet<T> set) where T : JavaObjectWrapper =>
            set?.Map((javaWrapper) => javaWrapper.JavaObject).AsJavaSet();

        public static ISet<T> AsSet<T>(this AndroidJavaObject javaSet)
        {
            if (javaSet == null) return null;
            var list = new AndroidJavaObject("java.util.ArrayList", javaSet).AsList<T>();
            return new HashSet<T>(list);
        }

        public static ISet<T> AsSetFromWrappable<T>(this AndroidJavaObject javaSet) where T : JavaObjectWrapper =>
            javaSet?.AsSet<AndroidJavaObject>().Map(AsWrapper<T>);

        public static ISet<string> AsStringSet(this AndroidJavaObject javaSet)
        {
            if (javaSet == null) return null;
            var list = new AndroidJavaObject("java.util.ArrayList", javaSet).AsStringList();
            return new HashSet<string>(list);
        }

        public static AndroidJavaObject AsJavaArray<T>(this T[] array, Func<T, AndroidJavaObject> converter)
        {
            if (array == null) return null;
            return new List<T>(array)
                .Map(converter)
                .AsJavaList()
                .Call<AndroidJavaObject>("toArray");
        }

        public static AndroidJavaObject AsJavaArray<T>(this T[] array)
        {
            if (array == null) return null;
            return new List<T>(array)
                .AsJavaList()
                .Call<AndroidJavaObject>("toArray");
        }

        public static AndroidJavaObject AsJavaArrayFromWrapper<T>(this T[] array) where T : JavaObjectWrapper
        {
            if (array == null) return null;
            return new List<T>(array)
                .Map((element) => element.JavaObject)
                .AsJavaList()
                .Call<AndroidJavaObject>("toArray");
        }

        public static T[] AsArray<T>(this AndroidJavaObject javaObject) where T : JavaObjectWrapper
        {
            if (javaObject == null) return null;
            var list = sJavaArrays.CallStatic<AndroidJavaObject>("asList", javaObject).AsListFromWrappable<T>();
            var array = new T[list.Count];
            list.CopyTo(array, 0);
            return array;
        }

        public static string[] AsStringArray(this AndroidJavaObject javaObject)
        {
            if (javaObject == null) return null;
            var list = sJavaArrays.CallStatic<AndroidJavaObject>("asList", javaObject).AsStringList();
            var array = new string[list.Count];
            list.CopyTo(array, 0);
            return array;
        }

        public static AndroidJavaObject AsJavaInteger(this int value) => new AndroidJavaObject("java.lang.Integer", value);

        public static AndroidJavaObject AsJavaBoolean(this bool value) => new AndroidJavaObject("java.lang.Boolean", value);

        public static AndroidJavaObject AsJavaLong(this long value) => new AndroidJavaObject("java.lang.Long", value);

        public static AndroidJavaObject AsJavaUri(this string value)
        {
            AndroidJavaClass uriObj = new AndroidJavaClass("android.net.Uri");
            AndroidJavaObject uri = uriObj.CallStatic<AndroidJavaObject>("parse", value);
            return uri;
        }
    }
}