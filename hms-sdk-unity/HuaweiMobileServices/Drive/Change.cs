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

        public string GetFile() => Call<string>("getFile");
        public Change SetFile(string var1) => CallAsWrapper<Change>("setFile", var1);

        public string GetFileId() => Call<string>("getFileId");
        public Change SetFileId(string var1) => CallAsWrapper<Change>("setFileId", var1);

        public string GetCategory() => Call<string>("getCategory");
        public Change SetCategory(string var1) => CallAsWrapper<Change>("setCategory", var1);

        public bool GetDeleted() => Call<bool>("getDeleted");
        public Change SetDeleted(bool var1) => CallAsWrapper<Change>("setDeleted", var1);

        public Channel Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Channel>("set", var1, var2);
        public Channel Clone() => CallAsWrapper<Channel>("clone");
    }
}
