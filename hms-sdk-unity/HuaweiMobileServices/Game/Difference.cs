namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class Difference : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Difference(AndroidJavaObject javaObject) : base(javaObject) { }

        public Archive ServerArchive => CallAsWrapper<Archive>("getServerArchive");

        public ArchiveDetails EmptyArchiveDetails => CallAsWrapper<ArchiveDetails>("getEmptyArchiveDetails");

        public Archive RecentArchive() => CallAsWrapper<Archive>("getRecentArchive");
    }
}
