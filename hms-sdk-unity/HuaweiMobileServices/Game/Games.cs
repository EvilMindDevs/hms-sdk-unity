namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Id;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.Games
    public static class Games
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.jos.games.Games");

        public static IEventsClient GetEventsClient() =>
            sJavaClass.CallStaticAsWrapper<EventsClientWrapper>("getEventsClient", AndroidContext.ActivityContext);

        public static IPlayersClient GetPlayersClient() =>
            sJavaClass.CallStaticAsWrapper<PlayersClientWrapper>("getPlayersClient", AndroidContext.ActivityContext);

        public static IAchievementsClient GetAchievementsClient() =>
            sJavaClass.CallStaticAsWrapper<AchievementClientWrapper>("getAchievementsClient", AndroidContext.ActivityContext);

        public static IGamesClient GetGamesClient() =>
            sJavaClass.CallStaticAsWrapper<GamesClientWrapper>("getGamesClient", AndroidContext.ActivityContext);

        public static IRankingsClient GetRankingsClient() =>
            sJavaClass.CallStaticAsWrapper<RankingsClientWrapper>("getRankingsClient", AndroidContext.ActivityContext);

        public static IGameSummaryClient GetGameSummaryClient() =>
            sJavaClass.CallStaticAsWrapper<GameSummaryClientWrapper>("getGameSummaryClient", AndroidContext.ActivityContext);

        public static IGamePlayerStatisticsClient GetGamePlayerStatsClient() =>
            sJavaClass.CallStaticAsWrapper<GamePlayerStatisticsClientWrapper>("getGamePlayerStatsClient", AndroidContext.ActivityContext);

        public static IArchivesClient GetArchiveClient() =>
            sJavaClass.CallStaticAsWrapper<ArchivesClientWrapper>("getArchiveClient", AndroidContext.ActivityContext);

        public static IBuoyClient GetBuoyClient() =>
            sJavaClass.CallStaticAsWrapper<BuoyClientWrapper>("getBuoyClient", AndroidContext.ActivityContext);

    }

}
