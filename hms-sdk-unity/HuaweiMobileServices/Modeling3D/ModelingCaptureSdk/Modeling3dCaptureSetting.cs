
using HuaweiMobileServices.Modeling3D.MeterialGenerateSdk.Cloud;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Modeling3D.ModelingCaptureSdk
{
    /// <summary>
    /// Wrapper for com.huawei.hms.modeling3dcapturesdk.Modeling3dCaptureSetting.
    /// <see cref="Modeling3dCaptureSetting" link=" https://developer.huawei.com/consumer/en/doc/development/graphics-References/modeling3dreconstructcapturesetting-0000001322414221"/>
    /// </summary>
    public class Modeling3dCaptureSetting : JavaObjectWrapper
    {
        public Modeling3dCaptureSetting(AndroidJavaObject javaObject) : base(javaObject) { }
        public Modeling3dCaptureSetting(int azimuthNum, int latitudeNum, double radius) : base("com.huawei.hms.modeling3dcapturesdk.Modeling3dCaptureSetting", azimuthNum,latitudeNum,radius) { }

        /// <summary>
        /// Obtains the number of boxes at each layer of the bounding hemisphere.
        /// </summary>
        /// <return>Number of boxes at each layer of the bounding hemisphere.</return>
        public int AzimuthNum => Call<int>("getAzimuthNum");
        /// <summary>
        /// Obtains the number of layers of the bounding hemisphere.
        /// </summary>
        /// <return>Number of layers of the bounding hemisphere.</return>
        public int LatitudeNum => Call<int>("getLatitudeNum");
        /// <summary>
        /// Obtains the radius of the bounding hemisphere.
        /// </summary>
        /// <return>Radius of the bounding hemisphere.</return>
        public double Radius => Call<double>("getRadius");


        public class Factory: JavaObjectWrapper
        {
            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }
            public Factory() : base("com.huawei.hms.modeling3dcapturesdk.Modeling3dCaptureSetting$Factory") { }

            /// <summary>
            /// Sets the number of boxes at each layer of the bounding hemisphere.
            /// </summary>
            /// <param name="azimuthNum">Number of boxes at each layer of the bounding hemisphere. The value range is [20,50].</param>
            /// <returns>Instance of Modeling3dCaptureSetting.Factory.</returns>
            public Factory SetAzimuthNum(int azimuthNum) => CallAsWrapper<Factory>("setAzimuthNum", azimuthNum);
            /// <summary>
            /// Sets the number of layers of the bounding hemisphere.
            /// </summary>
            /// <param name="latitudeNum">Number of layers of the bounding hemisphere. The value range is [1,6].</param>
            /// <returns>Instance of Modeling3dCaptureSetting.Factory.</returns>
            public Factory SetLatitudeNum(int latitudeNum) => CallAsWrapper<Factory>("setLatitudeNum", latitudeNum);
            /// <summary>
            /// Sets the radius of the bounding hemisphere.
            /// </summary>
            /// <param name="radius">Sets the radius of the bounding hemisphere.</param>
            /// <returns>	Instance of Modeling3dCaptureSetting.Factory.</returns>
            public Factory SetRadius(double radius) => CallAsWrapper<Factory>("setRadius", radius);
            /// <summary>
            /// Creates an instance of Modeling3dCaptureSetting.
            /// </summary>
            /// <returns>Instance of Modeling3dCaptureSetting.</returns>
            public Modeling3dCaptureSetting Create() => CallAsWrapper<Modeling3dCaptureSetting>("create");

        }

    }
}
