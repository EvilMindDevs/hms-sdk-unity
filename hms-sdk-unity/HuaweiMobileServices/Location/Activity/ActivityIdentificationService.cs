using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;


namespace HuaweiMobileServices.Location
{
    public class ActivityIdentificationService : JavaObjectWrapper
    {
        public ActivityIdentificationService(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.ActivityIdentificationService");

        public ITask<Void> CreateActivityConversionUpdates(ActivityConversionRequest activityConversionRequest, AndroidPendingIntent pendingIntent)
            => CallAsWrapper<TaskVoidWrapper>("createActivityConversionUpdates", activityConversionRequest, pendingIntent);

        public ITask<Void> CreateActivityIdentificationUpdates(long intervalMillis, AndroidPendingIntent callbackIntent)
            => CallAsWrapper<TaskVoidWrapper>("createActivityIdentificationUpdates", intervalMillis, callbackIntent);

        public ITask<Void> DeleteActivityConversionUpdates(AndroidPendingIntent pendingIntent)
          => CallAsWrapper<TaskVoidWrapper>("deleteActivityConversionUpdates", pendingIntent);

        public ITask<Void> DeleteActivityIdentificationUpdates(AndroidPendingIntent callbackIntent)
          => CallAsWrapper<TaskVoidWrapper>("deleteActivityIdentificationUpdates", callbackIntent);
    }

}