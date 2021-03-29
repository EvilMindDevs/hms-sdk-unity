using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class AGConnectAppMessaging : JavaObjectWrapper
    {
        public AGConnectAppMessaging(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.appmessaging.AGConnectAppMessaging");
        public static AGConnectAppMessaging Instance
            => androidJavaClass.CallStaticAsWrapper<AGConnectAppMessaging>("getInstance");
        
        public bool FetchMessageEnable => Call<bool>("isFetchMessageEnable");
        public void SetFetchMessageEnable(bool enable) => Call("setFetchMessageEnable", enable);
        public bool DisplayEnable => Call<bool>("isDisplayEnable");
        public void SetDisplayEnable(bool enable) => Call("setDisplayEnable", enable);
        public void AddOnClickListener(Action<AppMessage> listener)
        {
            Call("addOnClickListener", new AGConnectAppMessagingOnClickListenerWrapper(listener));
        }
        public void AddOnDismissListener(Action<AppMessage, DismissType> listener)
        {
            Call("addOnDismissListener", new AGConnectAppMessagingOnDismissListenerWrapper(listener));
        }
        public void AddOnDisplayListener(Action<AppMessage> listener)
        {
            Call("addOnDisplayListener", new AGConnectAppMessagingOnDisplayListenerWrapper(listener));
        }
        public void SetForceFetch() => Call("setForceFetch");
        public void RemoveCustomView() => Call("removeCustomView");
        public void SetDisplayLocation(Location location) => Call("setDisplayLocation");
        public void Trigger(string eventId) => Call("trigger",eventId);
    }
}
