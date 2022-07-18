using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location
{
    public class ActivityIdentification : JavaObjectWrapper
    {
        public ActivityIdentification(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityIdentification");

        //TODO Not bu 2 metodun ismi değişti

        public static ActivityIdentificationService GetServiceWithActivity() =>
            javaClass.CallStaticAsWrapper<ActivityIdentificationService>("getService", AndroidContext.ActivityContext);

        public static ActivityIdentificationService GetServiceWithContext() =>
            javaClass.CallStaticAsWrapper<ActivityIdentificationService>("getService", AndroidContext.ApplicationContext);
    }
}



