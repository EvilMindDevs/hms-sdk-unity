namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class RankingVariant : JavaObjectWrapper
    {
        public const int NUM_SCORES_UNKNOWN = -1;
        public const int PLAYER_RANK_UNKNOWN = -2;
        public const int PLAYER_SCORE_UNKNOWN = -3;
        public const int NUM_TIME_DIMENSION = 3;
        public const int TIME_DIMENSION_DAILY = 0;
        public const int TIME_DIMENSION_WEEKLY = 1;
        public const int TIME_DIMENSION_ALL_TIME = 2;

        [UnityEngine.Scripting.Preserve]
        public RankingVariant(AndroidJavaObject javaObject) : base(javaObject) { }

        public string DisplayRanking => CallAsString("getDisplayRanking");

        public string PlayerDisplayScore => CallAsString("getPlayerDisplayScore");

        public long RankTotalScoreNum => Call<long>("getRankTotalScoreNum");

        public long PlayerRank => Call<long>("getPlayerRank");

        public string PlayerScoreTips => CallAsString("getPlayerScoreTips");

        public long PlayerRawScore => Call<long>("getPlayerRawScore");

        public bool HasPlayerInfo() => Call<bool>("hasPlayerInfo");

        public int TimeDimension() => Call<int>("timeDimension");
    }
}
