using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk
{
    /// <summary>
    /// App information. To use the on-cloud 3D object reconstruction service, set an access token or API key for your app.
    /// </summary>
    public class ReconstructApplication : JavaObjectWrapper
    {
        public ReconstructApplication(AndroidJavaObject javaObject) : base(javaObject)
        {
        }
        //Not necessary to implement this because class name is the same as the java class name
        //private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.objreconstructsdk.ReconstructApplication");
        public static explicit operator ReconstructApplication(AndroidJavaObject javaObject) => javaObject == null ? null : new ReconstructApplication(javaObject);

        public string AppName => CallAsString("getAppName");
        public ReconstructApplication GetInstance() => CallStatic<ReconstructApplication>("getInstance");
        public void SetAccessToken (string accessToken) => Call("setAccessToken", accessToken);
        public void SetApiKey (string apiKey) => Call("setApiKey", apiKey);
        public void SetAppId (string appId) => Call("setAppId", appId);

    }
}