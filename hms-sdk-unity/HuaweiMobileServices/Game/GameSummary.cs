namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.gamesummary.GameSummary
    public class GameSummary : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public GameSummary(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual int AchievementCount => Call<int>("getAchievementCount");

        public virtual string AppId => CallAsString("getAppId");

        public virtual string DescInfo => CallAsString("getDescInfo");

        public virtual string GameName => CallAsString("getGameName");

        public virtual string GameHdImgUri => CallAsUriString("getGameHdImgUri");

        public virtual string GameIconUri => CallAsUriString("getGameIconUri");

        public virtual int RankingCount => Call<int>("getRankingCount");

        public virtual string FirstKind => CallAsString("getFirstKind");

        public virtual string SecondKind => CallAsString("getSecondKind");
    }

}