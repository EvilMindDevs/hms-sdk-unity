namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;

    // Wrapper for com.huawei.hms.jos.games.GameSummaryClient
    public interface IGameSummaryClient
    {
        ITask<GameSummary> LocalGameSummary { get; }

        ITask<GameSummary> GameSummary { get; }
    }

}