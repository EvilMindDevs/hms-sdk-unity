namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System;

    // Wrapper for com.huawei.hms.jos.games.PlayersClient
    public interface IPlayersClient
    {
        ITask<Player> CurrentPlayer { get; }

        ITask<string> CachePlayerId { get; }

        ITask<Utils.Void> SavePlayerInfo(AppPlayerInfo paramAppPlayerInfo);

        ITask<PlayerExtraInfo> GetPlayerExtraInfo(string paramString);

        ITask<string> SubmitPlayerEvent(string paramString1, string paramString2, string paramString3);

        void SetGameTrialProcess(Action onTrialTimeOut, Action<bool> onCheckRealNameResult);
    }

}