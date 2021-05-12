namespace HuaweiMobileServices.Push
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class NotificationData : JavaObjectWrapper
    {
        public NotificationData(AndroidJavaObject javaObject) : base(javaObject)
        {
        }

        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.push.PushBridge$NotificationData");

        public string MsgId => sJavaClass.GetStatic<string>("msgid");

        public string CmdType => sJavaClass.GetStatic<string>("cmdType");

        public int NotifyId => sJavaClass.GetStatic<int>("notifyId");

        public string KeyValueJSON => sJavaClass.GetStatic<string>("keyValueJson");
    }
}
