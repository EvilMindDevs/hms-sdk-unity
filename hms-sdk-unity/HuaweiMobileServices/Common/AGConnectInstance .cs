using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Common
{
    public class AGConnectInstance : JavaObjectWrapper
    {
        private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.AGConnectInstance");

        public AGConnectInstance(AndroidJavaObject javaObject) : base(javaObject) { }
        public static void Initialize() => javaClass.CallStatic("initialize", AndroidContext.ActivityContext);
        public static void Initialize(AGConnectOptionsBuilder optionsBuilder) => javaClass.CallStatic("initialize", AndroidContext.ActivityContext, optionsBuilder.JavaObject);
        public static AGConnectInstance BuildInstance(AGConnectOptionsBuilder optionsBuilder) => javaClass.CallStaticAsWrapper<AGConnectInstance>("buildInstance", optionsBuilder.JavaObject);
        public static AGConnectInstance GetInstance() => javaClass.CallStaticAsWrapper<AGConnectInstance>("getInstance");
        public static AGConnectOptions GetOptions() => javaClass.CallStaticAsWrapper<AGConnectOptions>("getOptions");

    }
}
