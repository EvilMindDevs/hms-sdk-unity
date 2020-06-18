namespace HuaweiMobileServices.Push
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class RemoteMessage : JavaObjectWrapper
    {

        public class Notification : JavaObjectWrapper
        {

            [UnityEngine.Scripting.Preserve]
            public Notification(AndroidJavaObject javaObject) : base(javaObject) { }

            public virtual string Title => CallAsString("getTitle");

            public virtual string TitleLocalizationKey => CallAsString("getTitleLocalizationKey");

            public virtual string Body => CallAsString("getBody");

            public virtual string BodyLocalizationKey => CallAsString("getBodyLocalizationKey");

            public virtual string Icon => CallAsString("getIcon");

            public virtual string ImageUrl => CallAsUriString("getImageUrl");

            public virtual string Sound => CallAsString("getSound");

            public virtual string Tag => CallAsString("getTag");

            public virtual string Color => CallAsString("getColor");

            public virtual string ClickAction => CallAsString("getClickAction");

            public virtual string IntentUri => CallAsString("getIntentUri");

            public virtual string ChannelId => CallAsString("getChannelId");

            public virtual string Link => CallAsUriString("getLink");

            public virtual int NotifyId => Call<int>("getNotifyId");

            public virtual bool DefaultLight => Call<bool>("getDefaultLight");

            public virtual bool DefaultSound => Call<bool>("getDefaultSound");

            public virtual bool DefaultVibrate => Call<bool>("getDefaultVibrate");

            public virtual long? When => Call<long?>("getWhen");

            public virtual bool LocalOnly => Call<bool>("getLocalOnly");

            public virtual int? BadgeNumber => Call<int?>("getBadgeNumber");

            public virtual bool AutoCancel => Call<bool>("getAutoCancel");

            public virtual int? Importance => Call<int?>("getImportance");

            public virtual string Ticker => CallAsString("getTicker");

            public virtual int? Visibility => Call<int?>("getVisibility");

        }

        public const int PRIORITY_UNKNOWN = 0;
        public const int PRIORITY_HIGH = 1;
        public const int PRIORITY_NORMAL = 2;

        [UnityEngine.Scripting.Preserve]
        public RemoteMessage(AndroidJavaObject javaObject) : base(javaObject) { }

        public string CollapseKey => CallAsString("getCollapseKey");

        public string Data => CallAsString("getData");

        public string MessageId => CallAsString("getMessageId");

        public string MessageType => CallAsString("getMessageType");

        public Notification GetNotification => CallAsWrapper<Notification>("getNotification");

        public int OriginalUrgency => Call<int>("getOriginalUrgency");

        public int Urgency => Call<int>("getUrgency");

        public int Ttl => Call<int>("getTtl");

        public long SentTime => Call<int>("getSentTime");

        public string To => CallAsString("getTo");

        public string From => CallAsString("getFrom");

        public string Token => CallAsString("getToken");
    }
}
