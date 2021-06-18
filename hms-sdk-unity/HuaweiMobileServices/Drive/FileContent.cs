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

        public long GetLength() => Call<long>("getLength");

        public bool RetrySupported() => Call<bool>("retrySupported");

        public FileContent SetType(String var1) => CallAsWrapper<FileContent>("setType", var1);

        public FileContent SetCloseInputStream(bool var1) => CallAsWrapper<FileContent>("setCloseInputStream", var1);
    }
}
