namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.achievement.Achievement
    public class Achievement : JavaObjectWrapper
    {
        public const int STATE_REACHED = 0;

        public const int STATE_VISUALIZED = 1;

        public const int STATE_UN_DISPLAY = 2;

        public const int TYPE_NORMAL = 0;

        public const int TYPE_GROW_ABLE = 1;

        [UnityEngine.Scripting.Preserve]
        public Achievement(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string Id
        {
            get => CallAsString("getId");
        }

        public virtual int Type
        {
            get => Call<int>("getType");
        }

        public virtual string DisplayName
        {
            get => CallAsString("getId");
        }

        public virtual string DescInfo
        {
            get => CallAsString("getDescInfo");
        }

        public virtual string ReachedThumbnailUri
        {
            get => CallAsUriString("getReachedThumbnailUri");
        }

        public virtual string VisualizedThumbnailUri
        {
            get => CallAsUriString("getVisualizedThumbnailUri");
        }

        public virtual int AllSteps
        {
            get => Call<int>("getAllSteps");
        }

        public virtual string LocaleAllSteps
        {
            get => CallAsString("getLocaleAllSteps");
        }

        public virtual Player GamePlayer
        {
            get => CallAsWrapper<Player>("getGamePlayer");
        }

        public virtual int State
        {
            get => Call<int>("getState");
        }

        public virtual int ReachedSteps
        {
            get => Call<int>("getReachedSteps");
        }

        public virtual string LocaleReachedSteps
        {
            get => CallAsString("getLocaleReachedSteps");
        }

        public virtual long RecentUpdateTime
        {
            get => Call<long>("getRecentUpdateTime");
        }
    }

}