using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextRecognition
{
    public class TextLanguage : JavaObjectWrapper
    {
        public const string CLASS_NAME = "com.huawei.hms.mlsdk.text.TextLanguage";
        public readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass(CLASS_NAME);
        public TextLanguage(AndroidJavaObject javaObject) : base(javaObject) { }

        public string Language => Call<string>("getLanguage");

        public override int GetHashCode()
        {
            return Call<int>("hashCode");
        }

        public override bool Equals(object obj)
        {
            return Call<bool>("equals", obj);
        }
    }
}
