namespace HuaweiMobileServices.Game
{

    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper com.huawei.hms.jos.games.archive.ArchiveSummary
    public class ArchiveSummary : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public ArchiveSummary(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string Id => CallAsString("getId");

        public virtual string FileName => CallAsString("getFileName");

        public virtual long ActiveTime => Call<long>("getActiveTime");

        public virtual long CurrentProgress => Call<long>("getCurrentProgress");

        public virtual float ThumbnailRatio => Call<float>("getThumbnailRatio");

        public virtual bool HasThumbnail() => Call<bool>("getHasThumbnail");

        public virtual string DescInfo => CallAsString("getDescInfo");

        public virtual Player GamePlayer => CallAsWrapper<Player>("getGamePlayer");

        public virtual GameSummary GameSummary => CallAsWrapper<GameSummary>("getGameSummary");

        public virtual long RecentUpdateTime => Call<long>("getRecentUpdateTime");

        public virtual int DescribeContents() => Call<int>("getDescribeContents");
    }

}