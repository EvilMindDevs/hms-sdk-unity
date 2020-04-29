namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Id;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.Games
    public static class Games
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.jos.games.Games");

        public static IEventsClient GetEventsClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<EventsClientWrapper>("getEventsClient", AndroidContext.ActivityContext, authHuaweiId.JavaObject);

        public static IPlayersClient GetPlayersClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<PlayersClientWrapper>("getPlayersClient", AndroidContext.ActivityContext, authHuaweiId.JavaObject);

        public static IAchievementsClient GetAchievementsClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<AchievementClientWrapper>("getAchievementsClient", AndroidContext.ActivityContext, authHuaweiId.JavaObject);

        public static IGamesClient GetGamesClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<GamesClientWrapper>("getGamesClient", AndroidContext.ActivityContext, authHuaweiId.JavaObject);

        public static IRankingsClient GetRankingsClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<RankingsClientWrapper>("getRankingsClient", AndroidContext.ActivityContext, authHuaweiId);

        public static IGameSummaryClient GetGameSummaryClient(AuthHuaweiId paramAuthHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<GameSummaryClientWrapper>("getGameSummaryClient", AndroidContext.ActivityContext, paramAuthHuaweiId);

        public static IGamePlayerStatisticsClient GetGamePlayerStatsClient(AuthHuaweiId paramAuthHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<GamePlayerStatisticsClientWrapper>("getGamePlayerStatsClient", AndroidContext.ActivityContext, paramAuthHuaweiId);

        public static IArchivesClient GetArchiveClient(AuthHuaweiId paramAuthHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<ArchivesClientWrapper>("getArchiveClient", AndroidContext.ActivityContext, paramAuthHuaweiId);

        public static IBuoyClient GetBuoyClient() =>
            sJavaClass.CallStaticAsWrapper<BuoyClientWrapper>("getBuoyClient", AndroidContext.ActivityContext);

    }

}
