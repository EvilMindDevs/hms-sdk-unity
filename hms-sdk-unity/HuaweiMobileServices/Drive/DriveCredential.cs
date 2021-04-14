namespace HuaweiMobileServices.Drive
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;
    public class DriveCredential : JavaObjectWrapper
    {
        
        public DriveCredential(AndroidJavaObject javaObject) : base(javaObject) { }

        public void Intercept(AndroidJavaObject request) => Call("intercept", request);

        public void Initialize(AndroidJavaObject request) => Call("initialize", request);

        public String GetUnionID() => Call<String>("getUnionID");

        public String GetAccessToken() => Call<String>("getAccessToken");

        public DriveCredential SetAccessToken(String accessToken) => CallAsWrapper<DriveCredential>("setAccessToken", accessToken);

        public DriveCredential SetExpiresInSeconds(long expiresIn) => CallAsWrapper<DriveCredential>("setExpiresInSeconds", expiresIn);

        public long GetExpirationTimeMilliseconds() => Call<long>("getExpirationTimeMilliseconds");

        public bool RefreshToken() => Call<bool>("refreshToken");

        public DriveCredential Clone() => CallAsWrapper<DriveCredential>("clone");

        public interface AccessMethod
        {
            String refreshToken();
        }

        public class Builder : JavaObjectWrapper
        {
            
            public Builder() : base("com.huawei.cloud.base.auth.DriveCredential$Builder") { }

            
            public Builder(String unionID, Func<String> refreshToken) : base("com.huawei.cloud.base.auth.DriveCredential$Builder", unionID, new AccessMethodWrapper(refreshToken)){}
           
            public DriveCredential Build() => CallAsWrapper<DriveCredential>("build");
        }

    }

}

