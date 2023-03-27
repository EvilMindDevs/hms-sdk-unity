using System;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace  HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud
{
        
    /// <summary>
    /// Wrapper for com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureSetting.
    /// <see cref="Modeling3dTextureSetting" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dtexturesetting-0000001106773054"/>
    /// </summary>
    public class Modeling3dTextureSetting : JavaObjectWrapper
    {
        public Modeling3dTextureSetting(AndroidJavaObject javaObject) : base(javaObject) { }
        public Modeling3dTextureSetting(int mode) : base("com.huawei.hms.materialgeneratesdk.cloud.Modeling3dTextureSetting", mode.AsJavaInteger()) { }
        /// <summary>
        /// Obtains the working mode for material generation.
        /// </summary>
        /// <returns>
        /// <see cref="Working mode" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/algorithmmode-0000001117111976"/>
        ///</returns>    
        public int GetTextureMode() => CallAsInt("getTextureMode");
    
        public class Factory : JavaObjectWrapper
        {
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base("com.huawei.hms.materialgeneratesdk.cloud.materialgeneratesdk$Factory") { }

            /// <summary>
            /// Creates a Modeling3dTextureSetting instance.
            /// </summary>
            /// <returns> Modeling3dTextureSetting instance.</returns>
            public Modeling3dTextureSetting Create() => CallAsWrapper<Modeling3dTextureSetting>("create");
            /// <summary>
            /// Creates a Modeling3dTextureSetting instance.
            /// <param name="textureMode">/// Working mode for material generation. </param>
            /// </summary>
            /// <returns> Modeling3dTextureSetting.Factory instance.</returns>
            public Factory SetTextureMode(int textureMode) => CallAsWrapper<Factory>("setTextureMode", textureMode.AsJavaInteger());

        }
    }
}