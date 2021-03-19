using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class AGConnectAppMessaging : JavaObjectWrapper
    {
        public AGConnectAppMessaging(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.appmessaging.AGConnectAppMessaging");
        public static AGConnectAppMessaging GetInstance()
        {
            AGConnectAppMessaging agConnectAppMessaging = androidJavaClass.CallStaticAsWrapper<AGConnectAppMessaging>("getInstance");
            return agConnectAppMessaging;
        }
        public bool FetchMessageEnable => Call<bool>("isFetchMessageEnable");
        public void SetFetchMessageEnable(bool enable) => Call("setFetchMessageEnable", enable);
        public bool DisplayEnable => Call<bool>("isDisplayEnable");
        public void SetDisplayEnable(bool enable) => Call("setDisplayEnable", enable);
        public void AddOnClickListener(Action<AppMessage> onMessageClick)
        {
            Call("addOnClickListener", new AGConnectAppMessagingOnClickListenerWrapper(onMessageClick));
        }
        public void AddOnDismissListener(Action<AppMessage> onMessageClick)
        {
            Call("addOnDismissListener", new AGConnectAppMessagingOnDismissListenerWrapper(onMessageClick));
        }
        public void AGConnectAppMessagingOnDisplayListener(Action<AppMessage> onMessageClick)
        {
            Call("addOnDisplayListener", new AGConnectAppMessagingDisplayWrapper(onMessageClick));
        }
        public void SetForceFetch() => Call("setForceFetch");
        public void RemoveCustomView() => Call("removeCustomView");
        public void SetDisplayLocation(Location location) => Call("setDisplayLocation");
        public void Trigger(string eventId) => Call("trigger",eventId);
    }
}
