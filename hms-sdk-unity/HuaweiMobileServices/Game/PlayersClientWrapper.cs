namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class PlayersClientWrapper : JavaObjectWrapper, IPlayersClient
    {


        public PlayersClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<Player> CurrentPlayer => CallAsWrapper<TaskJavaObjectWrapper<Player>>("getCurrentPlayer");

        public ITask<Player> GamePlayer => CallAsWrapper<TaskJavaObjectWrapper<Player>>("getGamePlayer");

        public ITask<Player> GetGamePlayer(bool isRequirePlayerId) => CallAsWrapper<TaskJavaObjectWrapper<Player>>("getGamePlayer", isRequirePlayerId);

        public ITask<string> CachePlayerId => CallAsWrapper<TaskStringWrapper>("getCachePlayerId");

        public ITask<PlayerExtraInfo> GetPlayerExtraInfo(string transactionId) =>
             CallAsWrapper<TaskJavaObjectWrapper<PlayerExtraInfo>>("getPlayerExtraInfo", transactionId.AsJavaString());

        public ITask<Void> SavePlayerInfo(AppPlayerInfo paramAppPlayerInfo)
        {
            var javaTask = Call<AndroidJavaObject>("savePlayerInfo", paramAppPlayerInfo.JavaObject);
            return new TaskVoidWrapper(javaTask);
        }

        public void SetGameTrialProcess(System.Action onTrialTimeOut, System.Action<bool> onCheckRealNameResult) => Call("setGameTrialProcess", new GameTrialProcessWrapper(onTrialTimeOut, onCheckRealNameResult));

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
