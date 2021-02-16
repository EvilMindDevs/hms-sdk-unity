using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.CloudDB
{
    public class ListenerHandler : JavaObjectWrapper
    {
        public ListenerHandler(AndroidJavaObject javaObject) : base(javaObject) { }

        public void Remove() => Call("remove");
    }
}
