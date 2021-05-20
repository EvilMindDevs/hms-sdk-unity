using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Push
{
    public class OpenDevice : JavaObjectWrapper
    {
        public OpenDevice(AndroidJavaObject javaObject) : base(javaObject) { }
    
        private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.opendevice.OpenDevice");
        public static OpenDeviceClient OpenDeviceClient() => androidJavaClass.CallStaticAsWrapper<OpenDeviceClient>("getOpenDeviceClient",AndroidContext.ApplicationContext);
    }
}
