using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    static class AndroidTypes
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

        public static System.Exception AsException(this AndroidJavaObject javaException) =>
            new HMSException(javaException.Call<AndroidJavaObject>("getMessage").AsString());
    }
}
