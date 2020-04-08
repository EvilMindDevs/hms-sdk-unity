namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class PlayersClientWrapper : JavaObjectWrapper, IPlayersClient
    {

        internal PlayersClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<Player> CurrentPlayer
        {
            get => CallAsWrapper<TaskJavaObjectWrapper<Player>>("getCurrentPlayer");
        }

        public ITask<string> CachePlayerId
        {
            get => CallAsWrapper<TaskStringWrapper>("getCurrentPlayer");
        }

        public ITask<PlayerExtraInfo> GetPlayerExtraInfo(string paramString) =>
             CallAsWrapper<TaskJavaObjectWrapper<PlayerExtraInfo>>("getPlayerExtraInfo", paramString.AsJavaString());

        public ITask<Void> SavePlayerInfo(AppPlayerInfo paramAppPlayerInfo)
        {
            var javaTask = Call<AndroidJavaObject>("savePlayerInfo", paramAppPlayerInfo.JavaObject);
            return new TaskWrapper<Void>(javaTask, (javaObject) => Void.INSTANCE) ;
        }

        public ITask<string> SubmitPlayerEvent(string paramString1, string paramString2, string paramString3) =>
            CallAsWrapper<TaskStringWrapper>("submitPlayerEvent", paramString1.AsJavaString(), paramString2.AsJavaString(), paramString3.AsJavaString());

    }
}
