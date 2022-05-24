using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class ShortAppLinking : JavaObjectWrapper
    {
        public ShortAppLinking(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.ShortAppLinking");

        public string GetShortUrl => CallAsUriString("getShortUrl");
        public string GetTestUrl => CallAsUriString("getTestUrl");

        public enum LENGTH
        {
            LONG,
            SHORT
        }
    }
}