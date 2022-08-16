using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.Scan
{
    public class HmsBuildBitmapOption : JavaObjectWrapper
    {
        public HmsBuildBitmapOption(AndroidJavaObject javaObject) : base(javaObject) { }
        public HmsBuildBitmapOption() : base("com.huawei.hms.ml.scan.HmsBuildBitmapOption") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsBuildBitmapOption");
        public string ToString() => CallAsString("toString");

        internal class Creator : JavaObjectWrapper
        {
            public Creator(AndroidJavaObject javaObject) : base(javaObject) { }
            public Creator() : base("com.huawei.hms.ml.scan.HmsBuildBitmapOption$Creator") { }
            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsBuildBitmapOption$Creator");
            public HmsBuildBitmapOption Create() => CallAsWrapper<HmsBuildBitmapOption>("create");
            public Creator SetBitmapBackgroundColor(int color) => CallAsWrapper<Creator>("setBitmapBackgroundColor", color);
            public Creator SetBitmapColor(int color) => CallAsWrapper<Creator>("setBitmapColor", color);
            public Creator SetBitmapMargin(int margin) => CallAsWrapper<Creator>("setBitmapMargin", margin);
            public Creator SetQRErrorCorrection(ErrorCorrectionLevel level) => CallAsWrapper<Creator>("setQRErrorCorrection", level);
            public Creator SetQRLogoBitmap(Bitmap bitmap) => CallAsWrapper<Creator>("setQRLogoBitmap", bitmap);
        }

        internal class ErrorCorrectionLevel : JavaObjectWrapper
        {
            public ErrorCorrectionLevel(AndroidJavaObject javaObject) : base(javaObject) { }
            public ErrorCorrectionLevel() : base("com.huawei.hms.ml.scan.HmsBuildBitmapOption$ErrorCorrectionLevel") { }
            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsBuildBitmapOption$ErrorCorrectionLevel");
            public string Value => sJavaClass.CallStaticAsString("value");
        }
    }
}