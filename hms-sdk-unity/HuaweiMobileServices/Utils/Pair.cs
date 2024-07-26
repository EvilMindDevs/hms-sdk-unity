using System;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    // For now, this work just primitive types
    public class Pair<K, V> : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.util.Pair";

        public Pair(AndroidJavaObject javaObject) : base(javaObject) { }

        public Pair(K first, V second)
            : base(CLASS_NAME, first.ToJavaObject(), second.ToJavaObject()) { }

        public K First => JavaObject.Get<AndroidJavaObject>("first").FromJavaObject<K>();
        public V Second => JavaObject.Get<AndroidJavaObject>("second").FromJavaObject<V>();

        public static Pair<K, V> Create(K first, V second)
        {
            using (var pair = new AndroidJavaClass(CLASS_NAME))
            {
                return new Pair<K, V>(pair.CallStatic<AndroidJavaObject>("create", first.ToJavaObject(), second.ToJavaObject()));
            }
        }

        public override string ToString()
        {
            return Call<string>("toString");
        }

        public static Pair<K, V> FromJavaObject(AndroidJavaObject javaObject)
        {
            if (javaObject == null) return null;

            K first = javaObject.Get<AndroidJavaObject>("first").FromJavaObject<K>();
            V second = javaObject.Get<AndroidJavaObject>("second").FromJavaObject<V>();

            return new Pair<K, V>(first, second);
        }

        public Tuple<K,V> ToTuple() => new Tuple<K, V>(First, Second);

    }
}
