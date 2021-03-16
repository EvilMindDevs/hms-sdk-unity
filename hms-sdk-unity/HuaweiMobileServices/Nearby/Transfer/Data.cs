using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Transfer
{
    public class Data : JavaObjectWrapper 
    {
        [UnityEngine.Scripting.Preserve]
        public Data(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data");
        public byte[] AsBytes => Call<byte[]>("asBytes");
        public File AsFile =>  CallAsWrapper<File>("asFile");
        public static Data FromBytes(byte[] bytes) => androidJavaClass.CallStaticAsWrapper<Data>("fromBytes", bytes);
        public static Data FromFile(File javaFile) => androidJavaClass.CallStaticAsWrapper<Data>("fromFile", javaFile);
        public long ID => Call<long>("getID");
        public int DataType => Call<int>("getType");

        public class File : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public File(AndroidJavaObject javaObject) : base(javaObject) { }
            private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data$File");
            public File AsJavaFile => CallAsWrapper<File>("asJavaFile");
            public long Size => Call<long>("getSize");
            public static File FileFactory(File javaFile, long size) => androidJavaClass.Call<File>("fileFactory", javaFile, size);
        }
        public static class Type
        {
            private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data$Type");
            public static int FILE => androidJavaClass.GetStatic<int>("FILE");
            public static int BYTES => androidJavaClass.GetStatic<int>("BYTES");
            public static int STREAM => androidJavaClass.GetStatic<int>("STREAM");        
        }
    }
}
