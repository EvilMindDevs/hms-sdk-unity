using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    internal static class DictionaryOperations
    {
        internal static AndroidJavaObject AsJavaHashMap(this IDictionary<string, object> dictionary)
        {
            AndroidJavaObject javaMap = new AndroidJavaObject("java.util.HashMap");

            IntPtr putMethod = AndroidJNIHelper.GetMethodID(javaMap.GetRawClass(), "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");

            foreach (KeyValuePair<string, object> kvp in dictionary)
            {
                using (AndroidJavaObject k = new AndroidJavaObject("java.lang.String", kvp.Key))
                {
                    switch (kvp.Value.GetType().ToString())
                    {
                        case "System.String":
                            mapPut(k, kvp, putMethod, javaMap, "java.lang.String");
                            break;
                        case "System.Boolean":
                            mapPut(k, kvp, putMethod, javaMap, "java.lang.Boolean");
                            break;
                        case "System.Int32":
                            mapPut(k, kvp, putMethod, javaMap, "java.lang.Integer");
                            break;
                        case "System.Double":
                            mapPut(k, kvp, putMethod, javaMap, "java.lang.Double");
                            break;
                        case "System.Byte[]":
                            mapPut(k, kvp, putMethod, javaMap, "java.lang.Arrays");
                            break;
                        default:
                            Console.WriteLine("RemoteConfig: Unknown type");
                            break;
                    }
                }
            }
            return javaMap;
        }

        private static void mapPut(AndroidJavaObject k, KeyValuePair<string, object> kvp, IntPtr putMethod, AndroidJavaObject javaMap, string obje)
        {
            try
            {
                object[] args = new object[2];
                using (AndroidJavaObject v = new AndroidJavaObject(obje, kvp.Value))
                {
                    args[0] = k;
                    args[1] = v;
                    AndroidJNI.CallObjectMethod(javaMap.GetRawObject(),putMethod, AndroidJNIHelper.CreateJNIArgArray(args));
                }
            }
            catch (Exception e)
            {
                Debug.Log($"RemoteConfig, AsJavaHashMap Error {e.Message}");
            }
        }

        internal static Dictionary<string, object> XMLtoDictionary(String xmlPath)
        {
            var textFile = Resources.Load<TextAsset>(xmlPath);
            XElement rootElement = XElement.Parse(textFile.text);
            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            foreach (var el in rootElement.Elements())
            {
                dictionary.Add(el.Attribute("key").Value, el.Value);
            }
            return dictionary;
        }

        internal static Dictionary<string, object> AsDictionary(this AndroidJavaObject javaList)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();

            if (javaList == null || javaList.Call<int>("size") == 0) return dictionary;

            var keyList = javaList.Call<AndroidJavaObject>("keySet").AsStringSet();
            foreach(var key in keyList)
            {
                dictionary.Add(key, javaList.Call<string>("get", key));
            }
            return dictionary;
        }

    }
}