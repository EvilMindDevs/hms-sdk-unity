namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.hwid.request.AccountAuthParams
    public class AccountAuthParams : JavaObjectWrapper
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.support.account.request.AccountAuthParams");

        public static readonly Scope SCOPE_GAMES = new Scope("https://www.huawei.com/auth/games");

        public static readonly AccountAuthParams DEFAULT_AUTH_REQUEST_PARAM =
            (new AccountAuthParamsHelper()).SetId().SetProfile().CreateParams();

        public static readonly AccountAuthParams DEFAULT_AUTH_REQUEST_PARAM_GAME =
            (new AccountAuthParamsHelper()).SetScope(SCOPE_GAMES).CreateParams();

        [UnityEngine.Scripting.Preserve]
        public AccountAuthParams(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual IList<Scope> RequestScopeList => CallAsWrapperList<Scope>("getRequestScopeList");

        public virtual IList<PermissionInfo> PermissionInfos => CallAsWrapperList<PermissionInfo>("getPermissionInfos");

        public virtual Scope[] ScopeArray => CallAsWrapperArray<Scope>("getScopeArray");

    }

}