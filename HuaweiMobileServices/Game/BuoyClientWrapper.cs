using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    internal class BuoyClientWrapper : JavaObjectWrapper, IBuoyClient
    {
        public BuoyClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public void HideFloatWindow() => Call("hideFloatWindow");

        public void ShowFloatWindow() => Call("showFloatWindow");
    }
}
