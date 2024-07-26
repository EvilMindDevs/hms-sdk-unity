using System;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public static class AndroidFilePicker
    {
        private const string OPEN_DOCUMENT = "android.intent.action.GET_CONTENT";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.helper.FilePicker.FilePickerBridge");
        public static Action<AndroidIntent, AndroidBitmap> mOnSuccessListener;
        public static Action<HMSException> mOnFailureListener;

        public static void ShowFilePicker(AndroidJavaObject intent)
        {
            var callback = new FilePickerCallBackWrapper()
            .AddOnFailureListener(mOnFailureListener)
            .AddOnSuccessListener((data, bitmap) =>
            {
                HMSDispatcher.InvokeAsync(() => { mOnSuccessListener.Invoke(data, bitmap); });
            });
            sJavaClass.CallStatic("receiveShow", intent, callback);
        }

        public static void OpenFilePicker(string type = null)
        {
            mOnSuccessListener += (data, bitmap) =>
            {
                Debug.Log("[HMS] FilePicker: SuccessPath: " + data.GetData()?.GetPath);
                Debug.Log("[HMS] FilePicker: SuccessBitmap: " + bitmap == null ? "null" : "not null");
            };

            mOnFailureListener += (exception) =>
            {
                Debug.Log("[HMS] FilePicker: Failure: " + exception.Message);
            };

            AndroidIntent openFileIntent = new AndroidIntent(OPEN_DOCUMENT)
            .AddFlags(AndroidIntent.FLAG_GRANT_READ_URI_PERMISSION)
            .AddFlags(AndroidIntent.FLAG_GRANT_WRITE_URI_PERMISSION)
            .AddFlags(AndroidIntent.FLAG_GRANT_PERSISTABLE_URI_PERMISSION)
            .AddFlags(AndroidIntent.FLAG_GRANT_PREFIX_URI_PERMISSION)
            .AddCategory("android.intent.category.OPENABLE")
            .SetType(type ?? "*/*"); // Set mime type to pick any type of file

            ShowFilePicker(openFileIntent.JavaObject);
        }
    }

    public class FilePickerCallBackWrapper : AndroidJavaProxy
    {
        private Action<AndroidIntent, AndroidBitmap> mOnSuccessListener;
        private Action<HMSException> mOnFailureListener;
        public FilePickerCallBackWrapper() : base("org.m0skit0.android.hms.unity.helper.FilePicker.FilePickerBridgeCallback") { }
        public FilePickerCallBackWrapper AddOnSuccessListener(Action<AndroidIntent, AndroidBitmap> onSuccessListener)
        {
            mOnSuccessListener = onSuccessListener;
            return this;
        }

        public FilePickerCallBackWrapper AddOnFailureListener(Action<HMSException> onFailureListener)
        {
            mOnFailureListener = onFailureListener;
            return this;
        }
        public void onSuccess(AndroidJavaObject data, AndroidJavaObject bitmap)
        {
            this.CallOnMainThread(() => { mOnSuccessListener?.Invoke(data.AsWrapper<AndroidIntent>(), bitmap.AsWrapper<AndroidBitmap>()); });
        }

        public void onFailure(AndroidJavaObject exception)
        {
            this.CallOnMainThread(() => { mOnFailureListener?.Invoke(exception.AsException()); });
        }
    }
}
