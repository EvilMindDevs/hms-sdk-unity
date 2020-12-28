using System.IO;

namespace HuaweiMobileServices.Drive
{
    using HuaweiMobileServices.Utils;
    using System;
    using System.Collections.Generic;
    using UnityEngine;


    public class Drive : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Drive(AndroidJavaObject javaObject) : base(javaObject) { }

        public Drive.Files files() => CallAsWrapper<Drive.Files>("files");

        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder(DriveCredential credential) : base("com.huawei.cloud.services.drive.Drive$Builder", credential, AndroidContext.ActivityContext){}

            public Drive Build() => CallAsWrapper<Drive>("build");
        }

        public class Files : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Files(AndroidJavaObject javaObject) : base(javaObject) { }

            public Drive.Files.Copy copy(String var1, File var2) => CallAsWrapper<Drive.Files.Copy>("copy", var1, var2);

            public Create create(File var1) => CallAsWrapper<Drive.Files.Create>("create", var1);

            public Drive.Files.Create create(File var1, FileContent var2) => CallAsWrapper<Drive.Files.Create>("create", var1, var2);

            public Drive.Files.Create create(File var1, InputStreamContent var2) => CallAsWrapper<Drive.Files.Create>("create", var1, var2);

            public Drive.Files.Delete delete(String var1) => CallAsWrapper<Drive.Files.Delete>("delete", var1);

            public Drive.Files.EmptyRecycle emptyRecycle() => CallAsWrapper<Drive.Files.EmptyRecycle>("emptyRecycle");

            public Drive.Files.Get get(String var1) => CallAsWrapper<Drive.Files.Get>("get", var1);

            public Drive.Files.List list() => CallAsWrapper<Drive.Files.List>("list");

            public Drive.Files.Update update(String var1, File var2) => CallAsWrapper<Drive.Files.Update>("update", var1, var2);

            public Drive.Files.Update update(String var1, File var2, AndroidJavaObject var3) => CallAsWrapper<Drive.Files.Update>("update", var1, var2, var3);

            public Drive.Files.Subscribe subscribe(String var1, Channel var2) => CallAsWrapper<Drive.Files.Subscribe>("update", var1, var2);
            public class Subscribe : DriveRequest<Channel>
            {

                [UnityEngine.Scripting.Preserve]
                public Subscribe(AndroidJavaObject javaObject) : base(javaObject) { }

                public Drive.Files.Subscribe SetForm(String var1) => CallAsWrapper<Drive.Files.Subscribe>("setForm", var1);

                public Drive.Files.Subscribe SetFields(String var1) => CallAsWrapper<Drive.Files.Subscribe>("setFields", var1);

                public Drive.Files.Subscribe SetPrettyPrint(Boolean var1) => CallAsWrapper<Drive.Files.Subscribe>("setPrettyPrint", var1);

                public Drive.Files.Subscribe SetQuotaId(String var1) => CallAsWrapper<Drive.Files.Subscribe>("setQuotaId", var1);

                public String GetFileId() => Call<String>("getFileId");

                public Drive.Files.Subscribe SetFileId(String var1) => CallAsWrapper<Drive.Files.Subscribe>("setFileId", var1);

                public Drive.Files.Subscribe Set(String var1, AndroidJavaObject var2) => CallAsWrapper<Drive.Files.Subscribe>("set", var1, var2);
            }

            public class Update : DriveRequest<Comment>
            {

                [UnityEngine.Scripting.Preserve]
                public Update(AndroidJavaObject javaObject) : base(javaObject) { }

                public Drive.Files.Update SetFields(String var1) => CallAsWrapper<Drive.Files.Update>("setFields", var1);

                public Drive.Files.Update SetForm(String var1) => CallAsWrapper<Drive.Files.Update>("setForm", var1);

                public Drive.Files.Update SetPrettyPrint(Boolean var1) => CallAsWrapper<Drive.Files.Update>("setPrettyPrint", var1);

                public Drive.Files.Update SetQuotaId(String var1) => CallAsWrapper<Drive.Files.Update>("setQuotaId", var1);
                public String GetFileId() => Call<String>("getFileId");

                public Drive.Files.Update SetFileId(String var1) => CallAsWrapper<Drive.Files.Update>("setFileId", var1);

                public String GetAddParentFolder() => Call<String>("getParentFolder");

                public Drive.Files.Update SetAddParentFolder(String var1) => CallAsWrapper<Drive.Files.Update>("setAddParentFolder", var1);

                public String GetRemoveParentFolder() => Call<String>("getRemoveParentFolder");

                public Drive.Files.Update SetRemoveParentFolder(String var1) => CallAsWrapper<Drive.Files.Update>("SetRemoveParentFolder", var1);

                public Drive.Files.Update Set(String var1, AndroidJavaObject var2) => CallAsWrapper<Drive.Files.Update>("set", var1, var2);
            }

            public class List : DriveRequest<FileList>
            {


                [UnityEngine.Scripting.Preserve]
                public List(AndroidJavaObject javaObject) : base(javaObject) { }

                public FileList Execute() => CallAsWrapper<FileList>("execute");
                public Drive.Files.List SetFields(String var1) => CallAsWrapper<Drive.Files.List>("setFields", var1);

                public Drive.Files.List SetForm(String var1) => CallAsWrapper<Drive.Files.List>("setForm", var1);

                public Drive.Files.List SetPrettyPrint(Boolean var1) => CallAsWrapper<Drive.Files.List>("setPrettyPrint", var1);

                public Drive.Files.List SetQuotaId(String var1) => CallAsWrapper<Drive.Files.List>("setQuotaId", var1);

                public String GetOrderBy() => Call<String>("getOrderBy");
                public Drive.Files.List SetOrderBy(String var1) => CallAsWrapper<Drive.Files.List>("setOrderBy", var1);

                public int GetPageSize() => Call<int>("getPageSize");

                public Drive.Files.List SetPageSize(int var1) => CallAsWrapper<Drive.Files.List>("setPageSize", var1);

                public String GetCursor() => Call<String>("getCursor");

                public Drive.Files.List SetCursor(String var1) => CallAsWrapper<Drive.Files.List>("setCursor", var1);

                public String GetQueryParam() => Call<String>("getQueryParam");

                public Drive.Files.List SetQueryParam(String var1) => CallAsWrapper<Drive.Files.List>("setQueryParam", var1);

                public String GetContainers() => Call<String>("getContainers");

                public Drive.Files.List SetContainers(String var1) => CallAsWrapper<Drive.Files.List>("setContainers", var1);

                public Drive.Files.List Set(String var1, AndroidJavaObject var2) => CallAsWrapper<Drive.Files.List>("set", var1, var2);
            }

            public class Get : DriveRequest<File>
            {
                [UnityEngine.Scripting.Preserve]
                public Get(AndroidJavaObject javaObject) : base(javaObject) { }

                public File Execute() => CallAsWrapper<File>("execute");

                public void ExecuteContentAndDownloadTo(AndroidJavaObject var1) => Call("executeContentAndDownloadTo", var1);

                public AndroidJavaObject ExecuteContentAsInputStream() => Call<AndroidJavaObject>("executeContentAsInputStream");

                public AndroidJavaObject ExecuteContent() => Call<AndroidJavaObject>("executeContent");

                public Drive.Files.Get SetFields(String var1) => CallAsWrapper<Drive.Files.Get>("setFields", var1);

                public Drive.Files.Get SetForm(String var1) => CallAsWrapper<Drive.Files.Get>("setForm", var1);

                public Drive.Files.Get SetPrettyPrint(Boolean var1) => CallAsWrapper<Drive.Files.Get>("setPrettyPrint", var1);

                public Drive.Files.Get SetQuotaId(String var1) => CallAsWrapper<Drive.Files.Get>("setQuotaId", var1);

                public String GetFileId() => Call<String>("getFileId");

                public Drive.Files.Get SetFileId(String var1) => CallAsWrapper<Drive.Files.Get>("setFileId", var1);

                public bool GetAcknowledgeDownloadRisk() => Call<bool>("getAcknowledgeDownloadRisk");

                public bool IsAcknowledgeDownloadRisk() => Call<bool>("IsAcknowledgeDownloadRisk");

                public Drive.Files.Get SetAcknowledgeDownloadRisk(Boolean var1) => CallAsWrapper<Drive.Files.Get>("setAcknowledgeDownloadRisk", var1);

                public Drive.Files.Get Set(String var1, AndroidJavaObject var2) => CallAsWrapper<Drive.Files.Get>("set", var1, var2);
            }
            public class EmptyRecycle : DriveRequest<Utils.Void>
            {

                [UnityEngine.Scripting.Preserve]
                public EmptyRecycle(AndroidJavaObject javaObject) : base(javaObject) { }

                public Drive.Files.EmptyRecycle SetForm(String var1) => CallAsWrapper<Drive.Files.EmptyRecycle>("setForm", var1);

                public Drive.Files.EmptyRecycle SetFields(String var1) => CallAsWrapper<Drive.Files.EmptyRecycle>("setFields", var1);

                public Drive.Files.EmptyRecycle SetPrettyPrint(Boolean var1) => CallAsWrapper<Drive.Files.EmptyRecycle>("setPrettyPrint", var1);

                public Drive.Files.EmptyRecycle SetQuotaId(String var1) => CallAsWrapper<Drive.Files.EmptyRecycle>("setQuotaId", var1);

                public Drive.Files.EmptyRecycle Set(String var1, AndroidJavaObject var2) => CallAsWrapper<Drive.Files.EmptyRecycle>("set", var1, var2);
            }
            public class Delete : DriveRequest<Utils.Void>
            {

                [UnityEngine.Scripting.Preserve]
                public Delete(AndroidJavaObject javaObject) : base(javaObject) { }

                public Drive.Files.Delete SetForm(String var1) => CallAsWrapper<Drive.Files.Delete>("setForm", var1);

                public Drive.Files.Delete SetFields(String var1) => CallAsWrapper<Drive.Files.Delete>("setFields", var1);

                public Drive.Files.Delete SetPrettyPrint(Boolean var1) => CallAsWrapper<Drive.Files.Delete>("setPrettyPrint", var1);

                public Drive.Files.Delete SetQuotaId(String var1) => CallAsWrapper<Drive.Files.Delete>("setQuotaId", var1);

                public Drive.Files.Delete Set(String var1, AndroidJavaObject var2) => CallAsWrapper<Drive.Files.Delete>("set", var1, var2);
            }

            public class Create : DriveRequest<File>
            {
                [UnityEngine.Scripting.Preserve]
                public Create(AndroidJavaObject javaObject) : base(javaObject) { }


                public Drive.Files.Create SetForm(String var1) => CallAsWrapper<Drive.Files.Create>("setForm", var1);

                public File Execute() => CallAsWrapper<File>("execute");

                public Drive.Files.Create SetPrettyPrint(Boolean var1) => CallAsWrapper<Drive.Files.Create>("setPrettyPrint", var1);

                public Drive.Files.Create SetQuotaId(String var1) => CallAsWrapper<Drive.Files.Create>("setQuotaId", var1);

                public Drive.Files.Create SetFields(String var1) => CallAsWrapper<Drive.Files.Create>("setFields", var1);

                public Drive.Files.Create Set(String var1, AndroidJavaObject var2) => CallAsWrapper<Drive.Files.Create>("set", var1, var2);
            }

            public class Copy : DriveRequest<File>
            {
                [UnityEngine.Scripting.Preserve]
                public Copy(AndroidJavaObject javaObject) : base(javaObject) { }

                public Drive.Files.Copy SetForm(String var1) => CallAsWrapper<Drive.Files.Copy>("setForm", var1);

                public Drive.Files.Copy SetFields(String var1) => CallAsWrapper<Drive.Files.Copy>("setFields", var1);

                public Drive.Files.Copy SetPrettyPrint(Boolean var1) => CallAsWrapper<Drive.Files.Copy>("setPrettyPrint", var1);

                public Drive.Files.Copy SetQuotaId(String var1) => CallAsWrapper<Drive.Files.Copy>("setQuotaId", var1);

                public Drive.Files.Copy Set(String var1, AndroidJavaObject var2) => CallAsWrapper<Drive.Files.Copy>("set", var1, var2);

            }

        }

        public class DriveScopes : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.cloud.services.drive.DriveScopes";

            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
            public static String SCOPE_DRIVE = sJavaClass.GetStatic<String>("SCOPE_DRIVE");
            public static String SCOPE_DRIVE_FILE = sJavaClass.GetStatic<String>("SCOPE_DRIVE_FILE");
            public static String SCOPE_DRIVE_READONLY = sJavaClass.GetStatic<String>("SCOPE_DRIVE_READONLY");
            public static String SCOPE_DRIVE_METADATA = sJavaClass.GetStatic<String>("SCOPE_DRIVE_METADATA");
            public static String SCOPE_DRIVE_METADATA_READONLY = sJavaClass.GetStatic<String>("SCOPE_DRIVE_METADATA_READONLY");
            public static String SCOPE_DRIVE_APPDATA = sJavaClass.GetStatic<String>("SCOPE_DRIVE_APPDATA");

            [UnityEngine.Scripting.Preserve]
            public DriveScopes(AndroidJavaObject javaObject) : base(javaObject) { }

            public static HashSet<String> all()
            {
                HashSet<String> var0 = new HashSet<String>();
                var0.Add(DriveScopes.SCOPE_DRIVE);
                var0.Add(DriveScopes.SCOPE_DRIVE_FILE);
                var0.Add(DriveScopes.SCOPE_DRIVE_READONLY);
                var0.Add(DriveScopes.SCOPE_DRIVE_METADATA);
                var0.Add(DriveScopes.SCOPE_DRIVE_METADATA_READONLY);
                var0.Add(DriveScopes.SCOPE_DRIVE_APPDATA);
                return var0;
            }
        }
    }
}
