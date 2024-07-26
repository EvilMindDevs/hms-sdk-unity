using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class AndroidImage : JavaObjectWrapper
    {
        private const string CLASS_NAME = "android.media.Image";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public AndroidImage(AndroidJavaObject javaObject) : base(javaObject) { }

        public int Width => JavaObject.Call<int>("getWidth");
        public int Height => JavaObject.Call<int>("getHeight");
        public int Format => JavaObject.Call<int>("getFormat");
        public long Timestamp => JavaObject.Call<long>("getTimestamp");

        public Plane[] GetPlanes()
        {
            var planesJava = JavaObject.Call<AndroidJavaObject[]>("getPlanes");
            Plane[] planes = new Plane[planesJava.Length];
            for (int i = 0; i < planesJava.Length; i++)
            {
                planes[i] = new Plane(planesJava[i]);
            }
            return planes;
        }

        public void Close()
        {
            JavaObject.Call("close");
        }

        public class Plane : JavaObjectWrapper
        {
            public Plane(AndroidJavaObject javaObject) : base(javaObject) { }

            public int RowStride => JavaObject.Call<int>("getRowStride");
            public int PixelStride => JavaObject.Call<int>("getPixelStride");
            public AndroidByteBuffer Buffer => CallAsWrapper<AndroidByteBuffer>("getBuffer");
        }
    }
}
