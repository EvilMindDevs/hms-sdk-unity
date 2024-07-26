using System;
using UnityEngine;

namespace HuaweiMobileServices.Utils
{
    public static class AndroidFolderPicker
    {
        private const string OPEN_DOCUMENT_TREE = "android.intent.action.OPEN_DOCUMENT_TREE";
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.GenericBridge");
        public static Action<AndroidIntent> mOnSuccessListener;
        public static Action<HMSException> mOnFailureListener;

        public static void ShowFolderPicker(AndroidJavaObject intent)
        {

            var callback = new GenericBridgeCallbackWrapper()
            .AddOnFailureListener(mOnFailureListener)
            .AddOnSuccessListener((nothing) =>
            {
                HMSDispatcher.InvokeAsync(() => { mOnSuccessListener.Invoke(nothing); });
            });
            sJavaClass.CallStatic("receiveShow", intent, callback);
        }

        public static void OpenFolderPicker()
        {
            mOnSuccessListener += (data) =>
            {
                Debug.Log("[HMS] FolderPicker: Success: " + data.GetData()?.GetPath);
            };

            mOnFailureListener += (exception) =>
            {
                Debug.Log("[HMS] FolderPicker: Failure: " + exception.Message);
            };
            AndroidIntent openFolderIntent = new AndroidIntent(OPEN_DOCUMENT_TREE)
            .AddFlags(AndroidIntent.FLAG_GRANT_READ_URI_PERMISSION)
            .AddFlags(AndroidIntent.FLAG_GRANT_WRITE_URI_PERMISSION)
            .AddFlags(AndroidIntent.URI_ALLOW_UNSAFE)
            .AddFlags(AndroidIntent.FLAG_GRANT_PERSISTABLE_URI_PERMISSION);

            ShowFolderPicker(openFolderIntent.JavaObject);

        }
    }

}