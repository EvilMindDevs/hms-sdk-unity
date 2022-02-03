using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Void = HuaweiMobileServices.Utils.Void;

namespace HuaweiMobileServices.AuthService
{
    public class AGConnectUser : JavaObjectWrapper
    {
        
        public AGConnectUser(AndroidJavaObject javaObject) : base(javaObject) { }

        public bool IsAnonymous() => Call<bool>("isAnonymous");

        public string Uid => Call<string>("getUid"); 

        public string Email => Call<string>("getEmail"); 

        public string Phone => Call<string>("getPhone"); 

        public string DisplayName => Call<string>("getDisplayName"); 

        public string PhotoUrl => Call<string>("getPhotoUrl"); 

        public string ProviderId => Call<string>("getProviderId"); 

        public ITask<TokenResult> GetToken(bool paramBoolean) => CallAsWrapper<TaskJavaObjectWrapper<TokenResult>>("getToken", paramBoolean);

        public List<Map<string, string>> GetProviderInfo()
            => Call<List<Map<string, string>>>("getProviderInfo");

        public ITask<SignInResult> Link(AGConnectAuthCredential paramAGConnectAuthCredential) 
            => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("link", paramAGConnectAuthCredential);

        public ITask<SignInResult> Link(int provider)
            => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("link", AndroidContext.ActivityContext, provider);

        public ITask<SignInResult> Unlink(int paramInt)
            => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("unlink", paramInt);
        
        public ITask<Void> UpdateProfile(ProfileRequest paramProfileRequest) => CallAsWrapper<TaskVoidWrapper>("updateProfile", paramProfileRequest);
        
        public ITask<Void> UpdateEmail(string paramString1, string paramString2) 
            => CallAsWrapper<TaskVoidWrapper>("updateEmail", paramString1, paramString2);

        public ITask<Void> UpdateEmail(String paramString1, String paramString2, Locale paramLocale) 
            => CallAsWrapper<TaskVoidWrapper>("updateEmail", paramString1, paramString2, paramLocale);

        public ITask<Void> UpdatePhone(string paramString1, string paramString2, string paramString3) 
            => CallAsWrapper<TaskVoidWrapper>("updatePhone", paramString1, paramString2, paramString3);

        public ITask<Void> UpdatePhone(String paramString1, String paramString2, String paramString3, Locale paramLocale) 
            => CallAsWrapper<TaskVoidWrapper>("updatePhone", paramString1, paramString2, paramString3, paramLocale);

        public ITask<Void> UpdatePassword(string paramString1, string paramString2, int paramInt)
           => CallAsWrapper<TaskVoidWrapper>("updatePassword", paramString1, paramString2, paramInt);

        public string EmailVerified => Call<string>("getEmailVerified"); 

        public string PasswordSetted => Call<string>("getPasswordSetted"); 

        public ITask<AGConnectUserExtra> GetUserExtra() => CallAsWrapper<TaskJavaObjectWrapper<AGConnectUserExtra>>("getUserExtra");

        public ITask<SignInResult> Reauthenticate(AGConnectAuthCredential paramAGConnectAuthCredential)
            => CallAsWrapper<TaskJavaObjectWrapper<SignInResult>>("reauthenticate", paramAGConnectAuthCredential);
    }
}
