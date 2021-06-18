using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class Set<T1> : JavaObjectWrapper
    {
        private const string CLASS_NAME = "java.util.Set";

        public Set(AndroidJavaObject javaObject) : base(javaObject) { }

        public Set() : base(CLASS_NAME) { }

        public Set(String arg1, String arg2) : base(CLASS_NAME, arg1, arg2) { }
        public int Size => Call<int>("size");
    }
}
