using HuaweiMobileServices.Base;
using HuaweiMobileServices.ML.Common;
using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextRecognition
{
    public class MLTextAnalyzer : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLTextAnalyzer";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public MLTextAnalyzer(AndroidJavaObject javaObject) : base(javaObject) { }

        public static int OCR_LOCAL_MODE => sJavaClass.GetStaticFieldCached<int>(nameof(OCR_LOCAL_MODE)); // 0
        public static int OCR_REMOTE_MODE => sJavaClass.GetStaticFieldCached<int>(nameof(OCR_REMOTE_MODE)); // 1

        public IList<MLText.Block> AnalyseFrame(MLFrame mLFrame) => CallAsWrapperList<MLText.Block>("analyseFrame", mLFrame);

        public ITask<MLText> AnalyseFrameAsync(MLFrame mLFrame) => CallAsWrapper<TaskJavaObjectWrapper<MLText>>("asyncAnalyseFrame", mLFrame);

        public int AnalyseType => Call<int>("getAnalyseType");
        public bool IsAvailable => Call<bool>("isAvailable");
        public void Stop() => Call("stop");

        public class Factory : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLTextAnalyzer$Factory";
            public Factory() : base(CLASS_NAME) { }

            public Factory(AndroidJavaObject javaObject) : base(javaObject) { }

            public MLTextAnalyzer Create() => CallAsWrapper<MLTextAnalyzer>("create");

            public Factory SetLanguage(string language) => CallAsWrapper<Factory>("setLanguage", language);

            public Factory SetLocalOCRMode(int analyseType) => CallAsWrapper<Factory>("setLocalOCRMode", analyseType);


        }

    }
}
