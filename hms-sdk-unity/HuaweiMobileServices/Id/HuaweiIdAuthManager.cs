using System.Collections.Generic;

namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.hwid.HuaweiIdAuthManager
    public static class HuaweiIdAuthManager
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.support.hwid.HuaweiIdAuthManager");

        public static HuaweiIdAuthService GetService(HuaweiIdAuthParams paramHuaweiIdAuthParams) =>
            sJavaClass.CallStaticAsWrapper<HuaweiIdAuthService>("getService", AndroidContext.ActivityContext, paramHuaweiIdAuthParams);

        public static ITask<AuthHuaweiId> ParseAuthResultFromIntent(AndroidIntent paramIntent) =>
            sJavaClass.CallStaticAsWrapper<TaskJavaObjectWrapper<AuthHuaweiId>>("parseAuthResultFromIntent", paramIntent);

        public static AuthHuaweiId AuthResult => sJavaClass.CallStaticAsWrapper<AuthHuaweiId>("getAuthResult");

        public static AuthHuaweiId GetAuthResultWithScopes(IList<Scope> paramList) =>
            sJavaClass.CallStaticAsWrapper<AuthHuaweiId>("getAuthResultWithScopes", paramList.AsJavaListFromWrapper());

    }

}