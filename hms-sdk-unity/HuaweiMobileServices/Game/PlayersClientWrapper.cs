namespace HuaweiMobileServices.Game
{
    using System;
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class PlayersClientWrapper : JavaObjectWrapper, IPlayersClient
    {
        //https://developer.huawei.com/consumer/en/doc/HMSCore-References/playersclient-0000001050121668
        public PlayersClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        [Obsolete("Use GetGamePlayer instead.")]
        public ITask<Player> CurrentPlayer => CallAsWrapper<TaskJavaObjectWrapper<Player>>("getCurrentPlayer");
        
        public ITask<Player> GamePlayer => CallAsWrapper<TaskJavaObjectWrapper<Player>>("getGamePlayer");

        public ITask<Player> GetGamePlayer(bool isRequirePlayerId) => CallAsWrapper<TaskJavaObjectWrapper<Player>>("getGamePlayer", isRequirePlayerId);

        public ITask<string> CachePlayerId => CallAsWrapper<TaskStringWrapper>("getCachePlayerId");

        public ITask<int> UserPlayState => CallAsWrapper<TaskPrimitive<int>>("getUserPlayState");

        public ITask<bool> IsAllowContinuePlayGames => CallAsWrapper<TaskPrimitive<bool>>("isAllowContinuePlayGames");

        public ITask<PlayerExtraInfo> GetPlayerExtraInfo(string transactionId) =>
             CallAsWrapper<TaskJavaObjectWrapper<PlayerExtraInfo>>("getPlayerExtraInfo", transactionId.AsJavaString());

        public ITask<Utils.Void> SavePlayerInfo(AppPlayerInfo paramAppPlayerInfo)
        {
            var javaTask = Call<AndroidJavaObject>("savePlayerInfo", paramAppPlayerInfo.JavaObject);
            return new TaskVoidWrapper(javaTask);
        }

        [Obsolete("This method has been deprecated.")]
        public void SetGameTrialProcess(Action onTrialTimeOut, Action<bool> onCheckRealNameResult) => Call("setGameTrialProcess", new GameTrialProcessWrapper(onTrialTimeOut, onCheckRealNameResult));

        public ITask<string> SubmitPlayerEvent(string playerId, string eventId, string eventType) =>
            CallAsWrapper<TaskStringWrapper>("submitPlayerEvent", playerId.AsJavaString(), eventId.AsJavaString(), eventType.AsJavaString());

        /// <summary>
        /// If you use OpenId to identify users, use this method to report player events.
        /// </summary>
        /// <param name="eventId">Event Id</param>
        /// <param name="eventType">Event Type</param>
        /// <returns></returns>
        public ITask<string> SubmitPlayerEvent(string eventId, string eventType) => CallAsWrapper<TaskStringWrapper>("submitPlayerEvent", eventId.AsJavaString(), eventType.AsJavaString());
    }
}

//TODO - Add the Result Codes class