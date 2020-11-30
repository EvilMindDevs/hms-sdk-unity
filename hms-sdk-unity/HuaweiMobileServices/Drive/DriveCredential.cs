namespace HuaweiMobileServices.Drive
{
    using HuaweiMobileServices.Utils;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using UnityEngine;
    public class DriveCredential : JavaObjectWrapper
    {
        //[UnityEngine.Scripting.Preserve]
       // public DriveCredential(String unionId, AccessMethod method) : base("com.huawei.cloud.base.auth.DriveCredential", unionId, method) {}
        [UnityEngine.Scripting.Preserve]
        public DriveCredential(AndroidJavaObject javaObject) : base(javaObject) { }



        public void intercept(AndroidJavaObject request){
            Call("intercept", request);
        }

        public bool handleResponse(AndroidJavaObject request, AndroidJavaObject response, bool supportsRetry)
        {
            return Call<bool>("handleResponse", request, response, supportsRetry);
        }

        public void initialize(AndroidJavaObject request)
        {
            Call("initialize", request);
        }

        public String getUnionID()
        {

           return Call<String>("getUnionID");
           
        }

        public String getAccessToken()
        {
            return Call<String>("getAccessToken");
        }

        public DriveCredential setAccessToken(String accessToken)
        {
            DriveCredential a = CallAsWrapper<DriveCredential>("setAccessToken", accessToken);
            
            Debug.Log("setAccessTokenxxxx  " + a.Call<string>("toString"));

            return a;
        }

        public DriveCredential setExpiresInSeconds(long expiresIn)
        {
            return Call<DriveCredential>("setExpiresInSeconds", expiresIn);
        }

        public long getExpirationTimeMilliseconds()
        {
            return Call<long>("getExpirationTimeMilliseconds");
        }

        public bool refreshToken()
        {
            return Call<bool>("refreshToken");
        }

        public DriveCredential clone()
        {
            // CallAsWrapper

            return Call<DriveCredential>("clone");
        }

        public interface AccessMethod 
        {
            //TODO:IOException throw.

            String refreshToken();

        }
        

        public class Builder : JavaObjectWrapper
        {
            //TODO:fix
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
    
