using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Game
{

    using HuaweiMobileServices.Utils;
    using UnityEngine;
    using HuaweiMobileServices.Base;

    internal class GamesClientWrapper : JavaObjectWrapper, IGamesClient
    {

        public GamesClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<string> AppId => CallAsWrapper<TaskStringWrapper>("getAppId");

        public ITask<Void> SetPopupsPosition(int paramInt) => CallAsWrapper<TaskVoidWrapper>("setPopupsPosition", paramInt);
    }
}
