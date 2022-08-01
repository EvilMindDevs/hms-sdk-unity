using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class Map<K, V>: JavaObjectWrapper
    {
        private const string CLASS_NAME = "java.util.Map";

        public Map(AndroidJavaObject javaObject) : base(javaObject) { }

        public Map() : base(CLASS_NAME) { }

        public Map(K arg1, V arg2) : base(CLASS_NAME , arg1, arg2) { }
    }

    public class HashMap<K, V> : JavaObjectWrapper , IMap<K, V>
    {
        private const string CLASS_NAME = "java.util.HashMap";

        public HashMap(AndroidJavaObject javaObject) : base(javaObject) { }

        public HashMap() : base(CLASS_NAME) { }

        public HashMap(K arg1, V arg2) : base(CLASS_NAME, arg1, arg2) { }

        public bool ContainsKey(K key) => Call<bool>("containsKey", key);

        public bool ContainsValue(V value) => Call<bool>("containsValue", value);

        public bool IsEmpty() => Call<bool>("isEmpty()");

        public V Put(K key, V value) => Call<V>("put", key, value);

        public int Size() => Call<int>("size");

        public V Get(K key) => Call<V>("get", key);
    }

    internal class MapListener<K, V> : AndroidJavaProxy
    {

        private readonly IMap<K, V> iMapListener;

        public MapListener(IMap<K, V> iMap) : base("java.util.HashMap")
        {
            iMapListener = iMap;
        }

        public bool ContainsKey(K key) 
        {
           return iMapListener.ContainsKey(key);
        }

        public bool ContainsValue(V value)
        {
            return iMapListener.ContainsValue(value);
        }

        public bool IsEmpty()
        {
            return iMapListener.IsEmpty();
        }

        public V Put(K key, V value)
        {
            return iMapListener.Put(key,value);
        }

        public int Size()
        {
            return iMapListener.Size();
        }

        public V Get(K key)
        {
            return iMapListener.Get(key);
        }
    }

    public interface IMap<K, V>
    {
        bool ContainsKey(K key);

        bool ContainsValue(V value);

        bool IsEmpty();

        V Put(K key, V value);

        int Size();

        V Get(K key);
    }
}
