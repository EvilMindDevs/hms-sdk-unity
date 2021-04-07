namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.hwid.request.AccountAuthParamsHelper
    public class AccountAuthParamsHelper : JavaObjectWrapper
    {

        private static readonly string CLASS_NAME = "com.huawei.hms.support.account.request.AccountAuthParamsHelper";

        [UnityEngine.Scripting.Preserve]
        public AccountAuthParamsHelper(AndroidJavaObject javaObject) : base(javaObject) { }

        public AccountAuthParamsHelper() : base(CLASS_NAME) { }

        public AccountAuthParamsHelper(AccountAuthParams huaweiIdAuthParams) : base(CLASS_NAME, huaweiIdAuthParams.JavaObject) { }

        public AccountAuthParamsHelper SetUid()
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setUid");
        }

        public AccountAuthParamsHelper SetAuthorizationCode()
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setAuthorizationCode");
        }

        public AccountAuthParamsHelper SetAccessToken()
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setAccessToken");
        }

        public AccountAuthParamsHelper SetScopeList(IList<Scope> list)
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setScopeList", list.AsJavaListFromWrapper());
        }

        public AccountAuthParamsHelper SetScope(Scope scope)
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setScope", scope.JavaObject);
        }

        public AccountAuthParams CreateParams()
        {
            return CallAsWrapper<AccountAuthParams>("createParams");
        }

        public AccountAuthParamsHelper SetEmail()
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setEmail");
        }

        public AccountAuthParamsHelper SetId()
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setId");
        }

        public AccountAuthParamsHelper SetIdToken()
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setIdToken");
        }

        public AccountAuthParamsHelper SetProfile()
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setProfile");
        }

        public AccountAuthParamsHelper SetMobileNumber()
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setMobileNumber");
        }
        public AccountAuthParamsHelper SetDialogAuth()
        {
            return CallAsWrapper<AccountAuthParamsHelper>("setDialogAuth");
        }
    }

}