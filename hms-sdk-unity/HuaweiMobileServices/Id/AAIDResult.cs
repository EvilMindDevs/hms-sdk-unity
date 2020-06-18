namespace HuaweiMobileServices.Id
{

    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.aaid.entity.AAIDResult
    public class AAIDResult : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AAIDResult(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string Id => CallAsString("getId");

    }

}