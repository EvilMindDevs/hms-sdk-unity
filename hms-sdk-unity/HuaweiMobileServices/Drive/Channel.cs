using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class Channel : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Channel(AndroidJavaObject javaObject) : base(javaObject) { }
    }
}
