namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class JosAppsClientWrapper : JavaObjectWrapper, IJosAppsClient
    {

        internal JosAppsClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<string> AppId
        {
            get
            {
                var javaTask = JavaObject.Call<AndroidJavaObject>("getAppId");
                return new TaskWrapper<string>(javaTask, AndroidTypes.AsString);
            }
        }

        public void Init()
        {
            JavaObject.Call("init");
        }
    }
}
