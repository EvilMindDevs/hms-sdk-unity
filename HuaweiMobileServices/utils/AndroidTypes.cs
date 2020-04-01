using UnityEngine;
using System.Collections.Generic;

namespace HuaweiMobileServices.Utils
{
    public class AndroidTypes
    {

        private AndroidTypes() { }

        public static AndroidJavaObject GetString(string value)
        {
            return new AndroidJavaObject("java.lang.String", value);
        }

        public static string GetString(AndroidJavaObject javaString)
        {
            return javaString.Call<string>("toString");
        }

        public static AndroidJavaObject GetList<T>(IList<T> list)
        {
            var javaList = new AndroidJavaObject("java.util.ArrayList");
            foreach(T element in list)
            {
                javaList.Call("add", element);
            }
            return javaList;
        }

        public static IList<T> GetList<T>(AndroidJavaObject javaList)
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
