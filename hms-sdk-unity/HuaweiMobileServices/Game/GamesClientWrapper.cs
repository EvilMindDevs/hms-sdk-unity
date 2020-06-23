namespace HuaweiMobileServices.Game
{

    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class GamesClientWrapper : JavaObjectWrapper, IGamesClient
    {

        [UnityEngine.Scripting.Preserve]
        public static GamesClientWrapper NewInstance(AndroidJavaObject javaObject) => new GamesClientWrapper(javaObject);

        public GamesClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<string> AppId => CallAsWrapper<TaskStringWrapper>("getAppId");

        public ITask<Void> SetPopupsPosition(int paramInt) => CallAsWrapper<TaskVoidWrapper>("setPopupsPosition", paramInt);
    }
}
