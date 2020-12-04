namespace HuaweiMobileServices.Drive
{
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;
    public class DriveCredential : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public DriveCredential(AndroidJavaObject javaObject) : base(javaObject) { }


        public void Intercept(AndroidJavaObject request)
        {
            Call("intercept", request);
        }

        public bool HandleResponse(AndroidJavaObject request, AndroidJavaObject response, bool supportsRetry)
        {
            return Call<bool>("handleResponse", request, response, supportsRetry);
        }

        public void Initialize(AndroidJavaObject request)
        {
            Call("initialize", request);
        }

        public String GetUnionID()
        {

            return Call<String>("getUnionID");

        }

        public String GetAccessToken()
        {
            return Call<String>("getAccessToken");
        }

        public DriveCredential SetAccessToken(String accessToken)
        {
            return CallAsWrapper<DriveCredential>("setAccessToken", accessToken);

        }

        public DriveCredential SetExpiresInSeconds(long expiresIn)
        {
            return Call<DriveCredential>("setExpiresInSeconds", expiresIn);
        }

        public long GetExpirationTimeMilliseconds()
        {
            return Call<long>("getExpirationTimeMilliseconds");
        }

        public bool RefreshToken()
        {
            return Call<bool>("refreshToken");
        }

        public DriveCredential Clone()
        {

            return Call<DriveCredential>("clone");
        }

        public interface AccessMethod
        {

            String refreshToken();

        }

        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder() : base("com.huawei.cloud.base.auth.DriveCredential$Builder") { }

            [UnityEngine.Scripting.Preserve]
            public Builder(String unionID, Func<String> refreshToken) : base("com.huawei.cloud.base.auth.DriveCredential$Builder", unionID, new AccessMethodWrapper(refreshToken))
            {

            }
            public DriveCredential Build()
            {
                return CallAsWrapper<DriveCredential>("build");
            }
        }

    }

}

