using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class Map<T1, T2>: JavaObjectWrapper
    {
        private const string CLASS_NAME = "java.util.Map";

        public Map(AndroidJavaObject javaObject) : base(javaObject) { }

        public Map() : base(CLASS_NAME) { }

        public Map(String arg1, String arg2) : base(CLASS_NAME , arg1, arg2) { }
    }
}
