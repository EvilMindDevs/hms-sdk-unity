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
        
        //private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.meterialgeneratesdk.Modeling3dTextureConstants");

        /// <summary>
        /// Restriction status of a material generation task, which is specified in Modeling3dTextureConstants.
        /// </summary>
        public class RestrictStatus : JavaObjectWrapper
        {
            public RestrictStatus(AndroidJavaObject javaObject) : base(javaObject) { }

            public RestrictStatus() : base("com.huawei.hms.meterialgeneratesdk.Modeling3dTextureConstants$RestrictStatus") { }

            ///<returns>1</returns>
            public int RESTRICT => CallStatic<int>("RESTRICT");
            ///<returns>0</returns>
            public int UNRESTRICT => CallStatic<int>("UNRESTRICT");

        }

        /// <summary>
        /// Status of a material generation task, which is specified in Modeling3dTextureConstants.
        /// </summary>
        public class ProgressStatus : JavaObjectWrapper
        {
            public ProgressStatus(AndroidJavaObject javaObject) : base(javaObject) { }
            public ProgressStatus() : base("com.huawei.hms.meterialgeneratesdk.Modeling3dTextureConstants$ProgressStatus") { }


            ///<summary>
            ///Task initialization is complete.
            ///</summary>
            ///<returns>0</returns>
            public int INITED => CallStatic<int>("INITED");
            ///<summary>
            ///File upload is complete.
            ///</summary>
            ///<returns>1</returns>
            public int UPLOAD_COMPLETED => CallStatic<int>("UPLOAD_COMPLETED");
            ///<summary>
            ///A material generation task starts.
            ///</summary>
            ///<returns>2</returns>
            public int TEXTURE_START => CallStatic<int>("TEXTURE_START");
            ///<summary>
            ///A material generation task is complete.
            ///</summary>
            ///<returns>3</returns>
            public int TEXTURE_COMPLETED => CallStatic<int>("TEXTURE_COMPLETED");
            ///<summary>
            ///A material generation task fails.
            ///</summary>
            ///<returns>4</returns>
            public int TEXTURE_FAILED => CallStatic<int>("TEXTURE_FAILED");

        }

        /// <summary>
        /// Working mode for material generation, which is specified in Modeling3dTextureConstants.
        /// </summary>
        public class AlgorithmMode : JavaObjectWrapper
        {
            public AlgorithmMode(AndroidJavaObject javaObject) : base(javaObject) { }
            public AlgorithmMode() : base("com.huawei.hms.meterialgeneratesdk.Modeling3dTextureConstants$AlgorithmMode") { }


            ///<summary>
            ///AI mode.
            ///</summary>
            ///<returns>1</returns>
            public int AI => CallStatic<int>("AI");
        }
    }
}