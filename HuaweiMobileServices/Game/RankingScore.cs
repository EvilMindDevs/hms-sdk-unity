namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.jos.games.ranking.RankingScore
    public class RankingScore : JavaObjectWrapper
    {
        public const int RANK_UNKNOWN = -1;

        private const string CLASS_NAME = "com.huawei.hms.jos.games.ranking.RankingScore";

        public RankingScore(RankingScore rankingScore) : base(CLASS_NAME, rankingScore) { }

        public RankingScore(string json) : base(CLASS_NAME, json) { }

        public virtual string DisplayRank
        {
            get => CallAsString("getDisplayRank");
        }

        public virtual int TimeDimension
        {
            get => Call<int>("getTimeDimension");
        }

        public virtual string RankingDisplayScore
        {
            get => CallAsString("getRankingDisplayScore");
        }

        public virtual long PlayerRank
        {
            get => Call<long>("getPlayerRank");
        }

        public virtual long PlayerRawScore
        {
            get => Call<long>("getPlayerRawScore");
        }

        public virtual Player ScoreOwnerPlayer
        {
            get => CallAsWrapper<Player>("getScoreOwnerPlayer");
        }

        public virtual string ScoreOwnerDisplayName
        {
            get => CallAsString("getScoreOwnerDisplayName");
        }

        public virtual string ScoreOwnerHiIconUri
        {
            get => CallAsUriString("getScoreOwnerHiIconUri");
        }

        public virtual string ScoreOwnerIconUri
        {
            get => CallAsUriString("getScoreOwnerIconUri");
        }

        public virtual string ScoreTips
        {
            get => CallAsString("getScoreTips");
        }

        public virtual long ScoreTimestamp
        {
            get => Call<long>("getScoreTimestamp");
        }
    }

}