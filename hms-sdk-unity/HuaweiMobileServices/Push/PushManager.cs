namespace HuaweiMobileServices.Push
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Id;
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    public static class PushManager
    {
        public static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.push.HMSPushService");
        public static readonly AndroidJavaClass pushBridgeJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.push.PushBridge");

        public static IPushListener Listener
        {
            set => sJavaClass.CallStatic("setListener", new PushListenerWrapper(value));
        }

        public static void RegisterOnNotificationMessage(Action<NotificationData> action) => pushBridgeJavaClass.CallStatic("setListener", new NotificationListenerWrapper(action));

        public static NotificationData NotificationDataOnStart => pushBridgeJavaClass.CallStaticAsWrapper<NotificationData>("getNotificationDataOnStart", AndroidContext.ActivityContext);

        public static string Token => HmsInstanceId.GetInstance().GetToken(MetadataHelper.AppId, "HCM");

    }
}
