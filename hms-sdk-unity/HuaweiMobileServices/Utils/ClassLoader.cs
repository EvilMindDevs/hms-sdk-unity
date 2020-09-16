using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class ClassLoader :JavaObjectWrapper
    {
        private const string CLASS_NAME = "java.lang.ClassLoader";
        public ClassLoader(AndroidJavaObject javaObject) : base(javaObject) { }
        public ClassLoader(AndroidJavaClass ActivityClass) : base(CLASS_NAME) { }
    }
}
