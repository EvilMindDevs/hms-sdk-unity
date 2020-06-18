namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.archive.Archive
    public class Archive : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Archive(AndroidJavaObject javaObject) : base(javaObject) { }

        ArchiveSummary Summary => CallAsWrapper<ArchiveSummary>("getSummary");

        ArchiveDetails Details => CallAsWrapper<ArchiveDetails>("getDetails");
    }

}