using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location
{
    public class ActivityIdentification : JavaObjectWrapper
    {
        public ActivityIdentification(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityIdentification");

        public static ActivityIdentificationService GetService() =>
            javaClass.CallStaticAsWrapper<ActivityIdentificationService>("getService", AndroidContext.ActivityContext);
    }
}



