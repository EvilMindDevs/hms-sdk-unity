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

        [UnityEngine.Scripting.Preserve]
        public FileContent(String javaObject) : base(javaObject) {}

        [UnityEngine.Scripting.Preserve]
        public FileContent(String var1, FileInfo var2) : base("com.huawei.cloud.base.http.FileContent", var1, var2){}

        public long GetLength() => Call<long>("getLength");

        public bool RetrySupported() => Call<bool>("retrySupported");

        public FileStream GetFile() => Call<FileStream>("getFile");

        public FileContent SetType(String var1) => Call<FileContent>("setType", var1);

        public FileContent SetCloseInputStream(bool var1) => Call<FileContent>("setCloseInputStream", var1);
    }
}
