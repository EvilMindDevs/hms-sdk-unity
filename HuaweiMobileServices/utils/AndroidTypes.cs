using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class AndroidTypes
    {

        private AndroidTypes() { }

        public static AndroidJavaObject GetString(string value)
        {
            return new AndroidJavaObject("java.lang.String", value);
        }

        public static string GetString(AndroidJavaObject javaString)
        {
            return javaString.Call<string>("toString");
        }
    }
}
