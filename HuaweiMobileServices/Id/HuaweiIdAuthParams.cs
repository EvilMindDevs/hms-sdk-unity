namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.hwid.request.HuaweiIdAuthParams
    public class HuaweiIdAuthParams : JavaObjectWrapper
    {

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.support.hwid.request.HuaweiIdAuthParams");

        public static readonly Scope SCOPE_GAMES = new Scope("https://www.huawei.com/auth/games");

        public static readonly HuaweiIdAuthParams DEFAULT_AUTH_REQUEST_PARAM = (new HuaweiIdAuthParamsHelper()).SetId().SetProfile().CreateParams();

        public static readonly HuaweiIdAuthParams DEFAULT_AUTH_REQUEST_PARAM_GAME = (new HuaweiIdAuthParamsHelper()).SetScope(SCOPE_GAMES).CreateParams();

        public HuaweiIdAuthParams(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual IList<Scope> RequestScopeList
        {
            get => CallAsWrapperList<Scope>("getRequestScopeList");
        }

        public virtual IList<PermissionInfo> PermissionInfos
        {
            get => CallAsWrapperList<PermissionInfo>("getPermissionInfos");
        }

        public virtual string ToJson() => CallAsString("toJson");

        public static HuaweiIdAuthParams FromJson(string json) =>
            sJavaClass.CallStaticAsWrapper<HuaweiIdAuthParams>("fromJson", json.AsJavaString());

        public virtual Scope[] ScopeArray
        {
            get => CallAsWrapperArray<Scope>("getScopeArray");
        }
    }

}