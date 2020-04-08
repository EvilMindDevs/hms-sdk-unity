namespace HuaweiMobileServices.Id
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System.Collections.Generic;
    using UnityEngine;

    // Wrapper for com.huawei.hms.support.hwid.result.AuthHuaweiId
    public class AuthHuaweiId : JavaObjectWrapper
    {

        private static readonly string CLASS_NAME = "com.huawei.hms.support.hwid.result.AuthHuaweiId";

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public AuthHuaweiId() : base(CLASS_NAME) { }

        public AuthHuaweiId(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AuthHuaweiId CreateDefault() => 
            Build(null, null, null, null, null, null, 0, -1, new HashSet<Scope>(), null, null, null);

        public static AuthHuaweiId Build(
                string openId,
                string uid, 
                string displayName,
                string avatarUriString, 
                string accessToken, 
                string serviceCountryCode, 
                int status, 
                int gender, 
                ISet<Scope> extensionScopes, 
                string authorizationCode, 
                string unionId, 
                string countryCode
            )
        {
            var javaObject = sJavaClass.CallStatic<AndroidJavaObject>(
                    "build",
                    openId.AsJavaString(),
                    uid.AsJavaString(),
                    displayName.AsJavaString(),
                    avatarUriString.AsJavaString(),
                    accessToken.AsJavaString(),
                    serviceCountryCode.AsJavaString(),
                    status,
                    gender,
                    extensionScopes.AsJavaSetFromJavaObjectWrapper(),
                    authorizationCode.AsJavaString(),
                    unionId.AsJavaString(),
                    countryCode.AsJavaString()
                );
            return new AuthHuaweiId(javaObject);
        }

        public static AuthHuaweiId FromJson(string aString) 
        {
            var javaObject = sJavaClass.CallStatic<AndroidJavaObject>("fromJson", aString.AsJavaString());
            return new AuthHuaweiId(javaObject);
        }

        public virtual string ToJson() => JavaObject.Call<AndroidJavaObject>("toJson").AsString();

        public virtual string Uid
        {
            get => JavaObject.Call<AndroidJavaObject>("getUid").AsString();
        }

        public virtual string OpenId
        {
            get => JavaObject.Call<AndroidJavaObject>("getOpenId").AsString();
        }

        public virtual string DisplayName
        {
            get => JavaObject.Call<AndroidJavaObject>("getDisplayName").AsString();
        }

        public virtual string AccessToken
        {
            get => JavaObject.Call<AndroidJavaObject>("getAccessToken").AsString();
        }

        public virtual int Status
        {
            get => JavaObject.Call<int>("getStatus");
        }

        public virtual int Gender
        {
            get => JavaObject.Call<int>("getGender");
        }

        public virtual ISet<Scope> AuthorizedScopes
        {
            get => JavaObject.Call<AndroidJavaObject>("getAuthorizedScopes")
                    .AsSet<AndroidJavaObject>()
                    .Map((javaScope) => new Scope(javaScope));
        }

        public virtual string ServiceCountryCode
        {
            get => JavaObject.Call<AndroidJavaObject>("getServiceCountryCode").AsString();
        }

        public virtual string CountryCode
        {
            get => JavaObject.Call<AndroidJavaObject>("getCountryCode").AsString();
        }

        public virtual string AuthorizationCode
        {
            get => JavaObject.Call<AndroidJavaObject>("getAuthorizationCode").AsString();
        }

        public virtual string Email
        {
            get => JavaObject.Call<AndroidJavaObject>("getEmail").AsString();
        }


        public virtual AndroidAccountWrapper HuaweiAccount
        {
            get
            {
                var javaObject = JavaObject.Call<AndroidJavaObject>("getHuaweiAccount");
                return new AndroidAccountWrapper(javaObject);
            }
        }

        public virtual ISet<Scope> ExtensionScopes
        {
            get => JavaObject.Call<AndroidJavaObject>("getExtensionScopes")
                    .AsSet<AndroidJavaObject>()
                    .Map((javaScope) => new Scope(javaScope));
        }


        public virtual string IdToken
        {
            get => JavaObject.Call<AndroidJavaObject>("getIdToken").AsString();
        }


        public virtual long ExpirationTimeSecs
        {
            get => JavaObject.Call<long>("getExpirationTimeSecs");
        }


        public virtual string GivenName
        {
            get => JavaObject.Call<AndroidJavaObject>("getGivenName").AsString();
        }


        public virtual string FamilyName
        {
            get => JavaObject.Call<AndroidJavaObject>("getFamilyName").AsString();
        }

        public virtual string UnionId
        {
            get => JavaObject.Call<AndroidJavaObject>("getUnionId").AsString();
        }

        public virtual bool Expired
        {
            get => JavaObject.Call<bool>("getExpired");
        }

        public virtual AuthHuaweiId RequestExtraScopes(IList<Scope> list)
        {
            var javaList = list.AsJavaListFromJavaObjectWrapper();
            var authHuaweiIdJava = JavaObject.Call<AndroidJavaObject>("getRequestExtraScopes", javaList);
            return new AuthHuaweiId(authHuaweiIdJava);
        }

        public virtual ISet<Scope> RequestedScopes
        {
            get => JavaObject.Call<AndroidJavaObject>("getRequestedScopes")
                    .AsSet<AndroidJavaObject>()
                    .Map((javaScope) => new Scope(javaScope));
        }

        public virtual string AvatarUriString
        {
            get => JavaObject.Call<AndroidJavaObject>("getAvatarUriString").AsString();
        }

        public virtual string AgeRange
        {
            get => JavaObject.Call<AndroidJavaObject>("getAgeRange").AsString();
        }

    }

}