using HuaweiMobileServices.ML.Common;
using HuaweiMobileServices.ML.LanguageDetection;
using HuaweiMobileServices.ML.LanguageDetection.Local;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.SkeletonDetection
{
    public class MLSkeletonAnalyzerFactory : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.skeleton.MLSkeletonAnalyzerFactory";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public MLSkeletonAnalyzerFactory(AndroidJavaObject javaObject) : base(javaObject)
        {
        }

        public MLSkeletonAnalyzerFactory(string javaObjectCanonicalName, params object[] args) : base(javaObjectCanonicalName, args)
        {
        }

        public MLSkeletonAnalyzerFactory(MLApplication mlApplication) : base(CLASS_NAME, mlApplication) { }

        public static MLSkeletonAnalyzerFactory GetInstance() => sJavaClass.CallStaticAsWrapper<MLSkeletonAnalyzerFactory>("getInstance");

        public MLSkeletonAnalyzer GetSkeletonAnalyzer() => CallAsWrapper<MLSkeletonAnalyzer>("getSkeletonAnalyzer");
        public MLSkeletonAnalyzer GetSkeletonAnalyzer(MLSkeletonAnalyzerSetting setting) => CallAsWrapper<MLSkeletonAnalyzer>("getSkeletonAnalyzer", setting);

    }
}
