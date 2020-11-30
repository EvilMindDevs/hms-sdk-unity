using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public static class DictionaryOperations
    {
        private static readonly AndroidJavaClass sJavaArrays = new AndroidJavaClass("java.util.Arrays");

        public static AndroidJavaObject DictionaryToAndroidJavaObject(IDictionary<String, System.Object> dictionary)
        {
            AndroidJavaObject javaMap = new AndroidJavaObject("java.util.HashMap");
            IntPtr putMethod = AndroidJNIHelper.GetMethodID(
                javaMap.GetRawClass(), "put",
                    "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");

            object[] args = new object[2];
            foreach (KeyValuePair<String, System.Object> kvp in dictionary)
            {
                using (AndroidJavaObject k = new AndroidJavaObject(
                    "java.lang.String", kvp.Key))
                {
                    using (AndroidJavaObject v = new AndroidJavaObject(
                        "java.lang.String", kvp.Value))
                    {
                        args[0] = k;
                        args[1] = v;
                        AndroidJNI.CallObjectMethod(javaMap.GetRawObject(),
                                putMethod, AndroidJNIHelper.CreateJNIArgArray(args));
                    }
                }
            }
            return javaMap;
        }

        public static Dictionary<String, System.Object> XMLtoDictionary(String xmlPath)
        {
            var textFile = Resources.Load<TextAsset>(xmlPath);
            XElement rootElement = XElement.Parse(textFile.text);
            Dictionary<String, System.Object> dictionary = new Dictionary<String, System.Object>();

            foreach (var el in rootElement.Elements())
            {
                dictionary.Add(el.Attribute("key").Value, el.Value);
            }

            return dictionary;
        }

        public static Dictionary<String, System.Object> AndroidJavaObjectToDictionary(AndroidJavaObject javaList)
        {
            if (javaList == null || javaList.Call<int>("size") == 0) return null;

            Dictionary<String, System.Object> dictionary = new Dictionary<String, System.Object>();
            var keyList = javaList.Call<AndroidJavaObject>("keySet").AsStringSet();
            foreach(var key in keyList)
            {
                dictionary.Add(key, javaList.Call<string>("get", key));
            }
            return dictionary;
        }

    }
}