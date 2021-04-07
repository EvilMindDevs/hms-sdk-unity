using System;
using System.Threading.Tasks;

namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;
    public class ReadSmsManager : JavaObjectWrapper
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.support.sms.ReadSmsManager");

        [UnityEngine.Scripting.Preserve]
        public ReadSmsManager(AndroidJavaObject javaObject) : base(javaObject) { }

        public static ITask<Void> StartActivity => sJavaClass.CallStaticAsWrapper<TaskVoidWrapper>("start", AndroidContext.ActivityContext);
        public static ITask<Void> StartwithContext => sJavaClass.CallStaticAsWrapper<TaskVoidWrapper>("start", AndroidContext.ApplicationContext);
        public static ITask<Void> StartConsent(String phoneNumber) => sJavaClass.CallStaticAsWrapper<TaskVoidWrapper>("startConsent", AndroidContext.ActivityContext, phoneNumber);

    }
}

