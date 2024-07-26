using UnityEngine;

public static class AndroidJavaTypeConverter
{
    public static AndroidJavaObject ToJavaObject<T>(this T obj)
    {
        if (obj == null) return null;

        if (obj is string)
            return new AndroidJavaObject("java.lang.String", obj);
        if (obj is int)
            return new AndroidJavaObject("java.lang.Integer", obj);
        if (obj is float)
            return new AndroidJavaObject("java.lang.Float", obj);
        if (obj is double)
            return new AndroidJavaObject("java.lang.Double", obj);
        if (obj is bool)
            return new AndroidJavaObject("java.lang.Boolean", obj);
        if (obj is long)
            return new AndroidJavaObject("java.lang.Long", obj);
        if (obj is short)
            return new AndroidJavaObject("java.lang.Short", obj);
        if (obj is byte)
            return new AndroidJavaObject("java.lang.Byte", obj);
        if (obj is char)
            return new AndroidJavaObject("java.lang.Character", obj);
        if (obj is AndroidJavaObject)
            return (AndroidJavaObject)(object)obj;

        throw new System.Exception("Unsupported type: " + typeof(T));
    }

    public static T FromJavaObject<T>(this AndroidJavaObject javaObject)
    {
        if (javaObject == null) return default;

        object result = default(T);

        if (typeof(T) == typeof(string))
            result = javaObject.Call<string>("toString");
        if (typeof(T) == typeof(int))
            result = javaObject.Call<int>("intValue");
        if (typeof(T) == typeof(float))
            result = javaObject.Call<float>("floatValue");
        if (typeof(T) == typeof(double))
            result = javaObject.Call<double>("doubleValue");
        if (typeof(T) == typeof(bool))
            result = javaObject.Call<bool>("booleanValue");
        if (typeof(T) == typeof(long))
            result = javaObject.Call<long>("longValue");
        if (typeof(T) == typeof(short))
            result = javaObject.Call<short>("shortValue");
        if (typeof(T) == typeof(byte))
            result = javaObject.Call<byte>("byteValue");
        if (typeof(T) == typeof(char))
            result = javaObject.Call<char>("charValue");

        return (T)result;
    }
}
