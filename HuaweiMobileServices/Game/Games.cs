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
            sJavaClass.CallStaticAsWrapper<EventsClientWrapper>("getEventsClient", AndroidContext.GetActivityContext(), authHuaweiId.JavaObject);

        public static IPlayersClient GetPlayersClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<PlayersClientWrapper>("getPlayersClient", AndroidContext.GetActivityContext(), authHuaweiId.JavaObject);

        public static IAchievementsClient GetAchievementsClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<AcheivementClientWrapper>("getAchievementsClient", AndroidContext.GetActivityContext(), authHuaweiId.JavaObject);

        public static IGamesClient GetGamesClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<GamesClientWrapper>("getGamesClient", AndroidContext.GetActivityContext(), authHuaweiId.JavaObject);

        public static IRankingsClient GetRankingsClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<RankingsClientWrapper>("getRankingsClient", AndroidContext.GetActivityContext(), authHuaweiId);

        public static IGameSummaryClient GetGameSummaryClient(AuthHuaweiId paramAuthHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<GameSummaryClientWrapper>("getGameSummaryClient", AndroidContext.GetActivityContext(), paramAuthHuaweiId);

        public static IGamePlayerStatisticsClient GetGamePlayerStatsClient(AuthHuaweiId paramAuthHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<GamePlayerStatisticsClientWrapper>("getGamePlayerStatsClient", AndroidContext.GetActivityContext(), paramAuthHuaweiId);

        public static IArchivesClient GetArchiveClient(AuthHuaweiId paramAuthHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<ArchivesClientWrapper>("getArchiveClient", AndroidContext.GetActivityContext(), paramAuthHuaweiId);

        // TODO

        //public static BuoyClient GetBuoyClient(Activity paramActivity)
        //{
        //    Checker.assertNonNull(paramActivity);
        //    b.a().a(paramActivity);
        //    return new BuoyClientImpl(paramActivity);
        //}
    }

}
