using HuaweiMobileServices.Utils;

using System;
using System.Collections.Generic;
using System.Text;

using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class BannerMessage : JavaObjectWrapper
    {
        public BannerMessage(AndroidJavaObject javaObject) : base(javaObject) { }

        public Banner GetBanner => CallAsWrapper<Banner>("getBanner");
        public MessageType GetMessageType => CallAsWrapper<MessageType>("getMessageType");

        public class Banner : JavaObjectWrapper
        {
            public Banner(AndroidJavaObject javaObject) : base(javaObject) { }

            public string GetTitle => CallAsString("getTitle");
            public string GetTitleColor => CallAsString("getTitleColor");
            public int GetTitleColorOpenness => Call<int>("getTitleColorOpenness");
            public string GetBody => CallAsString("getBody");
            public string GetBodyColor => CallAsString("getBodyColor");
            public int GetBodyColorOpenness => Call<int>("getBodyColorOpenness");
            public string GetBackgroundColor => CallAsString("getBackgroundColor");
            public int GetBackgroundColorOpenness => Call<int>("getBackgroundColorOpenness");
            public string GetPictureUrl => CallAsString("getPictureUrl");
            public string GetActionUrl => CallAsString("getActionUrl");
            public int GetActionType => Call<int>("getActionType");
        }
    }
}
