


using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class PictureMessage : JavaObjectWrapper
    {
        public PictureMessage(AndroidJavaObject javaObject) : base(javaObject) { }

        public Picture GetPicture => CallAsWrapper<Picture>("getPicture");
        public MessageType GetMessageType => CallAsWrapper<MessageType>("getMessageType");

        public class Picture : JavaObjectWrapper
        {
            public Picture(AndroidJavaObject javaObject) : base(javaObject) { }
            public Picture() : base("com.huawei.agconnect.appmessaging$Button") { }

            public string GetPictureUrl => CallAsString("getPictureUrl");
            public string GetActionUrl => CallAsString("getActionUrl");
            public int GetActionType => Call<int>("getActionType");
        }
    }
}
