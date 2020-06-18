using System.Collections.Generic;

namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.hwid.result.AuthHuaweiId
    public class AuthHuaweiId : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public AuthHuaweiId(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual string Uid => CallAsString("getUid");

        public virtual string OpenId => CallAsString("getOpenId");

        public virtual string DisplayName => CallAsString("getDisplayName");

        public virtual string AccessToken => CallAsString("getAccessToken");

        public virtual int Status => Call<int>("getStatus");

        public virtual int Gender => Call<int>("getGender");

        public virtual ISet<Scope> AuthorizedScopes =>
            JavaObject.Call<AndroidJavaObject>("getAuthorizedScopes").AsSetFromWrappable<Scope>();

        public virtual string ServiceCountryCode => CallAsString("getServiceCountryCode");

        public virtual string CountryCode => CallAsString("getCountryCode");

        public virtual string AuthorizationCode => CallAsString("getAuthorizationCode");

        public virtual string Email => CallAsString("getEmail");

        public virtual AndroidAccount HuaweiAccount => CallAsWrapper<AndroidAccount>("getHuaweiAccount");

        public virtual ISet<Scope> ExtensionScopes => Call<AndroidJavaObject>("getExtensionScopes").AsSetFromWrappable<Scope>();

        public virtual string IdToken => CallAsString("getIdToken");

        public virtual long ExpirationTimeSecs => Call<long>("getExpirationTimeSecs");

        public virtual string GivenName => CallAsString("getGivenName");

        public virtual string FamilyName => CallAsString("getFamilyName");

        public virtual string UnionId => CallAsString("getUnionId");

        public virtual bool Expired => Call<bool>("isExpired");

        public virtual AuthHuaweiId RequestExtraScopes(IList<Scope> list) => CallAsWrapper<AuthHuaweiId>("getRequestExtraScopes");

        public virtual ISet<Scope> RequestedScopes => Call<AndroidJavaObject>("getRequestedScopes").AsSetFromWrappable<Scope>();

        public virtual string AvatarUriString => CallAsString("getAvatarUriString");

        public virtual string AgeRange => CallAsString("getAgeRange");

    }

}