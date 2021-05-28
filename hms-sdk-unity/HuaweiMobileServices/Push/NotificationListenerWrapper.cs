namespace HuaweiMobileServices.Push
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    internal class NotificationListenerWrapper : AndroidJavaProxy
    {
        private Action<NotificationData> mOnNotificationMessage;

        public NotificationListenerWrapper(Action<NotificationData> onNotificationMessage) : base("org.m0skit0.android.hms.unity.push.NotificationListener")
        {
            mOnNotificationMessage = onNotificationMessage;
        }

        public void onNotificationMessage(AndroidJavaObject notificationData)
        {
            this.CallOnMainThread(() => { mOnNotificationMessage.Invoke(notificationData.AsWrapper<NotificationData>()); });
        }
    }
}
