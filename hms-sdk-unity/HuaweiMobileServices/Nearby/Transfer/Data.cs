using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Transfer
{
    public class Data : JavaObjectWrapper 
    {
        [UnityEngine.Scripting.Preserve]
        public Data(AndroidJavaObject javaObject) : base(javaObject) { }

        private static readonly AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data");
        public byte[] AsBytes => Call<byte[]>("asBytes");
        public static Data FromBytes(byte[] bytes) => androidJavaClass.CallStaticAsWrapper<Data>("fromBytes", bytes);
        public long ID => Call<long>("getID");
        public int DataType => Call<int>("getType");

        public static class Type
        {
            private static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.Data$Type");
            public static int BYTES => androidJavaClass.GetStatic<int>("BYTES");
            public static int STREAM => androidJavaClass.GetStatic<int>("STREAM");        
        }
    }
}
