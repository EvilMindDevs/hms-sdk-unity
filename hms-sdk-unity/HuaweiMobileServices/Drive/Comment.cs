using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class Comment : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Comment(AndroidJavaObject javaObject) : base(javaObject) { }
    }
}
