﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Drive
{
    public interface IMediaHttpDownloaderProgressListener
    {
        void progressChanged(MediaHttpDownloader downloader);
    }
}
