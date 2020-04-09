namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Id;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.jos.games.Games
    public static class Games
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.jos.games.Games");

        public static IEventsClient GetEventsClient(AuthHuaweiId authHuaweiId)
        {
            var javaClient = sJavaClass.CallStatic<AndroidJavaObject>("getEventsClient", AndroidContext.GetActivityContext(), authHuaweiId.JavaObject);
            return new EventsClientWrapper(javaClient);
        }

        public static IPlayersClient GetPlayersClient(AuthHuaweiId authHuaweiId)
        {
            var javaClient = sJavaClass.CallStatic<AndroidJavaObject>("getPlayersClient", AndroidContext.GetActivityContext(), authHuaweiId.JavaObject);
            return new PlayersClientWrapper(javaClient);
        }

        public static IAchievementsClient GetAchievementsClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<AcheivementClientWrapper>("getAchievementsClient", AndroidContext.GetActivityContext(), authHuaweiId.JavaObject);

        public static IGamesClient GetGamesClient(AuthHuaweiId authHuaweiId) =>
            sJavaClass.CallStaticAsWrapper<GamesClientWrapper>("getGamesClient", AndroidContext.GetActivityContext(), authHuaweiId.JavaObject);

        //public static RankingsClient GetRankingsClient(Activity paramActivity, AuthHuaweiId paramAuthHuaweiId)
        //{
        //    Checker.assertNonNull(paramActivity);
        //    b.a().a(paramActivity);
        //    return new RankingsClientImpl(paramActivity, paramAuthHuaweiId);
        //}

        //public static GameSummaryClient GetGameSummaryClient(Activity paramActivity, AuthHuaweiId paramAuthHuaweiId)
        //{
        //    Checker.assertNonNull(paramActivity);
        //    b.a().a(paramActivity);
        //    return new GameSummaryClientImpl(paramActivity, paramAuthHuaweiId);
        //}

        //public static GamePlayerStatisticsClient GetGamePlayerStatsClient(Activity paramActivity, AuthHuaweiId paramAuthHuaweiId)
        //{
        //    Checker.assertNonNull(paramActivity);
        //    b.a().a(paramActivity);
        //    return new PlayerStatsClientImpl(paramActivity, paramAuthHuaweiId);
        //}

        //public static ArchivesClient GetArchiveClient(Activity paramActivity, AuthHuaweiId paramAuthHuaweiId)
        //{
        //    Checker.assertNonNull(paramActivity);
        //    b.a().a(paramActivity);
        //    return new a(paramActivity, paramAuthHuaweiId);
        //}

        //public static BuoyClient GetBuoyClient(Activity paramActivity)
        //{
        //    Checker.assertNonNull(paramActivity);
        //    b.a().a(paramActivity);
        //    return new BuoyClientImpl(paramActivity);
        //}
    }

}