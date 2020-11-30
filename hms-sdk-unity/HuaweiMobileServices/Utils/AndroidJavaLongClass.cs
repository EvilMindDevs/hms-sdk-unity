using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class AndroidJavaLongClass : AndroidJavaObject
    {
        private const string CLASS_NAME = "java.lang.Long";

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public AndroidJavaLongClass() : base(CLASS_NAME) { }

        public long ParseLong(String s, int radix) => sJavaClass.CallStatic<long>("parseLong", s, radix);
        public long ParseLong(String s) => sJavaClass.CallStatic<long>("parseLong", s);

        public int IntValue => Call<int>("intValue");
        public long LongValue => Call<long>("longValue");

        public String LongString() => Call<String>("toString");
    }
}
