namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    internal class BuoyClientWrapper : JavaObjectWrapper, IBuoyClient
    {
        public BuoyClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public void HideFloatWindow() => Call("hideFloatWindow");

        public void ShowFloatWindow() => Call("showFloatWindow");
    }
}
