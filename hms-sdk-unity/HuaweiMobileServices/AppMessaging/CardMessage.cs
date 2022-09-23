using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class CardMessage : JavaObjectWrapper
    {
        public CardMessage(AndroidJavaObject javaObject) : base(javaObject) { }

        public Card GetCard => CallAsWrapper<Card>("getCard");
        public MessageType GetMessageType => CallAsWrapper<MessageType>("getMessageType");

        public class Card : JavaObjectWrapper
        {
            public Card(AndroidJavaObject javaObject) : base(javaObject) { }
            public Card() : base("com.huawei.agconnect.appmessaging$Card") { }

            public string GetTitle => CallAsString("getTitle");
            public string GetTitleColor => CallAsString("getTitleColor");
            public int GetTitleColorOpenness => Call<int>("getTitleColorOpenness");
            public string GetBody => CallAsString("getBody");
            public string GetBodyColor => CallAsString("getBodyColor");
            public int GetBodyColorOpenness => Call<int>("getBodyColorOpenness");
            public string GetBackgroundColor => CallAsString("getBackgroundColor");
            public int GetBackgroundColorOpenness => Call<int>("getBackgroundColorOpenness");
            public string GetPortraitPictureUrl => CallAsString("getPortraitPictureUrl");
            public string GetLandscapePictureUrl => CallAsString("getLandscapePictureUrl");
            public Button GetMajorButton => CallAsWrapper<Button>("getMajorButton");
            public Button GetMinorButton => CallAsWrapper<Button>("getMinorButton");
        }

        public class Button : JavaObjectWrapper
        {
            public Button(AndroidJavaObject javaObject) : base(javaObject) { }
            public Button() : base("com.huawei.agconnect.appmessaging$Button") { }

            public string GetText => CallAsString("getText");
            public string GetTextColor => CallAsString("getTextColor");
            public int GetTextColorOpenness => Call<int>("getTextColorOpenness");
            public string GetActionUrl => CallAsString("getActionUrl");
            public int GetActionType => Call<int>("getActionType");
        }
    }
}
