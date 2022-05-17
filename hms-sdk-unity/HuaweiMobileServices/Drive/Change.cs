using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class Change : JavaObjectWrapper
    {
        public Change(AndroidJavaObject javaObject) : base(javaObject) { }
        public Change() : base("com.huawei.cloud.services.drive.model.Change") { }

        public string GetChangeType() => Call<string>("getChangeType");
        public Change SetChangeType(string var1) => CallAsWrapper<Change>("setChangeType", var1);

        public File GetFile() => CallAsWrapper<File>("getFile");
        public Change SetFile(File file) => CallAsWrapper<Change>("setFile", file);

        public string GetFileId() => Call<string>("getFileId");
        public Change SetFileId(string var1) => CallAsWrapper<Change>("setFileId", var1);

        public string GetCategory() => Call<string>("getCategory");
        public Change SetCategory(string var1) => CallAsWrapper<Change>("setCategory", var1);

        public bool GetDeleted() => CallAsBool("getDeleted");
        public Change SetDeleted(bool var1) => CallAsWrapper<Change>("setDeleted", var1);

        public Change Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Change>("set", var1, var2);
        public Change Clone() => CallAsWrapper<Change>("clone");
    }
}
