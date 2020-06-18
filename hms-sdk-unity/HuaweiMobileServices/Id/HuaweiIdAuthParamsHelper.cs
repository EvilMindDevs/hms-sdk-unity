namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.hwid.request.HuaweiIdAuthParamsHelper
    public class HuaweiIdAuthParamsHelper : JavaObjectWrapper
    {

        private static readonly string CLASS_NAME = "com.huawei.hms.support.hwid.request.HuaweiIdAuthParamsHelper";

        [UnityEngine.Scripting.Preserve]
        public HuaweiIdAuthParamsHelper(AndroidJavaObject javaObject) : base(javaObject) { }

        public HuaweiIdAuthParamsHelper() : base(CLASS_NAME) { }

        public HuaweiIdAuthParamsHelper(HuaweiIdAuthParams huaweiIdAuthParams) : base(CLASS_NAME, huaweiIdAuthParams.JavaObject) { }

        public HuaweiIdAuthParamsHelper SetUid()
        {
            JavaObject = Call<AndroidJavaObject>("setUid");
            return this;
        }

        public HuaweiIdAuthParamsHelper SetAuthorizationCode()
        {
            JavaObject = Call<AndroidJavaObject>("setAuthorizationCode");
            return this;
        }

        public HuaweiIdAuthParamsHelper SetAccessToken()
        {
            JavaObject = Call<AndroidJavaObject>("setAccessToken");
            return this;
        }

        public HuaweiIdAuthParamsHelper SetScopeList(IList<Scope> list)
        {
            JavaObject = Call<AndroidJavaObject>("setScopeList", list.AsJavaListFromWrapper());
            return this;
        }

        internal HuaweiIdAuthParamsHelper SetScope(Scope scope)
        {
            JavaObject = Call<AndroidJavaObject>("setScope", scope.JavaObject);
            return this;
        }

        public HuaweiIdAuthParams CreateParams()
        {
            var javaObject = Call<AndroidJavaObject>("createParams");
            return new HuaweiIdAuthParams(javaObject);
        }

        public HuaweiIdAuthParamsHelper SetEmail()
        {
            JavaObject = Call<AndroidJavaObject>("setEmail");
            return this;
        }

        public HuaweiIdAuthParamsHelper SetId()
        {
            JavaObject = Call<AndroidJavaObject>("setId");
            return this;
        }

        public HuaweiIdAuthParamsHelper SetIdToken()
        {
            JavaObject = Call<AndroidJavaObject>("setIdToken");
            return this;
        }

        public HuaweiIdAuthParamsHelper SetProfile()
        {
            JavaObject = Call<AndroidJavaObject>("setProfile");
            return this;
        }

        public HuaweiIdAuthParamsHelper SetShippingAddress()
        {
            JavaObject = Call<AndroidJavaObject>("setProfile");
            return this;
        }

        public HuaweiIdAuthParamsHelper SetMobileNumber()
        {
            JavaObject = Call<AndroidJavaObject>("setMobileNumber");
            return this;
        }
    }

}