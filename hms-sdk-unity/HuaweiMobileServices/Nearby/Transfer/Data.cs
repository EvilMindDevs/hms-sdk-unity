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
        public byte[] AsBytes => androidJavaClass.Call<byte[]>("asBytes");
        public File AsFile => androidJavaClass.CallStaticAsWrapper<File>("asFile");
        public Stream AsStream => androidJavaClass.CallStaticAsWrapper<Stream>("asStream");
        public static Data FromBytes(byte[] bytes) => androidJavaClass.CallStaticAsWrapper<Data>("fromBytes", bytes);
        public static Data FromFile(AndroidJavaObject pfd) => androidJavaClass.CallStaticAsWrapper<Data>("fromFile", pfd);
        public static Data FromFile(File javaFile) => androidJavaClass.CallStaticAsWrapper<Data>("fromFile", javaFile);
        public static Data FromStream(AndroidJavaObject pfd) => androidJavaClass.CallStaticAsWrapper<Data>("fromStream", pfd);
        public long ID => androidJavaClass.Call<long>("getID");
        public int DataType => androidJavaClass.Call<int>("getType");

        public class Stream : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Stream(AndroidJavaObject javaObject) : base(javaObject) { }

            private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data$Stream");
            public AndroidJavaObject AsInputStream => androidJavaClass.Call<AndroidJavaObject>("asInputStream");
            public Stream StreamFactory(AndroidJavaObject parcelFileDescriptor) => androidJavaClass.Call<Stream>("streamFactory", parcelFileDescriptor);
        }
        public class File : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public File(AndroidJavaObject javaObject) : base(javaObject) { }
            private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data$File");
            public File AsJavaFile => androidJavaClass.Call<File>("asJavaFile");
            public Uri AsUri => androidJavaClass.Call<Uri>("asUri");
            public long Size => androidJavaClass.Call<long>("getSize");
            public static File FileFactory(File javaFile, long size) => androidJavaClass.Call<File>("fileFactory", javaFile, size);
        }
        public class Type : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Type(AndroidJavaObject javaObject) : base(javaObject) { }
            private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data$Type");
            public static int FILE => androidJavaClass.GetStatic<int>("FILE");
            public static int BYTES => androidJavaClass.GetStatic<int>("BYTES");
            public static int STREAM => androidJavaClass.GetStatic<int>("STREAM");        
        }
    }
}
