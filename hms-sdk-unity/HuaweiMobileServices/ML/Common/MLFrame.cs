using HuaweiMobileServices.Ads;
using HuaweiMobileServices.Utils;
using System;
using UnityEngine;

namespace HuaweiMobileServices.ML.Common
{
    public class MLFrame : JavaObjectWrapper
    {
        private const string CLASS_NAME = "com.huawei.hms.mlsdk.common.MLFrame";
        private readonly static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
        public MLFrame(AndroidJavaObject javaObject) : base(javaObject) { }

        public static int SCREEN_FIRST_QUADRANT => sJavaClass.GetStaticFieldCached<int>(nameof(SCREEN_FIRST_QUADRANT)); // 0
        public static int SCREEN_SECOND_QUADRANT => sJavaClass.GetStaticFieldCached<int>(nameof(SCREEN_SECOND_QUADRANT)); // 1
        public static int SCREEN_THIRD_QUADRANT => sJavaClass.GetStaticFieldCached<int>(nameof(SCREEN_THIRD_QUADRANT)); // 2
        public static int SCREEN_FOURTH_QUADRANT => sJavaClass.GetStaticFieldCached<int>(nameof(SCREEN_FOURTH_QUADRANT)); // 3

        public AndroidByteBuffer AcquireGrayByteBuffer() => CallAsWrapper<AndroidByteBuffer>("acquireGrayByteBuffer");
        public Property AcquireProperty() => CallAsWrapper<Property>("acquireProperty");
        public Tuple<AndroidJavaObject, float> Create(int width, int height) // Tuple<byte[], float>
        {
            var result = Call<AndroidJavaObject>("create", width, height);
            var pair = Pair<AndroidJavaObject, float>.FromJavaObject(result);

            return new Tuple<AndroidJavaObject, float>(pair.First, pair.Second);
        }
        public void Initialize() => Call("initialize");

        public static MLFrame FromBitmap(AndroidBitmap bitmap) => sJavaClass.CallStaticAsWrapper<MLFrame>("fromBitmap", bitmap);
        public static MLFrame FromByteArray(byte[] bytes, Property property) => sJavaClass.CallStaticAsWrapper<MLFrame>("fromByteArray", bytes.AsJavaArray<byte>(), property);
        public static MLFrame FromByteBuffer(AndroidByteBuffer byteBuffer, Property property) => sJavaClass.CallStaticAsWrapper<MLFrame>("fromByteBuffer", byteBuffer, property);
        public static MLFrame FromFilePath(HuaweiMobileServices.Utils.Uri uri) => sJavaClass.CallStaticAsWrapper<MLFrame>("fromFilePath", AndroidContext.ActivityContext, uri);
        public static MLFrame FromMediaImage(AndroidImage mediaImage, int quadrant) => sJavaClass.CallStaticAsWrapper<MLFrame>("fromMediaImage", mediaImage, quadrant);

        public AndroidByteBuffer GetByteBuffer() => CallAsWrapper<AndroidByteBuffer>("getByteBuffer");
        public MLFrame GetFrame(bool bitmapOnly, bool nv21BufferOnly) => CallAsWrapper<MLFrame>("getFrame", bitmapOnly, nv21BufferOnly);
        public AndroidBitmap GetPreviewBitmap() => CallAsWrapper<AndroidBitmap>("getPreviewBitmap");
        public AndroidBitmap ReadBitmap() => CallAsWrapper<AndroidBitmap>("readBitmap");
        public AndroidBitmap Rotate(AndroidBitmap androidBitmap, int quadrant) => CallAsWrapper<AndroidBitmap>("rotate", androidBitmap, quadrant);
        public byte[] WrapJPEG(bool bitmapOnly) => Call<byte[]>("wrapJpeg", bitmapOnly);

        public class Creator : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.common.MLFrame$Creator";
            private readonly static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
            public Creator(AndroidJavaObject javaObject) : base(javaObject) { }
            public Creator() : base(CLASS_NAME) { }
            public MLFrame Create() => CallAsWrapper<MLFrame>("create");
            public Creator SetBitmap(AndroidBitmap bitmap) => CallAsWrapper<Creator>("setBitmap", bitmap);
            public Creator SetItemIdentity(int itemIdentity) => CallAsWrapper<Creator>("setItemIdentity", itemIdentity);
            public Creator SetQuadrant(int quadrant) => CallAsWrapper<Creator>("setQuadrant", quadrant);
            public Creator SetTimestamp(long timestamp) => CallAsWrapper<Creator>("setTimestamp", timestamp);
            public Creator WriteByteBufferData(AndroidByteBuffer byteBuffer, int width, int height, int formatType) => CallAsWrapper<Creator>("writeByteBufferData", byteBuffer, width, height, formatType);
        }


        public class Property : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.hms.mlsdk.common.MLFrame$Property";

            private readonly static AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

            public Property(AndroidJavaObject javaObject) : base(javaObject) { }

            public Property() : base(CLASS_NAME) { }

            public static int IMAGE_FORMAT_NV21 => sJavaClass.GetStaticFieldCached<int>(nameof(IMAGE_FORMAT_NV21)); // 17
            public static int IMAGE_FORMAT_YV12 => sJavaClass.GetStaticFieldCached<int>(nameof(IMAGE_FORMAT_YV12)); // 842094169
            public static int SCREEN_FIRST_QUADRANT => sJavaClass.GetStaticFieldCached<int>(nameof(SCREEN_FIRST_QUADRANT)); // 0
            public static int SCREEN_SECOND_QUADRANT => sJavaClass.GetStaticFieldCached<int>(nameof(SCREEN_SECOND_QUADRANT)); // 1
            public static int SCREEN_THIRD_QUADRANT => sJavaClass.GetStaticFieldCached<int>(nameof(SCREEN_THIRD_QUADRANT)); // 2
            public static int SCREEN_FOURTH_QUADRANT => sJavaClass.GetStaticFieldCached<int>(nameof(SCREEN_FOURTH_QUADRANT)); // 3

            public int FormatType => Call<int>("getFormatType");
            public int Height => Call<int>("getHeight");
            public int ItemIdentity => Call<int>("getItemIdentity");
            public int Quadrant => Call<int>("getQuadrant"); //Screen orientation => 0: landscape, 1: portrait, 2: reverse landscape, 3: reverse portrait
            public int Width => Call<int>("getWidth");
            public long Timestamp => Call<long>("getTimestamp");
            public void ResetWidthAndHeight() => Call("resetWidthAndHeight");
        }

    }
}
