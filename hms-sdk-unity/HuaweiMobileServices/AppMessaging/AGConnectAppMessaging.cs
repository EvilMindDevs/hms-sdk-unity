using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.AppMessaging
{
    public class AGConnectAppMessaging : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public AGConnectAppMessaging(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.agconnect.appmessaging.AGConnectAppMessaging");
        public static AGConnectAppMessaging Instance
            => androidJavaClass.CallStaticAsWrapper<AGConnectAppMessaging>("getInstance");
        public bool DisplayEnable
        {
            get => Call<bool>("isDisplayEnable");
            set => Call("setDisplayEnable", value);
        }
        public bool FetchMessageEnable
        {
            get => Call<bool>("isFetchMessageEnable");
            set => Call("setFetchMessageEnable", value);
        }
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
        public void Trigger(string eventId) => Call("trigger", eventId);
    }
}
