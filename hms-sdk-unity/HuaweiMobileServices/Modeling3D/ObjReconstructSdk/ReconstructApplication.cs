using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk
{
    /// <summary>
    /// App information. To use the on-cloud 3D object reconstruction service, set an access token or API key for your app.
    /// Wrapper for com.huawei.hms.objreconstructsdk.ReconstructApplication
    /// <see cref="ReconstructApplication" link="https://developer.huawei.com/consumer/en/doc/development/graphics-References/reconstructapplication-0000001110787240"/>
    /// </summary>
    public class ReconstructApplication : JavaObjectWrapper
    {
        public ReconstructApplication(AndroidJavaObject javaObject) : base(javaObject)
        {
        }
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.objreconstructsdk.ReconstructApplication");
        public static explicit operator ReconstructApplication(AndroidJavaObject javaObject) => javaObject == null ? null : new ReconstructApplication(javaObject);

        public ReconstructApplication GetInstance() => sJavaClass.GetStaticAsWrapper<ReconstructApplication>("getInstance");
        public void SetAccessToken (string accessToken) => Call("setAccessToken", accessToken.AsJavaString());
        public void SetApiKey (string apiKey) => Call("setApiKey", apiKey.AsJavaString());

    }
}