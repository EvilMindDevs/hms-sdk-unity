using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.SkeletonDetection
{
    public class MLJoint : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.skeleton.MLJoint";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public MLJoint(AndroidJavaObject javaObject) : base(javaObject)
        {
        }

        public MLJoint(string javaObjectCanonicalName, params object[] args) : base(javaObjectCanonicalName, args)
        {
        }

        public static int TYPE_HEAD_TOP => sJavaClass.GetStatic<int>(nameof(TYPE_HEAD_TOP));
        public static int TYPE_LEFT_ANKLE => sJavaClass.GetStatic<int>(nameof(TYPE_LEFT_ANKLE));
        public static int TYPE_LEFT_ELBOW => sJavaClass.GetStatic<int>(nameof(TYPE_LEFT_ELBOW));
        public static int TYPE_LEFT_HIP => sJavaClass.GetStatic<int>(nameof(TYPE_LEFT_HIP));
        public static int TYPE_LEFT_KNEE => sJavaClass.GetStatic<int>(nameof(TYPE_LEFT_KNEE));
        public static int TYPE_LEFT_SHOULDER => sJavaClass.GetStatic<int>(nameof(TYPE_LEFT_SHOULDER));
        public static int TYPE_LEFT_WRIST => sJavaClass.GetStatic<int>(nameof(TYPE_LEFT_WRIST));
        public static int TYPE_NECK => sJavaClass.GetStatic<int>(nameof(TYPE_NECK));
        public static int TYPE_RIGHT_ANKLE => sJavaClass.GetStatic<int>(nameof(TYPE_RIGHT_ANKLE));
        public static int TYPE_RIGHT_ELBOW => sJavaClass.GetStatic<int>(nameof(TYPE_RIGHT_ELBOW));
        public static int TYPE_RIGHT_HIP => sJavaClass.GetStatic<int>(nameof(TYPE_RIGHT_HIP));
        public static int TYPE_RIGHT_KNEE => sJavaClass.GetStatic<int>(nameof(TYPE_RIGHT_KNEE));
        public static int TYPE_RIGHT_SHOULDER => sJavaClass.GetStatic<int>(nameof(TYPE_RIGHT_SHOULDER));
        public static int TYPE_RIGHT_WRIST => sJavaClass.GetStatic<int>(nameof(TYPE_RIGHT_WRIST));



        public float GetPointX() => Call<float>("getPointX");
        public float GetPointY() => Call<float>("getPointY");
        public float GetScore() => Call<float>("getScore");
        public float GetType() => Call<float>("getType");

        public override bool Equals(object other) => CallAsBool("equals", other);
        public override int GetHashCode() => Call<int>("hashCode");
    }
}
