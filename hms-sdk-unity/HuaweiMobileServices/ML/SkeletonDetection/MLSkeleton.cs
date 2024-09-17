using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.ML.SkeletonDetection
{
    public class MLSkeleton : JavaObjectWrapper
    {

        private const string CLASS_NAME = "com.huawei.hms.mlsdk.skeleton.MLSkeleton";

        public MLSkeleton(AndroidJavaObject javaObject) : base(javaObject)
        {
        }

        public MLSkeleton(string javaObjectCanonicalName, params object[] args) : base(javaObjectCanonicalName, args)
        {
        }

        public IList<MLJoint> GetJoints() => CallAsWrapperList<MLJoint>("getJoints");
       

        public MLJoint GetJointPoint(int pointType) => CallAsWrapper<MLJoint>("getJointPoint", pointType);

    }
}
