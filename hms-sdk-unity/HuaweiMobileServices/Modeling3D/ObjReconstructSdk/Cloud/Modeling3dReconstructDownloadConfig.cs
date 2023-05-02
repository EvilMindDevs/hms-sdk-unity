using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructDownloadConfig
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructdownloadconfig-0000001208860367
    public class Modeling3dReconstructDownloadConfig : JavaObjectWrapper
    {
        public Modeling3dReconstructDownloadConfig(AndroidJavaObject javaObject) : base(javaObject) { }
        public Modeling3dReconstructDownloadConfig(string fileFormat, int textureMode) : 
                                    base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructDownloadConfig", fileFormat.AsJavaString(), textureMode.AsJavaInteger()){ }

        /// <summary>
        /// Obtains the file format of the downloaded model.
        /// </summary>
        /// <returns>File format of the downloaded model. GLTF: glTF format or OBJ: OBJ format</returns>
        public string ModelFormat => CallAsString("getModelFormat");
       
        /// <summary>
        /// Obtains the texture map mode.
        /// </summary>
        /// <returns>Texture map mode. NORMAL: normal mode. PBR: PBR mode.</returns>
        public int TextureMode => CallAsInt("getTextureMode");

        public class Factory : JavaObjectWrapper
        {
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }

            public Factory() : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructDownloadConfig$Factory") { }

            /// <summary>
            /// Sets the model file format.
            /// </summary>
            /// <param name="modelFormat">File format of the downloaded model. GLTF: glTF format or OBJ: OBJ format</param>
            /// <returns>Instance of Modeling3dReconstructDownloadConfig.Factory.</returns>
            public Factory SetModelFormat(string modelFormat) => CallAsWrapper<Factory>("setModelFormat", modelFormat.AsJavaString());

            /// <summary>
            /// Sets the texture map mode.
            /// </summary>
            /// <param name="textureMode">Texture map mode. NORMAL: normal mode. PBR: PBR mode.</param>
            /// <returns>Instance of Modeling3dReconstructDownloadConfig.Factory.</returns>
            public Factory SetTextureMode(int textureMode) => CallAsWrapper<Factory>("setTextureMode", textureMode.AsJavaInteger());

            /// <summary>
            /// Creates an instance of Modeling3dReconstructDownloadConfig.
            /// </summary>
            public Modeling3dReconstructDownloadConfig Create() => CallAsWrapper<Modeling3dReconstructDownloadConfig>("create");
                
            
        }
    }
}