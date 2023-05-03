using HuaweiMobileServices.Utils;
using UnityEngine;
namespace HuaweiMobileServices.Modeling3D.MeterialGenerateSdk
{
    /// <summary>
    /// Constants of material generation.
    /// Wrapper for com.huawei.hms.materialgeneratesdk.Modeling3dTextureConstants.
    /// <see cref="Modeling3dTextureConstants" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtextureconstants-0000001152893159"/>
    /// </summary>
    public class Modeling3dTextureConstants : JavaObjectWrapper
    {
        public Modeling3dTextureConstants(AndroidJavaObject javaObject) : base(javaObject) { }
        
        /// <summary>
        /// Restriction status of a material generation task, which is specified in Modeling3dTextureConstants.
        /// </summary>
        public class RestrictStatus : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.materialgeneratesdk.Modeling3dTextureConstants$RestrictStatus";
            public RestrictStatus(AndroidJavaObject javaObject) : base(javaObject) { }
            public RestrictStatus() : base(CLASS_NAME) { }
            private static readonly AndroidJavaClass javaClass = new AndroidJavaClass(CLASS_NAME);
            ///<returns>1</returns>
            public static int RESTRICT => javaClass.GetStatic<int>("RESTRICT");
            ///<returns>0</returns>
            public static int UNRESTRICT => javaClass.GetStatic<int>("UNRESTRICT");
        }
        /// <summary>
        /// Status of a material generation task, which is specified in Modeling3dTextureConstants.
        /// </summary>
        public class ProgressStatus : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.materialgeneratesdk.Modeling3dTextureConstants$ProgressStatus";
            public ProgressStatus(AndroidJavaObject javaObject) : base(javaObject) { }
            public ProgressStatus() : base(CLASS_NAME) { }

            private static readonly AndroidJavaClass javaClass = new AndroidJavaClass(CLASS_NAME);

            ///<summary>
            ///Task initialization is complete.
            ///</summary>
            ///<returns>0</returns>
            public static int INITED => javaClass.GetStatic<int>("INITED");
            ///<summary>
            ///File upload is complete.
            ///</summary>
            ///<returns>1</returns>
            public static int UPLOAD_COMPLETED => javaClass.GetStatic<int>("UPLOAD_COMPLETED");
            ///<summary>
            ///A material generation task starts.
            ///</summary>
            ///<returns>2</returns>
            public static int TEXTURE_START => javaClass.GetStatic<int>("TEXTURE_START");
            ///<summary>
            ///A material generation task is complete.
            ///</summary>
            ///<returns>3</returns>
            public static int TEXTURE_COMPLETED => javaClass.GetStatic<int>("TEXTURE_COMPLETED");
            ///<summary>
            ///A material generation task fails.
            ///</summary>
            ///<returns>4</returns>
            public static int TEXTURE_FAILED => javaClass.GetStatic<int>("TEXTURE_FAILED");

        }
        /// <summary>
        /// Working mode for material generation, which is specified in Modeling3dTextureConstants.
        /// </summary>
        public class AlgorithmMode : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.materialgeneratesdk.Modeling3dTextureConstants$AlgorithmMode";
            public AlgorithmMode(AndroidJavaObject javaObject) : base(javaObject) { }
            public AlgorithmMode() : base(CLASS_NAME) { }
            private static readonly AndroidJavaClass javaClass = new AndroidJavaClass(CLASS_NAME);

            ///<summary>
            ///AI mode.
            ///</summary>
            ///<returns>1</returns>
            public static int AI => javaClass.GetStatic<int>("AI");
        }
    }
}