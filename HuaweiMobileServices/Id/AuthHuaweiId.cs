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
                    extensionScopes.AsJavaSet<AndroidJavaObject>(),
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

        public virtual string AvatarUri
        {
            // This is a Uri in the java object, so we need to extract the string from the Uri as well
            get => JavaObject.Call<AndroidJavaObject>("getAvatarUri").Call<AndroidJavaObject>("toString").AsString();
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
            get => JavaObject.Call<AndroidJavaObject>("getAuthorizedScopes").AsSet();
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


        public virtual Account HuaweiAccount
        {
            get
            {
                return TextUtils.isEmpty(this.m) ? null : new Account(this.m, "com.huawei");
            }
        }

        public virtual ISet<Scope> ExtensionScopes
        {
            get
            {
                return this.n;
            }
            set
            {
                this.n = value;
            }
        }


        public virtual string IdToken
        {
            get
            {
                return this.o;
            }
            set
            {
                this.o = value;
            }
        }


        public virtual long ExpirationTimeSecs
        {
            get
            {
                return this.p;
            }
            set
            {
                this.p = value;
            }
        }


        public virtual string GivenName
        {
            get
            {
                return this.q;
            }
            set
            {
                this.q = value;
            }
        }


        public virtual string FamilyName
        {
            get
            {
                return this.r;
            }
            set
            {
                this.r = value;
            }
        }

        public virtual string UnionId
        {
            get
            {
                return this.l;
            }
        }

        public virtual bool Expired
        {
            get
            {
                if (this.p > 300L)
                {
                    return (DateTimeHelper.CurrentUnixTimeMillis() / 1000L >= this.p - 300L);
                }
                return false;
            }
        }

        public virtual AuthHuaweiId RequestExtraScopes(IList<Scope> paramList)
        {
            if (a.b(paramList).booleanValue())
            {
                this.n.addAll(paramList);
            }
            return this;
        }

        public virtual ISet<Scope> RequestedScopes
        {
            get
            {
                HashSet<object> hashSet = new HashSet<object>(this.j);
                hashSet.addAll(this.n);
                return hashSet;
            }
        }

        public virtual string AvatarUriString
        {
            get
            {
                return this.d;
            }
            set
            {
                this.d = value;
            }
        }


        public virtual string AgeRange
        {
            get
            {
                return this.s;
            }
            set
            {
                this.s = value;
            }
        }

    }

}