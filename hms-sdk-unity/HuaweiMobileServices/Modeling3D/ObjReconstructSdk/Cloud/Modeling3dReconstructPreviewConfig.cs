using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructPreviewConfig
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/previewconfig-0000001186461516
    public class Modeling3dReconstructPreviewConfig : JavaObjectWrapper
    {
        public Modeling3dReconstructPreviewConfig(AndroidJavaObject javaObject) : base(javaObject) { }

        public Modeling3dReconstructPreviewConfig(int textureMode) : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructPreviewConfig", textureMode.AsJavaInteger()) { }

        public int TextureMode => CallAsInt("getTextureMode");

        public class Factory : JavaObjectWrapper
        {
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }

            public Factory() : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructPreviewConfig$Factory") { }

            public Factory SetTextureMode(int textureMode) => CallAsWrapper<Factory>("setTextureMode", textureMode.AsJavaInteger());
            public Modeling3dReconstructPreviewConfig Create() => CallAsWrapper<Modeling3dReconstructPreviewConfig>("create");
        }

    }
}