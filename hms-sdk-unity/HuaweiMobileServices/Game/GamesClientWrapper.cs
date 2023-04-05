namespace HuaweiMobileServices.Game
{

    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class GamesClientWrapper : JavaObjectWrapper, IGamesClient
    {
        public GamesClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<string> AppId => CallAsWrapper<TaskStringWrapper>("getAppId");

        public ITask<Void> SetPopupsPosition(int paramInt) => CallAsWrapper<TaskVoidWrapper>("setPopupsPosition", paramInt);

        public ITask<bool> CancelGameService() => CallAsWrapper<TaskPrimitive<bool>>("cancelGameService");
    }
}
