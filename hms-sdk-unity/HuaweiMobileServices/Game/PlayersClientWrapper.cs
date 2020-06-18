namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class PlayersClientWrapper : JavaObjectWrapper, IPlayersClient
    {

        [UnityEngine.Scripting.Preserve]
        public PlayersClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<Player> CurrentPlayer => CallAsWrapper<TaskJavaObjectWrapper<Player>>("getCurrentPlayer");

        public ITask<string> CachePlayerId => CallAsWrapper<TaskStringWrapper>("getCurrentPlayer");

        public ITask<PlayerExtraInfo> GetPlayerExtraInfo(string paramString) =>
             CallAsWrapper<TaskJavaObjectWrapper<PlayerExtraInfo>>("getPlayerExtraInfo", paramString.AsJavaString());

        public ITask<Void> SavePlayerInfo(AppPlayerInfo paramAppPlayerInfo)
        {
            var javaTask = Call<AndroidJavaObject>("savePlayerInfo", paramAppPlayerInfo.JavaObject);
            return new TaskVoidWrapper(javaTask);
        }

        public ITask<string> SubmitPlayerEvent(string paramString1, string paramString2, string paramString3) =>
            CallAsWrapper<TaskStringWrapper>("submitPlayerEvent", paramString1.AsJavaString(), paramString2.AsJavaString(), paramString3.AsJavaString());

    }
}
