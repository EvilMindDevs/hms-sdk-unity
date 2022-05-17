namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class JosAppsClientWrapper : JavaObjectWrapper, IJosAppsClient
    {
        public JosAppsClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<string> AppId
        {
            get
            {
                var javaTask = JavaObject.Call<AndroidJavaObject>("getAppId");
                return new TaskWrapper<string>(javaTask, AndroidJavaObjectExtensions.AsString);
            }
        }

        public ITask<Void> Init(AppParams appParams)
        {
            var javaTask = JavaObject.Call<AndroidJavaObject>("init", appParams.JavaObject);
            return new TaskVoidWrapper(javaTask);
        }
    }
}
