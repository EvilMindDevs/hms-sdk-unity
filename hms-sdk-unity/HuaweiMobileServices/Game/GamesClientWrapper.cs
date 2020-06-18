namespace HuaweiMobileServices.Game
{

    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class GamesClientWrapper : JavaObjectWrapper, IGamesClient
    {

        [UnityEngine.Scripting.Preserve]
        public GamesClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<string> AppId => CallAsWrapper<TaskStringWrapper>("getAppId");

        public ITask<Void> SetPopupsPosition(int paramInt) => CallAsWrapper<TaskVoidWrapper>("setPopupsPosition", paramInt);
    }
}
