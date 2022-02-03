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

        public AuthAccount build(string openId, string uid, string displayName, string photoUri, string accessToken, string serviceCountryCode, int status, int gender, Set<Scope> scopes, string serverAuthCode, string unionId, string countryCode, int carrierId) =>
             CallAsWrapper<AuthAccount>("createDefault", openId, uid, displayName, photoUri, accessToken, serviceCountryCode, status, gender, scopes, serverAuthCode, unionId, countryCode, carrierId);

        public string Uid => CallAsString("getUid");

        public int Status => Call<int>("getStatus");

        public string CountryCode => CallAsString("getCountryCode");

        public ISet<Scope> ExtensionScopes => Call<AndroidJavaObject>("getExtensionScopes").AsSetFromWrappable<Scope>();

        public long ExpirationTimeSecs => Call<long>("getExpirationTimeSecs");

        public bool Expired => Call<bool>("isExpired");

        public AuthAccount RequestExtraScopes(IList<Scope> list) => CallAsWrapper<AuthAccount>("requestExtraScopes");

        public ISet<Scope> RequestedScopes => Call<AndroidJavaObject>("getRequestedScopes").AsSetFromWrappable<Scope>();

        public AndroidAccount HuaweiAccount => CallAsWrapper<AndroidAccount>("getAccount", AndroidContext.ActivityContext);

        public string DisplayName => CallAsString("getDisplayName");

        public string AccessToken => CallAsString("getAccessToken");

        public string Email => CallAsString("getEmail");

        public string GivenName => CallAsString("getGivenName");

        public string FamilyName => CallAsString("getFamilyName");

        public int Gender => Call<int>("getGender");

        public ISet<Scope> AuthorizedScopes => JavaObject.Call<AndroidJavaObject>("getAuthorizedScopes").AsSetFromWrappable<Scope>();

        public string IdToken => CallAsString("getIdToken");

        public string AvatarUriString => CallAsString("getAvatarUriString");

        public string AuthorizationCode => CallAsString("getAuthorizationCode");

        public string ServiceCountryCode => CallAsString("getServiceCountryCode");

        public string UnionId => CallAsString("getUnionId");

        public string OpenId => CallAsString("getOpenId");

        public int AccountFlag => Call<int>("getAccountFlag");

        public int CarrierId => Call<int>("getCarrierId");

    }
}