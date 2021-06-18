using HuaweiMobileServices.Utils;
using UnityEngine;
namespace HuaweiMobileServices.Id
{ 
    public class AccountIcon : JavaObjectWrapper
    {
        
        public AccountIcon(AndroidJavaObject javaObject) : base(javaObject) { }
        public AndroidBitmap Bitmap  => CallAsWrapper<AndroidBitmap>("getIcon");
    }
}
