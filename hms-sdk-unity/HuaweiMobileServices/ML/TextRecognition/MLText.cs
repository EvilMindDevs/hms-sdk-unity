using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.ML.TextRecognition
{
    public class MLText : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLText";
        public MLText(AndroidJavaObject javaObject) : base(javaObject) { }

        public IList<Block> Blocks => CallAsWrapperList<Block>("getBlocks");
        public string StringValue => Call<string>("getStringValue");

        public class Base : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLText$Base";
            public Base(AndroidJavaObject javaObject) : base(javaObject) { }
            public Base(string className) : base(className) { }
            public Base() : base(CLASS_NAME) { }  
            public Rect Border => CallAsWrapper<Rect>("getBorder");
            public string Language => Call<string>("getLanguage");
            public IList<string> LanguageList => CallAsStringList("getLanguageList");
            public float Possibility => Call<float>("getPossibility");
            public string StringValue => Call<string>("getStringValue"); //Obtains the detected text content.
            public Point[] Vertexes() => CallAsWrapperArray<Point>("getVertexes");
        }
 
        public class Word: Base
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLText$Word";
            public Word(AndroidJavaObject javaObject) : base(javaObject) { }
            public Word() : base(CLASS_NAME) { }

            public IList<Base> GetContents() => CallAsWrapperList<Base>("getContents");
        }

        public class TextLine : Base
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLText$TextLine";
            public TextLine(AndroidJavaObject javaObject) : base(javaObject) { }
            public TextLine() : base(CLASS_NAME) { }
            public float RotatingDegree => Call<float>("getRotatingDegree");
            public bool IsVertical => Call<bool>("isVertical");
            public IList<Word> GetContents() => CallAsWrapperList<Word>("getContents");

        }

        public class Block : Base
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.text.MLText$Block";
            public Block(AndroidJavaObject javaObject) : base(javaObject) { }
            public Block() : base(CLASS_NAME) { }
            public IList<TextLine> GetContents() => CallAsWrapperList<TextLine>("getContents");

        }



    }

}
