using HuaweiMobileServices.Utils;

using UnityEngine;

namespace HuaweiMobileServices.Scan
{
    public class HmsScanBase : JavaObjectWrapper
    {
        public HmsScanBase(AndroidJavaObject javaObject) : base(javaObject) { }
        public HmsScanBase(string originalValue, int scanType, string showResult, int scanTypeForm, byte[] originValueByte, Point[] cornerPoints, HmsScanAnalyzerOptions options) : base("com.huawei.hms.ml.scan.HmsScanBase") { }

        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("com.huawei.hms.ml.scan.HmsScanBase");

        public static int ALL_SCAN_TYPE => sJavaClass.GetStatic<int>("ALL_SCAN_TYPE");
        public static int QRCODE_SCAN_TYPE => sJavaClass.GetStatic<int>("QRCODE_SCAN_TYPE");
        public static int AZTEC_SCAN_TYPE => sJavaClass.GetStatic<int>("AZTEC_SCAN_TYPE");
        public static int DATAMATRIX_SCAN_TYPE => sJavaClass.GetStatic<int>("DATAMATRIX_SCAN_TYPE");
        public static int PDF417_SCAN_TYPE => sJavaClass.GetStatic<int>("PDF417_SCAN_TYPE");
        public static int CODE39_SCAN_TYPE => sJavaClass.GetStatic<int>("CODE39_SCAN_TYPE");
        public static int CODE93_SCAN_TYPE => sJavaClass.GetStatic<int>("CODE93_SCAN_TYPE");
        public static int CODE128_SCAN_TYPE => sJavaClass.GetStatic<int>("CODE128_SCAN_TYPE");
        public static int EAN13_SCAN_TYPE => sJavaClass.GetStatic<int>("EAN13_SCAN_TYPE");
        public static int EAN8_SCAN_TYPE => sJavaClass.GetStatic<int>("EAN8_SCAN_TYPE");
        public static int ITF14_SCAN_TYPE => sJavaClass.GetStatic<int>("ITF14_SCAN_TYPE");
        public static int UPCCODE_A_SCAN_TYPE => sJavaClass.GetStatic<int>("UPCCODE_A_SCAN_TYPE");
        public static int UPCCODE_E_SCAN_TYPE => sJavaClass.GetStatic<int>("UPCCODE_E_SCAN_TYPE");
        public static int CODABAR_SCAN_TYPE => sJavaClass.GetStatic<int>("CODABAR_SCAN_TYPE");
        public static int OTHER_FORM => sJavaClass.GetStatic<int>("OTHER_FORM");

        public Rect GetBorderRect() => CallAsWrapper<Rect>("getBorderRect");
        public Point[] GetCornerPoints() => CallAsWrapperArray<Point>("getCornerPoints");
        public Bitmap GetOriginalBitmap() => CallAsWrapper<Bitmap>("getOriginalBitmap");
        public string GetOriginalValue() => CallAsString("getOriginalValue");
        public byte[] GetOriginValueByte() => Call<byte[]>("getOriginValueByte");
        public int GetScanType() => Call<int>("getScanType");
        public int GetScanTypeForm() => Call<int>("getScanTypeForm");
        public string GetShowResult() => CallAsString("getShowResult");
        public double GetZoomValue() => Call<double>("getZoomValue");

    }
}