namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.event.Event
    public class Event : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public Event(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string Description
        {
            get => CallAsString("getDescription");
        }

        public virtual string EventId
        {
            get => CallAsString("getEventId");
        }

        public virtual string ThumbnailUri
        {
            get => CallAsUriString("getThumbnailUri");
        }

        public virtual string Name
        {
            get => CallAsString("getName");
        }

        public virtual Player GamePlayer
        {
            get => Call<AndroidJavaObject>("getGamePlayer").AsWrapper<Player>();
        }

        public virtual long Value
        {
            get => Call<long>("getValue");
        }

        public virtual string LocaleValue
        {
            get => CallAsString("getLocaleValue");
        }

        public virtual bool Visible
        {
            get => Call<bool>("isVisible");
        }
    }

}