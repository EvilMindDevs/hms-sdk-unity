using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class MessageType : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public MessageType(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.appmessaging.MessageType");
        public static MessageType UN_SUPPORT => androidJavaClass.GetStaticAsWrapper<MessageType>("UN_SUPPORT");
        public static MessageType CARD => androidJavaClass.GetStaticAsWrapper<MessageType>("CARD");
        public static MessageType PICTURE => androidJavaClass.GetStaticAsWrapper<MessageType>("PICTURE");
        public static MessageType BANNER => androidJavaClass.GetStaticAsWrapper<MessageType>("BANNER");

    }
}