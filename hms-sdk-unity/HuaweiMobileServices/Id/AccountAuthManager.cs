using System.Collections.Generic;

namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.hwid.AccountAuthManager
    public static class AccountAuthManager
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.support.account.AccountAuthManager");

        public static AccountAuthService GetService(AccountAuthParams paramHuaweiIdAuthParams) =>
            sJavaClass.CallStaticAsWrapper<AccountAuthService>("getService", AndroidContext.ActivityContext, paramHuaweiIdAuthParams);

       public static ITask<AuthAccount> ParseAuthResultFromIntent(AndroidIntent paramIntent) =>
            sJavaClass.CallStaticAsWrapper<TaskJavaObjectWrapper<AuthAccount>>("parseAuthResultFromIntent", paramIntent);

        public static AuthAccount AuthResult => sJavaClass.CallStaticAsWrapper<AuthAccount>("getAuthResult");

        public static AuthAccount GetAuthResultWithScopes(IList<Scope> paramList) =>
            sJavaClass.CallStaticAsWrapper<AuthAccount>("getAuthResultWithScopes", paramList.AsJavaListFromWrapper());

    }

}