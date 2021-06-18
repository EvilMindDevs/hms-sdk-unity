namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class GameSummaryClientWrapper : JavaObjectWrapper, IGameSummaryClient
    {
        
        public GameSummaryClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<GameSummary> LocalGameSummary => CallAsWrapper<TaskJavaObjectWrapper<GameSummary>>("getLocalGameSummary");

        public ITask<GameSummary> GameSummary => CallAsWrapper<TaskJavaObjectWrapper<GameSummary>>("getGameSummary");
    }
}
