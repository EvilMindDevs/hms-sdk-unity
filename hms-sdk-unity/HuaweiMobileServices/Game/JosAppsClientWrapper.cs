namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class JosAppsClientWrapper : JavaObjectWrapper, IJosAppsClient
    {

        [UnityEngine.Scripting.Preserve]
        public JosAppsClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<string> AppId
        {
            get
            {
                var javaTask = JavaObject.Call<AndroidJavaObject>("getAppId");
                return new TaskWrapper<string>(javaTask, AndroidJavaObjectExtensions.AsString);
            }
        }

        public void Init()
        {
            JavaObject.Call("init");
        }
    }
}
