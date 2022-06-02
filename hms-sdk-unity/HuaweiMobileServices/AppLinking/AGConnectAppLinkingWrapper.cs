using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class AGConnectAppLinkingWrapper : JavaObjectWrapper, IAGConnectAppLinking
    {
        public AGConnectAppLinkingWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<ResolvedLinkData> GetAppLinking() => CallAsWrapper<TaskJavaObjectWrapper<ResolvedLinkData>>("getAppLinking", AndroidContext.ActivityContext);

        public void SetCustomReferrer(IReferrerProvider provider) => Call("setCustomReferrer", provider);
    }
}
