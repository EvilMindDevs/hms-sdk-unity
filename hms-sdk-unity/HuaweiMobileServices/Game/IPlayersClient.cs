namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System;

    // Wrapper for com.huawei.hms.jos.games.PlayersClient
    public interface IPlayersClient
    {
        ITask<Player> CurrentPlayer { get; }

        ITask<Player> GamePlayer { get; }

        ITask<string> CachePlayerId { get; }

        ITask<int> UserPlayState { get; }

        ITask<bool> IsAllowContinuePlayGames { get; }

        ITask<Utils.Void> SavePlayerInfo(AppPlayerInfo paramAppPlayerInfo);

        ITask<Player> GetGamePlayer(bool isRequirePlayerId);

        ITask<PlayerExtraInfo> GetPlayerExtraInfo(string paramString);

        ITask<string> SubmitPlayerEvent(string playerId, string eventId, string eventType);

        ITask<string> SubmitPlayerEvent(string eventId, string eventType);

        void SetGameTrialProcess(Action onTrialTimeOut, Action<bool> onCheckRealNameResult);
    }

}