using System;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.archive.ArchiveSummaryUpdate
    public class ArchiveSummaryUpdate : JavaObjectWrapper
    {

        [UnityEngine.Scripting.Preserve]
        public ArchiveSummaryUpdate(AndroidJavaObject javaObject) : base(javaObject) { }

        public string DescInfo => throw new NotImplementedException();

        public long? ActiveTime => throw new NotImplementedException();

        public long? CurrentProgress => throw new NotImplementedException();

        public AndroidBitmap Thumbnail => throw new NotImplementedException();

        public string ThumbnailMimeType => throw new NotImplementedException();
    }

}