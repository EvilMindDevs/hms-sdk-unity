using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    internal class AGConnectAppMessagingCallbackWrapper : AndroidJavaProxy
    {
        private Action<AppMessage> mOnMessageClick;
        private Action<AppMessage> mOnMessageDisplay;
        private Action<AppMessage> monMessageError;

        public AGConnectAppMessagingCallbackWrapper(Action<AppMessage> onMessageClick, Action<AppMessage> OnMessageDisplay, Action<AppMessage> OnMessageError)
                : base("com.huawei.agconnect.appmessaging.AGConnectAppMessagingCallback")
        {
            mOnMessageClick = onMessageClick;
            mOnMessageDisplay = OnMessageDisplay;
            monMessageError = OnMessageError;
        }
        public void onMessageClick(AndroidJavaObject appMessage)
        {
            mOnMessageClick.Invoke(appMessage.AsWrapper<AppMessage>());
        }
        public void onMessageDisplay(AndroidJavaObject appMessage)
        {
            mOnMessageDisplay.Invoke(appMessage.AsWrapper<AppMessage>());
        }
        public void onMessageError(AndroidJavaObject appMessage)
        {
            monMessageError.Invoke(appMessage.AsWrapper<AppMessage>());
        }

        public class DismissType : JavaObjectWrapper
        {
            public DismissType(AndroidJavaObject javaObject) : base(javaObject) { }

            private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.appmessaging.AGConnectAppMessagingCallback$DismissType");
            public static DismissType BACK_BUTTON => androidJavaClass.GetStaticAsWrapper<DismissType>("BACK_BUTTON");
            public static DismissType CLICK => androidJavaClass.GetStaticAsWrapper<DismissType>("CLICK");
            public static DismissType CLICK_OUTSIDE => androidJavaClass.GetStaticAsWrapper<DismissType>("CLICK_OUTSIDE");
            public static DismissType AUTO => androidJavaClass.GetStaticAsWrapper<DismissType>("AUTO");
            public static DismissType UNKNOWN_DISMISS_TYPE => androidJavaClass.GetStaticAsWrapper<DismissType>("UNKNOWN_DISMISS_TYPE");
        }
    }
}
 
