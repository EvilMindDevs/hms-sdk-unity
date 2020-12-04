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
        public FileContent(String javaObject) : base(javaObject) { }
        [UnityEngine.Scripting.Preserve]
        public FileContent(String var1, FileInfo var2) : base("com.huawei.cloud.base.http.FileContent", var1, var2)
        {

        }

        public long GetLength()
        {
            return Call<long>("getLength");
        }

        public bool RetrySupported()
        {
            return Call<bool>("retrySupported");
        }


        public FileStream GetFile()
        {
            return Call<FileStream>("getFile");
        }

        public FileContent SetType(String var1)
        {
            return Call<FileContent>("setType", var1);
        }

        public FileContent SetCloseInputStream(bool var1)
        {
            return Call<FileContent>("setCloseInputStream", var1);
        }
    }
}
