using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class InputStreamContent : JavaObjectWrapper
    {
        
        public InputStreamContent(AndroidJavaObject javaObject) : base(javaObject) { }

        
        public InputStreamContent() : base("com.huawei.cloud.base.http.InputStreamContent"){}

        public InputStreamContent(String mimeType, AndroidJavaObject inputStream) : base("com.huawei.cloud.base.http.InputStreamContent", mimeType, inputStream){}

        public long GetLength() => Call<long>("getLength");

        public InputStreamContent SetLength(long var1) => CallAsWrapper<InputStreamContent>("setLength", var1);

    }
}
