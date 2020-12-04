using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Drive
{
    public interface IMediaHttpUploaderProgressListener
    {
        void progressChanged(MediaHttpUploader uploader);
    }
}
