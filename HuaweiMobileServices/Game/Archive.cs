namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    // Wrapper for com.huawei.hms.jos.games.archive.Archive
    public class Archive : JavaObjectWrapper
    {
        public Archive(AndroidJavaObject javaObject) : base(javaObject) { }

        ArchiveSummary Summary => CallAsWrapper<ArchiveSummary>("getSummary");

        ArchiveDetails Details => CallAsWrapper<ArchiveDetails>("getDetails");
    }

}