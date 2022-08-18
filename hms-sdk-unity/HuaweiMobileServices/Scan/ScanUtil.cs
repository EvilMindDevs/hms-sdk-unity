using HuaweiMobileServices.Nearby.Discovery;
using HuaweiMobileServices.Utils;

using System;

using UnityEngine;

namespace HuaweiMobileServices.Scan
{
    public class ScanUtil : JavaObjectWrapper
    {
        public ScanUtil(AndroidJavaObject javaObject) : base(javaObject) { }
        public ScanUtil() : base("com.huawei.hms.hmsscankit.ScanUtil") { }

        private static readonly AndroidJavaClass scanKitBridge = new AndroidJavaClass("org.m0skit0.android.hms.unity.scan.bridge.ScanKitBridge");
        private static readonly AndroidJavaClass scanUtil = new AndroidJavaClass("com.huawei.hms.hmsscankit.ScanUtil");

        public static int SUCCESS => scanUtil.GetStatic<int>("SUCCESS");
        public static string RESULT => scanUtil.GetStatic<string>("RESULT");
        public static int ERROR_NO_CAMERA_PERMISSION => scanUtil.GetStatic<int>("ERROR_NO_CAMERA_PERMISSION");
        public static int ERROR_NO_READ_PERMISSION => scanUtil.GetStatic<int>("ERROR_NO_READ_PERMISSION ");
        public static int CAMERA_ININT_ERROR => scanUtil.GetStatic<int>("CAMERA_ININT_ERROR ");


        public static AndroidBitmap BuildBitmap(String content, int type, int width, int height, HmsBuildBitmapOption options) => scanUtil.CallStaticAsWrapper<AndroidBitmap>("buildBitmap", content, type, width, height, options);
        public static AndroidBitmap CompressBitmap(String path) => scanUtil.CallStaticAsWrapper<AndroidBitmap>("compressBitmap", AndroidContext.ActivityContext, path);
        public static HmsScan[] DecodeWithBitmap(AndroidBitmap bitmap, HmsScanAnalyzerOptions format) => scanUtil.Call<HmsScan[]>("decodeWithBitmap", AndroidContext.ActivityContext, bitmap, format);

        public static void StartScan(Action<String, HmsScan> onSuccess, Action<HMSException> onFailure, HmsScanAnalyzerOptions options)
        {
            var callback = new ScanBridgeCallbackWrapper()
                .AddOnFailureListener((exception) =>
                {
                    onFailure.Invoke(exception);
                })
                .AddOnSuccessListener((text, hmsScan) =>
                {
                    onSuccess.Invoke(text, hmsScan);
                });

            scanKitBridge.CallStatic("receiveShow", callback, options.JavaObject);
        }
    }
}