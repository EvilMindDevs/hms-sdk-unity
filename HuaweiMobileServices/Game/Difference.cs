namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;

    public class Difference : JavaObjectWrapper
    {
        public Difference(AndroidJavaObject javaObject) : base(javaObject) { }

        public Archive ServerArchive => CallAsWrapper<Archive>("getServerArchive");

        public ArchiveDetails EmptyArchiveDetails => CallAsWrapper<ArchiveDetails>("getEmptyArchiveDetails");

        public Archive RecentArchive() => CallAsWrapper<Archive>("getRecentArchive");
    }
}
