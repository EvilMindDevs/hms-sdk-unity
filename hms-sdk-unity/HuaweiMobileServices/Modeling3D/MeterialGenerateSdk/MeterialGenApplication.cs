using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.MeterialGenerateSdk
{
    /// <summary>
    /// App information. To use the on-cloud material generation service, set an access token or API key for your app.
    /// Wrapper for com.huawei.hms.materialgeneratesdk.MaterialGenApplication.
    /// <see cref=" MeterialGenApplication" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/materialgenapplication-0000001194908481"/>
    /// </summary>
    public class MeterialGenApplication : JavaObjectWrapper
    {
        public MeterialGenApplication(AndroidJavaObject javaObject) : base(javaObject)
        {
        }
        private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.meterialgeneratesdk.MeterialGenApplication");
        public static explicit operator MeterialGenApplication(AndroidJavaObject javaObject) => javaObject == null ? null : new MeterialGenApplication(javaObject);

        /// <summary>
        /// Obtains the default app instance.
        /// </summary>
        /// <returns>Default app instance.</returns>
        public MeterialGenApplication GetInstance() => sJavaClass.GetStaticAsWrapper<MeterialGenApplication>("getInstance");
        /// <summary>
        /// Sets the access token for your app.
        /// </summary>
        /// <param name="accessToken">Access token for your app.</param>
        public void SetAccessToken (string accessToken) => Call("setAccessToken", accessToken.AsJavaString());
        /// <summary>
        /// Sets the API key for your app.
        /// </summary>
        /// <param name="apiKey">API key for your app.</param>
        public void SetApiKey (string apiKey) => Call("setApiKey", apiKey.AsJavaString());
    }
}