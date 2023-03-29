
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ModelingCaptureSdk
{
    /// <summary>
    /// Wrapper for com.huawei.hms.modeling3dcapturesdk.Modeling3dCaptureImageEngine
    /// <see cref="Modeling3dCaptureImageEngine" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/captureimageengine-0000001322733925"/>
    /// </summary>
    public class Modeling3dCaptureImageEngine: JavaObjectWrapper
    {
        public Modeling3dCaptureImageEngine(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.modeling3dcapturesdk.Modeling3dCaptureImageEngine");

        /// <summary>
        /// Obtains an instance of Modeling3dCaptureImageEngine.
        /// </summary>
        /// <returns>Instance of Modeling3dCaptureImageEngine.</returns>
        public static Modeling3dCaptureImageEngine GetInstance() => javaClass.CallStaticAsWrapper<Modeling3dCaptureImageEngine>("getInstance");
        /// <summary>
        /// Starts image collection.
        /// </summary>
        /// <param name="fileSavePath">Path for storing the collected image.</param>
        /// <param name="listener">Image collection listener.</param>
        public void CaptureImage(string fileSavePath, Modeling3dCaptureImageListener listener) => Call("captureImage", fileSavePath, AndroidContext.ApplicationContext, listener);
        /// <summary>
        /// Configures the real-time guide engine.
        /// </summary>
        /// <param name="setting">Configuration of the real-time guide engine.</param>
        public void SetCaptureConfig(Modeling3dCaptureSetting setting) => Call("setCaptureConfig", setting);
    }
}
