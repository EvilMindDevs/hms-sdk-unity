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