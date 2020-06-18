namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class BuoyClientWrapper : JavaObjectWrapper, IBuoyClient
    {

        [UnityEngine.Scripting.Preserve]
        public BuoyClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public void HideFloatWindow() => Call("hideFloatWindow");

        public void ShowFloatWindow() => Call("showFloatWindow");
    }
}
