namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;

    // Wrapper for com.huawei.hms.jos.games.playerstats.GamePlayerStatisticsClient
    public interface IGamePlayerStatisticsClient
    {
        ITask<GamePlayerStatistics> GetGamePlayerStatistics(bool paramBoolean);
    }

}