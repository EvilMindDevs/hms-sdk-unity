using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ObjReconstructSdk.Cloud.Rebody
{
    /// <summary>
    /// Information about the images uploaded for a 3D object reconstruction task.
    /// Wrapper for com.huawei.hms.objreconstructsdk.cloud.rebody.TaskImageInfo.
    /// <see cref="TaskImageInfo" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/cloud-rebody-taskimageinfo-0000001485324790"/>
    /// </summary>
    public class TaskImageInfo : JavaObjectWrapper
    {
        public TaskImageInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        //private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.objreconstructsdk.cloud.rebody.TaskImageInfo");

        /// <summary>
        /// Obtains the size of images.
        /// </summary>
        public long Size
        {
            get => CallAsLong("getSize") ?? 0;
            set => Call("setSize", value.AsJavaLong());
        }
        /// <summary>
        /// Obtains the number of images.
        /// </summary>
        public int ImageNum
        {
            get => CallAsInt("getNum");
            set => Call("setNum", value.AsJavaInteger());
        }
        /// <summary>
        /// Obtains the format of images.
        /// </summary>
        public string Format
        {
            get => CallAsString("getFormat");
            set => Call("setFormat", value.AsJavaString());
        }
        /// <summary>
        /// Resolution for the images.(in pixels)
        /// </summary>
        public ImageResolution imageResolation
        {
            get => CallAsWrapper<ImageResolution>("getImageResolution");
            set => Call("setImageResolution", value);
        }


        /// <summary>
        /// Resolution information about the images uploaded for a 3D object reconstruction task.
        /// </summary>
        public class ImageResolution : JavaObjectWrapper
        {
            public ImageResolution(AndroidJavaObject javaObject) : base(javaObject) { }


            public ImageResolution() : base("com.huawei.hms.objreconstructsdk.cloud.rebody.TaskImageInfo$ImageResolution") { }
            /// <summary>
            /// Obtains the width of images uploaded for a 3D object reconstruction task.
            /// </summary>
            public int Width
            {
                get => Call<int>("getWidth");
                set => Call("setWidth", value);
            }
            /// <summary>
            /// Obtains the height of images uploaded for a 3D object reconstruction task.
            /// </summary>
            public int Height
            {
                get => Call<int>("getHeight");
                set => Call("setHeight", value);
            }


        }
    }
}
