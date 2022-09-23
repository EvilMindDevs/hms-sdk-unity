using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class AGCAppMessagingException : JavaObjectWrapper
    {
        public AGCAppMessagingException(AndroidJavaObject javaObject) : base(javaObject) { }
        public AGCAppMessagingException() : base("com.huawei.agconnect.appmessaging") { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.appmessaging");

        public static int MSG_TYPE_UNDEFINE => androidJavaClass.Call<int>("MSG_TYPE_UNDEFINE");
        public static int DATA_NOT_MODIFIED => androidJavaClass.Call<int>("DATA_NOT_MODIFIED");

    }
}
