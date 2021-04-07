using HuaweiMobileServices.Utils;
using UnityEngine;
namespace HuaweiMobileServices.Id
{ 
    public class AccountIcon : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public AccountIcon(AndroidJavaObject javaObject) : base(javaObject) { }
        public AndroidBitmap Bitmap  => CallAsWrapper<AndroidBitmap>("getIcon");
    }
}
