using UnityEngine;
using System.Collections.Generic;

namespace HuaweiMobileServices.Utils
{
    static class AndroidTypes
    {

        public static AndroidJavaObject AsJavaString(this string value)
        {
            return new AndroidJavaObject("java.lang.String", value);
        }

        public static string AsString(this AndroidJavaObject javaString)
        {
            return javaString.Call<string>("toString");
        }

        public static AndroidJavaObject AsJavaList<T>(this IList<T> list)
        {
            var javaList = new AndroidJavaObject("java.util.ArrayList");
            foreach(T element in list)
            {
                javaList.Call("add", element);
            }
            return javaList;
        }

        public static IList<T> AsList<T>(this AndroidJavaObject javaList)
        {
            var list = new List<T>();
            int size = javaList.Call<int>("size");
            for(int i = 0; i < size; i++)
            {
                var element = javaList.Call<T>("get", i);
                list.Add(element);
            }
            return list;
        }
    }
}
