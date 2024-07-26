using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public class AndroidByteBuffer : JavaObjectWrapper
    {
        private const string CLASS_NAME = "java.nio.ByteBuffer";

        public AndroidByteBuffer(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidByteBuffer Allocate(int capacity)
        {
            using (var AndroidByteBufferClass = new AndroidJavaClass(CLASS_NAME))
            {
                return new AndroidByteBuffer(AndroidByteBufferClass.CallStatic<AndroidJavaObject>("allocate", capacity));
            }
        }

        public void Put(byte value)
        {
            JavaObject.Call("put", value);
        }

        public byte Get()
        {
            return JavaObject.Call<byte>("get");
        }

        public void Flip()
        {
            JavaObject.Call("flip");
        }

        public void Clear()
        {
            JavaObject.Call("clear");
        }

        public bool HasRemaining()
        {
            return JavaObject.Call<bool>("hasRemaining");
        }

        public int Remaining()
        {
            return JavaObject.Call<int>("remaining");
        }

        public int Capacity()
        {
            return JavaObject.Call<int>("capacity");
        }

        public int Position()
        {
            return JavaObject.Call<int>("position");
        }

        public void Rewind()
        {
            JavaObject.Call("rewind");
        }

        public override string ToString()
        {
            return JavaObject.Call<string>("toString");
        }
    }
}
