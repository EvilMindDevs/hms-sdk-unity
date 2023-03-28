using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud
{
    //wrapper for com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructSetting
    //https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructsetting-0000001153013005
    public class Modeling3dReconstructSetting : JavaObjectWrapper
    {
        //private static AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructSetting");
        public Modeling3dReconstructSetting(AndroidJavaObject javaObject) : base(javaObject) { }
        public Modeling3dReconstructSetting(int mode, int textureMode, int taskType) : 
                base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructSetting", mode.AsJavaInteger(), textureMode.AsJavaInteger(), taskType.AsJavaInteger()) { }
        public Modeling3dReconstructSetting(int mode, int textureMode, int taskType, string needRescan) : 
                base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructSetting",  mode.AsJavaInteger(), textureMode.AsJavaInteger(), taskType.AsJavaInteger(),needRescan.AsJavaString()) { }
        public Modeling3dReconstructSetting(int mode, int textureMode, int taskType, string needRescan, string taskId) : 
                base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructSetting", mode.AsJavaInteger(), textureMode.AsJavaInteger(), taskType.AsJavaInteger(),needRescan.AsJavaString(),taskId.AsJavaString()) { }
        public Modeling3dReconstructSetting(int mode, int textureMode, int taskType, string needRescan, string taskId, int faceLevel) : 
                base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructSetting", mode.AsJavaInteger(), textureMode.AsJavaInteger(), taskType.AsJavaInteger(),needRescan.AsJavaString(),taskId.AsJavaString(), faceLevel.AsJavaInteger()) { }

        public int FaceLevel
        {
            get => CallAsInt("getFaceLevel");
            set => Call("setFaceLevel", value.AsJavaInteger());
        }

        /// <summary>
        /// Obtains the type of a 3D object reconstruction task.
        /// </summary>
        /// <returns>	
        ///    Type of a 3D object reconstruction task.
        ///    AUTO_RIGGING: auto rigging
        ///    OBJ_RECONSTRUCT: 3D object reconstruction
        /// </returns>
        public int GetTaskType() => CallAsInt("getTaskType");
        /// <summary>
        /// Obtains the texture map mode.
        /// </summary>
        /// <returns> 
        ///     Texture map mode.
        ///     NORMAL: normal mode
        ///     PBR: PBR mode
        /// </returns>
        public int GetTextureMode() => CallAsInt("getTextureMode");
        /// <summary>
        /// Obtains the working mode for 3D object reconstruction.
        /// </summary>
        /// <returns>Working mode.PICTURE: picture mode. Currently, only this mode is supported. <see cref="Status Link:" href=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/capturemode-0000001117263174#section127055371184" /></returns>
        public int GetReconstructMode() => CallAsInt("getReconstructMode");
        public string GetNeedRescan() => CallAsString("getNeedRescan");
        public string GetTaskId() => CallAsString("getTaskId");

        public class Factory : JavaObjectWrapper
        {
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base("com.huawei.hms.objreconstructsdk.cloud.Modeling3dReconstructSetting$Factory") { }

            public Factory SetReconstructMode(int mode) => CallAsWrapper<Factory>("setReconstructMode", mode.AsJavaInteger());

            public Factory SetTextureMode(int textureMode) => CallAsWrapper<Factory>("setTextureMode", textureMode.AsJavaInteger());

            public Factory SetTaskType(int taskType) => CallAsWrapper<Factory>("setTaskType", taskType.AsJavaInteger());

            public Factory SetNeedRescan(string needRescan) => CallAsWrapper<Factory>("setNeedRescan", needRescan.AsJavaString());

            public Factory SetTaskId(string taskId) => CallAsWrapper<Factory>("setTaskId", taskId.AsJavaString());

            public Factory SetFaceLevel(int faceLevel) => CallAsWrapper<Factory>("setFaceLevel", faceLevel.AsJavaInteger());

            public Modeling3dReconstructSetting Create() => CallAsWrapper<Modeling3dReconstructSetting>("create");

        }
    }

}