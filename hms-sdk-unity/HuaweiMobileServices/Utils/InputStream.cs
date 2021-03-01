
using UnityEngine;
using System.Collections;

namespace HuaweiMobileServices.Utils
{
    public class InputStream : JavaObjectWrapper
    {
        private const string CLASS_NAME = "java.io.InputStream";

        public InputStream(AndroidJavaObject javaObject) : base(javaObject) { }

        public InputStream() : base(CLASS_NAME) { }

    }
}