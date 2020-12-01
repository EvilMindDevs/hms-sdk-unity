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
        private static readonly string CLASS_NAME = "com.huawei.hms.jos.games.archive.ArchiveSummaryUpdate";
        AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);

        public string DescInfo
        {
            get => Call<string>("getDescInfo");
        }

        public long? ActiveTime
        {
            get => sJavaClass.Call<AndroidJavaObject>("getActiveTime").AsLong();
        }

        public long? CurrentProgress
        {
            get => sJavaClass.Call<AndroidJavaObject>("getCurrentProgress").AsLong();
        }

        public AndroidBitmap Thumbnail
        {
            get => Call<AndroidBitmap>("getThumbnail");
        }

        public string ThumbnailMimeType
        {
            get => Call<string>("getThumbnailMimeType");
        }

        // Wrapper for  com.huawei.hms.jos.games.archive.ArchiveSummaryUpdate.Builder
        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.jos.games.archive.ArchiveSummaryUpdate$Builder") { }

            public ArchiveSummaryUpdate Build() => CallAsWrapper<ArchiveSummaryUpdate>("build");

            public Builder FromSummary(ArchiveSummary summary)
            {
                JavaObject = Call<AndroidJavaObject>("fromSummary", summary);
                return this;
            }
            public Builder SetActiveTime(long setActiveTime)
            {
                JavaObject = Call<AndroidJavaObject>("setActiveTime", setActiveTime);
                return this;
            }
            public Builder SetCurrentProgress(long progressValue)
            {
                JavaObject = Call<AndroidJavaObject>("setCurrentProgress", progressValue);
                return this;
            }
            public Builder SetDescInfo(String description)
            {
                JavaObject = Call<AndroidJavaObject>("setDescInfo", description);
                return this;
            }
            public Builder SetThumbnail(AndroidBitmap bitmap)
            {
                JavaObject = Call<AndroidJavaObject>("setThumbnail", bitmap);
                return this;
            }
            public Builder SetThumbnailMimeType(String imageMimeType)
            {
                JavaObject = Call<AndroidJavaObject>("setThumbnailMimeType", imageMimeType);
                return this;
            }
        }
    }
}