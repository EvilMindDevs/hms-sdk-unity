using HuaweiMobileServices.ML.Common;
using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.Translate
{
    // Wrapper for com.huawei.hms.mlsdk.translate.MLTranslatorFactory
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mltranslatorfactory-0000001050167536
    public class MLTranslatorFactory: JavaObjectWrapper
    {
        const string CLASS_NAME = "com.huawei.hms.mlsdk.translate.MLTranslatorFactory";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public MLTranslatorFactory(AndroidJavaObject javaObject) : base(javaObject) { }

        public static MLTranslatorFactory Instance => sJavaClass.CallStaticAsWrapper<MLTranslatorFactory>("getInstance");
        public static MLTranslatorFactory GetInstance(MLApplication mLApplication) => sJavaClass.CallStaticAsWrapper<MLTranslatorFactory>("getInstance", mLApplication);

        // Will be implemented in the future, GetLocalTranslator and GetRemoteTranslator will be added.

    }
}
