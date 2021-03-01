using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Transfer
{
    public class Data : Parcelable 
    {
        [UnityEngine.Scripting.Preserve]
        public Data(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass DataClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data");

        public byte[] AsBytes => DataClass.Call<byte[]>("asBytes");
        public File AsFile => DataClass.Call<File>("asFile");
        public Stream AsStream => DataClass.Call<Stream>("asStream");
        public static Data FromBytes(byte[] bytes) => DataClass.CallStatic<Data>("fromBytes", bytes);
        public static Data FromFile(ParcelFileDescriptor pfd) => DataClass.CallStatic<Data>("fromFile", pfd);
        public static Data FromFile(File javaFile) => DataClass.CallStatic<Data>("fromFile", javaFile);
        public static Data FromStream(ParcelFileDescriptor pfd) => DataClass.CallStatic<Data>("fromStream", pfd);
        public static Data FromStream(InputStream inputStream) => DataClass.CallStatic<Data>("fromStream", inputStream);
        public long ID => DataClass.Call<long>("getID");
        public int DataType => DataClass.Call<int>("getType");
        public void WriteToParcel(Parcel dest, int flags) => DataClass.Call("writeToParcel", dest, flags);
        public int DescribeContents => DataClass.Call<int>("describeContents");

        public class Stream
        {
            public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data$Stream");
            public InputStream AsInputStream => androidJavaClass.Call<InputStream>("asInputStream");
            public ParcelFileDescriptor AsParcelFileDescriptor => androidJavaClass.Call<ParcelFileDescriptor>("asParcelFileDescriptor");
            public Stream StreamFactory(ParcelFileDescriptor parcelFileDescriptor) => androidJavaClass.Call<Stream>("streamFactory", parcelFileDescriptor);

            public Stream StreamFactory(InputStream inputStream) => androidJavaClass.Call<Stream>("streamFactory", inputStream);

        }
        public class File
        {
            public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data$File");
            public File AsJavaFile => androidJavaClass.Call<File>("asJavaFile");
            public Uri AsUri => androidJavaClass.Call<Uri>("asUri");
            public ParcelFileDescriptor AsParcelFileDescriptor => androidJavaClass.Call<ParcelFileDescriptor>("asParcelFileDescriptor");
            public long Size => androidJavaClass.Call<long>("getSize");
            public static File FileFactory(File javaFile, long size) => androidJavaClass.Call<File>("fileFactory", javaFile, size);
        }
        public class Type
        {
            public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data$Type");
            public static int FILE => androidJavaClass.GetStatic<int>("FILE");
            public static int BYTES => androidJavaClass.GetStatic<int>("BYTES");
            public static int STREAM => androidJavaClass.GetStatic<int>("STREAM");        
        }
    }
}
