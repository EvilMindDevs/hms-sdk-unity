using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class ShortAppLinking : JavaObjectWrapper
    {
        public ShortAppLinking(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.ShortAppLinking");

        public string GetShortUrl() => CallAsUriString("getShortUrl");
        public string GetTestUrl() => CallAsUriString("getTestUrl");

        public class LenghtWrapper : JavaObjectWrapper
        {
            public LenghtWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

            private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.ShortAppLinking$LENGTH");

            public static readonly LenghtWrapper LONG = javaClass.GetStaticAsWrapper<LenghtWrapper>("LONG");
            public static readonly LenghtWrapper SHORT = javaClass.GetStaticAsWrapper<LenghtWrapper>("SHORT");


            public static LenghtWrapper GetLinkingPreviewType(LENGTH length)
            {
                if (length == 0) return LONG;
                else return SHORT;
            }
        }

        public enum LENGTH
        {
            LONG = 0,
            SHORT = 1
        }
    }
}