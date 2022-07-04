using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class FileContent : JavaObjectWrapper
    {        
        public FileContent(String javaObject) : base(javaObject) {}
        public FileContent(String var1, FileInfo var2) : base("com.huawei.cloud.base.http.FileContent", var1, var2){}
        public FileContent(String var1, Utils.java.io.File var2) : base("com.huawei.cloud.base.http.FileContent", var1, var2) { }

        public long? Length
        {
            get => Call<AndroidJavaObject>("getLength").AsLong();
        }

        public bool RetrySupported
        {
            get => CallAsBool("retrySupported");
        }

        public FileContent Type
        {
            set => CallAsWrapper<FileContent>("setType", value);
        }

        public FileContent CloseInputStream
        {
            set => CallAsWrapper<FileContent>("setCloseInputStream", value);
        }
    }
}
