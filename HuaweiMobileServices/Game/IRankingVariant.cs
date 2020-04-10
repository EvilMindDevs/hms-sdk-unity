namespace HuaweiMobileServices.Game
{

    // Wrapper for com.huawei.hms.jos.games.ranking.RankingVariant
    public interface IRankingVariant
    {

        string DisplayRanking { get; }

        string PlayerDisplayScore { get; }

        long RankTotalScoreNum { get; }

        long PlayerRank { get; }

        string PlayerScoreTips { get; }

        long PlayerRawScore { get; }

        int TimeDimension();

        bool HasPlayerInfo();
    }

    public static class RankingVariant
    {
        public const int NUM_SCORES_UNKNOWN = -1;
        public const int PLAYER_RANK_UNKNOWN = -2;
        public const int PLAYER_SCORE_UNKNOWN = -3;
        public const int NUM_TIME_DIMENSION = 3;
        public const int TIME_DIMENSION_DAILY = 0;
        public const int TIME_DIMENSION_WEEKLY = 1;
        public const int TIME_DIMENSION_ALL_TIME = 2;
    }

}