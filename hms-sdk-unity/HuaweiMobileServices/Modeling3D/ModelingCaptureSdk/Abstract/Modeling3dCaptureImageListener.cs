using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ModelingCaptureSdk
{
    /// <summary>
    /// Wrapper for com.huawei.hms.modeling3dcapturesdk.cloud.Modeling3dCaptureImageListener.
    /// <see cref="Modeling3dCaptureImageListener" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/captureimagelistener-0000001271452336"/>
    /// </summary>
    public class Modeling3dCaptureImageListener : AndroidJavaProxy
    {
        private readonly IModeling3dCaptureImageListener _IModeling3dCaptureImageListener;

        public Modeling3dCaptureImageListener(IModeling3dCaptureImageListener iModeling3dCaptureImageListener) : base("com.huawei.hms.modeling3dcapturesdk.Modeling3dCaptureImageListener")
        {
            _IModeling3dCaptureImageListener = iModeling3dCaptureImageListener;
        }

        public void onProgress(int progress)
        {
            _IModeling3dCaptureImageListener.onProgress(progress);
        }

        public void onError(int errorCode, string errorMsg)
        {
            _IModeling3dCaptureImageListener.onError(errorCode, errorMsg);
        }

        public void onResult()
        {
            _IModeling3dCaptureImageListener.onResult();
        }

        public interface IModeling3dCaptureImageListener
        {
            /// <summary>
            /// Callback when image collection is complete.
            /// </summary>
            void onResult();
            /// <summary>
            /// Callback when an error occurs during image collection.
            /// </summary>
            /// <param name="progress">Collection progress.</param>
            void onProgress(int progress);
            /// <summary>
            /// Callback when an error occurs during image collection. You can process the error according to the returned result code.
            /// </summary>
            /// <param name="errorCode">Result code.</param>
            /// <param name="message">Result description.</param>
            void onError(int errorCode, string message);

        }
    }
}

