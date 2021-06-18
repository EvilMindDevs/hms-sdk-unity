namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.archive.Archive
    public class Archive : JavaObjectWrapper
    {
        
        public Archive(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual ArchiveSummary Summary => CallAsWrapper<ArchiveSummary>("getSummary");

        public virtual ArchiveDetails Details => CallAsWrapper<ArchiveDetails>("getDetails");
    }

}