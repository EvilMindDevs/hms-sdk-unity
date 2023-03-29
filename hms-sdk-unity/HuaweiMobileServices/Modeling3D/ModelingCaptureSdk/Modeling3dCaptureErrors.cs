using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ModelingCaptureSdk
{
    /// <summary>
    /// Wrapper for com.huawei.hms.modeling3dcapturesdk.Modeling3dCaptureErrors.
    /// <see cref="Modeling3dCaptureErrors" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3derrors-0000001322601245"/>
    /// </summary>
    public class Modeling3dCaptureErrors : JavaObjectWrapper
    {
        public Modeling3dCaptureErrors(AndroidJavaObject androidJavaObject) : base(androidJavaObject) { }
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.modeling3dcapturesdk.Modeling3dCaptureErrors");

        /// <summary>
        /// The device does not support the real-time guide mode.
        /// </summary>
        /// <return>1300</return>
        public static int ERR_DEVICE_NOT_SUPPORTED => sJavaClass.GetStatic<int>("ERR_DEVICE_NOT_SUPPORTED");
        /// <summary>
        /// Image path verification failed.
        /// </summary>
        /// <return>1301</return>
        public static int ERR_FILE_PATH_VERIFIED_FAILED => sJavaClass.GetStatic<int>("ERR_FILE_PATH_VERIFIED_FAILED");
        /// <summary>
        /// The parameter of the bounding hemisphere is invalid.
        /// </summary>
        /// <return>1302</return>
        public static int ERR_ILLEGAL_BOX_PARAMETER => sJavaClass.GetStatic<int>("ERR_ILLEGAL_BOX_PARAMETER");
        /// <summary>
        /// Internal processing error.
        /// </summary>
        /// <return>1303</return>
        public static int ERR_INTERNAL_PROCESS => sJavaClass.GetStatic<int>("ERR_INTERNAL_PROCESS");
        /// <summary>
        /// The required dependency is not integrated.
        /// </summary>
        /// <return>1304</return>
        public static int ERR_DEPENDENCY_NOT_INTEGRATED => sJavaClass.GetStatic<int>("ERR_DEPENDENCY_NOT_INTEGRATED");
    }

}
