using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
   public class Message :JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Message(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.Message");
        public static int MAX_CONTENT_SIZE => androidJavaClass.GetStatic<int>("MAX_CONTENT_SIZE");
        public static int MAX_TYPE_LENGTH => androidJavaClass.GetStatic<int>("MAX_TYPE_LENGTH");
        public static String MESSAGE_NAMESPACE_RESERVED => androidJavaClass.GetStatic<String>("MESSAGE_NAMESPACE_RESERVED");
        public static String MESSAGE_TYPE_EDDYSTONE_UID => androidJavaClass.GetStatic<String>("MESSAGE_TYPE_EDDYSTONE_UID");
        public static String MESSAGE_TYPE_I_BEACON_ID => androidJavaClass.GetStatic<String>("MESSAGE_TYPE_I_BEACON_ID");

        public String Type => androidJavaClass.Call<String>("getType");
        public String MessageString => androidJavaClass.Call<String>("toString");
        public byte[] Hex => androidJavaClass.Call<byte[]>("getContent");
        public String NameSpace => androidJavaClass.Call<String>("getNamespace");

    }
}
