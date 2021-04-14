using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
   public class Message :JavaObjectWrapper
    {
        
        public Message(AndroidJavaObject javaObject) : base(javaObject) { }

        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.Message");
        public static int MAX_CONTENT_SIZE => androidJavaClass.GetStatic<int>("MAX_CONTENT_SIZE");
        public static int MAX_TYPE_LENGTH => androidJavaClass.GetStatic<int>("MAX_TYPE_LENGTH");
        public static String MESSAGE_NAMESPACE_RESERVED => androidJavaClass.GetStatic<String>("MESSAGE_NAMESPACE_RESERVED");
        public static String MESSAGE_TYPE_EDDYSTONE_UID => androidJavaClass.GetStatic<String>("MESSAGE_TYPE_EDDYSTONE_UID");
        public static String MESSAGE_TYPE_I_BEACON_ID => androidJavaClass.GetStatic<String>("MESSAGE_TYPE_I_BEACON_ID");

        public String Type => Call<String>("getType");
        public String MessageString => Call<String>("toString");
        public byte[] Content => Call<byte[]>("getContent");
        public String NameSpace => Call<String>("getNamespace");

    }
}
