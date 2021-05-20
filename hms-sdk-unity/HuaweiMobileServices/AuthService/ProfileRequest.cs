using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.AuthService
{
    public class ProfileRequest : JavaObjectWrapper
    {
        
        public ProfileRequest(AndroidJavaObject javaObject) : base(javaObject) { }
        public ProfileRequest() : base("com.huawei.agconnect.auth.ProfileRequest") { }

        public string DisplayName => Call<string>("getDisplayName"); 

        public string PhotoUrl => Call<string>("getPhotoUrl"); 

        public class Builder : JavaObjectWrapper
        {
            
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder() : base("com.huawei.agconnect.auth.ProfileRequest$Builder") { }

            public Builder SetDisplayName(string displayName) => CallAsWrapper<Builder>("setDisplayName", displayName);
            public Builder SetPhotoUrl(string photoUrl) => CallAsWrapper<Builder>("setPhotoUrl", photoUrl);
            public ProfileRequest Build() => CallAsWrapper<ProfileRequest>("build");
        }
    }
}
