using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Utils
{
    using UnityEngine;

    public class AndroidBundle : JavaObjectWrapper
    {
        public AndroidBundle(AndroidJavaObject javaObject) : base(javaObject) { }

        public AndroidJavaObject Bundle => JavaObject;
    }
}
