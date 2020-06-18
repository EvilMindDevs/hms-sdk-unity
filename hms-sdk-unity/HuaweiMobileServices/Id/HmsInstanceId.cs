namespace HuaweiMobileServices.Id
{

    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.aaid.HmsInstanceId
    public class HmsInstanceId : JavaObjectWrapper
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.aaid.HmsInstanceId");

        [UnityEngine.Scripting.Preserve]
        public HmsInstanceId(AndroidJavaObject javaObject) : base(javaObject) { }

        public static HmsInstanceId GetInstance() =>
            sJavaClass.CallStaticAsWrapper<HmsInstanceId>("getInstance", AndroidContext.ApplicationContext);

        public virtual string Id => CallAsString("getId");

        public virtual ITask<AAIDResult> AAID => CallAsWrapper<TaskJavaObjectWrapper<AAIDResult>>("getAAID");

        public virtual long CreationTime => Call<long>("getCreationTime");

        public virtual void DeleteAAID() => Call("deleteAAID");

        public virtual string GetToken(string paramString1, string paramString2) =>
            CallAsString("getToken", paramString1, paramString2);

        public virtual void DeleteToken(string paramString1, string paramString2) =>
            Call("deleteToken", paramString1, paramString2);

    }

}