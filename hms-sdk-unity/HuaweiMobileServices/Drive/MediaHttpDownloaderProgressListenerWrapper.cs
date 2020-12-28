
namespace HuaweiMobileServices.Drive
{
    using HuaweiMobileServices.Utils;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UnityEngine;

    public class MediaHttpDownloaderProgressListenerWrapper : AndroidJavaProxy
    {
        private readonly IMediaHttpDownloaderProgressListener mListener;

        public MediaHttpDownloaderProgressListenerWrapper(IMediaHttpDownloaderProgressListener listener) : base("com.huawei.cloud.base.media.MediaHttpDownloaderProgressListener")
        {
            mListener = listener;
        }

        public void ProgressChanged(MediaHttpDownloader downloader)
        {
            mListener.progressChanged(downloader);
        }
    }
}
