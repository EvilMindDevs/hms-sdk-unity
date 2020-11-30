

namespace HuaweiMobileServices.Drive
{
    using HuaweiMobileServices.Utils;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UnityEngine;
    public class MediaHttpUploaderProgressListenerWrapper : AndroidJavaProxy
    {
        private readonly IMediaHttpUploaderProgressListener mListener;

        public MediaHttpUploaderProgressListenerWrapper(IMediaHttpUploaderProgressListener listener) : base("com.huawei.cloud.base.media.MediaHttpUploaderProgressListener")
        {
            mListener = listener;
        }

        /*public void progressChanged(MediaHttpUploader uploader)
        {
            mListener.progressChanged(uploader);
        }*/
        public void progressChanged(AndroidJavaObject uploader)
        {
            mListener.progressChanged(uploader.AsWrapper<MediaHttpUploader>());
        }

    }
}
