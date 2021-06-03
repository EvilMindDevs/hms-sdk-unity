

namespace HuaweiMobileServices.Drive
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;
    public class MediaHttpUploaderProgressListenerWrapper : AndroidJavaProxy
    {
        private readonly IMediaHttpUploaderProgressListener mListener;

        public MediaHttpUploaderProgressListenerWrapper(IMediaHttpUploaderProgressListener listener) : base("com.huawei.cloud.base.media.MediaHttpUploaderProgressListener")
        {
            mListener = listener;
        }
        public void progressChanged(AndroidJavaObject uploader)
        {
            this.CallOnMainThread(() => { mListener.progressChanged(uploader.AsWrapper<MediaHttpUploader>()); });
        }
    }
}
