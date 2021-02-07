using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class Locale : JavaObjectWrapper
    {
        public Locale(AndroidJavaObject javaObject) : base(javaObject) { }
        public Locale() : base("java.util.Locale") { }
        public Locale(string paramString1) : base("java.util.Locale", paramString1) { }
        public Locale(string paramString1, string paramString2) : base("java.util.Locale", paramString1, paramString2) { }

        public static AndroidJavaClass javaClass = new AndroidJavaClass("java.util.Locale");
        public static Locale GetDefault() => javaClass.CallStaticAsWrapper<Locale>("getDefault");
    }
}
