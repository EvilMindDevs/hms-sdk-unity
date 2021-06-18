using System.Collections.Generic;

namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.account.result.AuthAccount
    public class AuthAccount : JavaObjectWrapper
    {
        public AuthAccount(AndroidJavaObject javaObject) : base(javaObject) { }

        public AuthAccount CreateDefault => CallAsWrapper<AuthAccount>("createDefault");

        public AuthAccount build(string openId, string uid, string displayName, string photoUri, string accessToken, string serviceCountryCode, int status, int gender, Set<Scope> scopes, string serverAuthCode, string unionId, string countryCode) =>
             CallAsWrapper<AuthAccount>("createDefault", openId, uid, displayName, photoUri, accessToken, serviceCountryCode, status, gender, scopes, serverAuthCode, unionId, countryCode);

        public virtual string Uid => CallAsString("getUid");

        public virtual int Status => Call<int>("getStatus");

        public virtual string CountryCode => CallAsString("getCountryCode");

        public virtual ISet<Scope> ExtensionScopes => Call<AndroidJavaObject>("getExtensionScopes").AsSetFromWrappable<Scope>();

        public virtual long ExpirationTimeSecs => Call<long>("getExpirationTimeSecs");

        public virtual bool Expired => Call<bool>("isExpired");

        public virtual AuthAccount RequestExtraScopes(IList<Scope> list) => CallAsWrapper<AuthAccount>("requestExtraScopes");

        public virtual ISet<Scope> RequestedScopes => Call<AndroidJavaObject>("getRequestedScopes").AsSetFromWrappable<Scope>();

        public virtual AndroidAccount HuaweiAccount => CallAsWrapper<AndroidAccount>("getAccount");

        public virtual string DisplayName => CallAsString("getDisplayName");

        public virtual string AccessToken => CallAsString("getAccessToken");

        public virtual string Email => CallAsString("getEmail");

        public virtual string GivenName => CallAsString("getGivenName");

        public virtual string FamilyName => CallAsString("getFamilyName");

        public virtual int Gender => Call<int>("getGender");

        public virtual ISet<Scope> AuthorizedScopes => JavaObject.Call<AndroidJavaObject>("getAuthorizedScopes").AsSetFromWrappable<Scope>();

        public virtual string IdToken => CallAsString("getIdToken");

        public virtual string AvatarUriString => CallAsString("getAvatarUriString");

        public virtual string AuthorizationCode => CallAsString("getAuthorizationCode");

        public virtual string ServiceCountryCode => CallAsString("getServiceCountryCode");

        public virtual string UnionId => CallAsString("getUnionId");

        public virtual string OpenId => CallAsString("getOpenId");

        public virtual int AccountFlag => Call<int>("getAccountFlag");

    }
}