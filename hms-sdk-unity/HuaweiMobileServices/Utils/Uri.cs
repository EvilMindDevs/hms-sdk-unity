
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class Uri : JavaObjectWrapper
    {

        private const string CLASS_NAME = "android.net.Uri";
        public Uri(AndroidJavaObject javaObject) : base(javaObject) { }

        public override string ToString() => CallAsString("toString");
        public string GetPath => CallAsString("getPath");

    }
}
