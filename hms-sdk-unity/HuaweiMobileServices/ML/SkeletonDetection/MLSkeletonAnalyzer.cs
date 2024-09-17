using HuaweiMobileServices.Base;
using HuaweiMobileServices.ML.Common;
using HuaweiMobileServices.ML.TextRecognition;
using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.ML.SkeletonDetection
{
    public class MLSkeletonAnalyzer: JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.skeleton.MLSkeletonAnalyzer";

        public MLSkeletonAnalyzer(AndroidJavaObject javaObject) : base(javaObject)
        {
        }

        public MLSkeletonAnalyzer(string javaObjectCanonicalName, params object[] args) : base(javaObjectCanonicalName, args)
        {
        }

        //SparseArray<MLSkeleton> 
        public IList<MLSkeleton> AnalyseFrame(MLFrame mLFrame) => CallAsWrapperList<MLSkeleton>("analyseFrame", mLFrame);

        public ITask<IList<MLSkeleton>> AsyncAnalyseFrame(MLFrame mlFrame)
        {
            var task = Call<AndroidJavaObject>("asyncAnalyseFrame", mlFrame);
            return new TaskWrapper<IList<MLSkeleton>>(task, AndroidJavaObjectExtensions.AsListFromWrappable<MLSkeleton>);
        }

        public float CaluteSimilarity(IList<MLSkeleton> skeleton1, IList<MLSkeleton> skeleton2) => Call<float>("getScore", skeleton1 ,skeleton2);

        public void Stop() => Call("stop");

    }
}
