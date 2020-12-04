using System.IO;

namespace HuaweiMobileServices.Drive
{
   // using Google.Apis.Drive.v3.Data;
    using HuaweiMobileServices.Utils;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UnityEngine;

   
    public class Drive : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Drive(AndroidJavaObject javaObject) : base(javaObject) { }

        //public Drive.About about()
        //{
        //    return new Drive.About();
        //}
        //public Drive.Changes changes()
        //{
        //    return new Drive.Changes();
        //}

        //public Drive.Channels channels()
        //{
        //    return new Drive.Channels();
        //}

        public Drive.Files files()
        {
            return CallAsWrapper<Drive.Files>("files");
        }

        //public Drive.Replies replies()
        //{
        //    return CallAsWrapper<Drive.Files>("files");

        //}

        //public Drive.Comments comments()
        //{
        //    return CallAsWrapper<Drive.Files>("files");

        //}

        //public Drive.HistoryVersions historyVersions()
        //{
        //    return CallAsWrapper<Drive.Files>("files");

        //}

        //TODO: batch method
        /*  public sealed BatchRequest batch()
          {

          }*/


        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder(DriveCredential credential) : base("com.huawei.cloud.services.drive.Drive$Builder", credential, AndroidContext.ActivityContext)
            {
            }

            public Drive Build() => CallAsWrapper<Drive>("build");
        }



        //public class About
        //{
        //    public About()
        //    {
        //    }

        //    public class Get : JavaObjectWrapper
        //    {
        //        private Get() : base("com.huawei.cloud.services.drive.model.About.class") { }

        //        public Drive.About.Get setFields(String fields)
        //        {
        //            return CallAsWrapper<Drive.About.Get>("setFields", fields);
        //        }

        //        public Drive.About.Get setForm(String var1)
        //        {
        //            return CallAsWrapper<Drive.About.Get>("setForm", var1);
        //        }

        //        public Drive.About.Get setPrettyPrint(Boolean var1)
        //        {
        //            return CallAsWrapper<Drive.About.Get>("setPrettyPrint", var1);
        //        }

        //        public Drive.About.Get setQuotaId(String var1)
        //        {
        //            return CallAsWrapper<Drive.About.Get>("setQuotaId", var1);
        //        }

        //        public Drive.About.Get set(String var1, AndroidJavaObject var2)
        //        {
        //            return CallAsWrapper<Drive.About.Get>("set", var1, var2);
        //        }
        //    }



        //}

        //public class Changes
        //{
        //    public class GetStartCursor : JavaObjectWrapper
        //    {


        //        private GetStartCursor() : base("com.huawei.cloud.services.drive.model.changes/getStartCursor") { }


        //        public Drive.Changes.GetStartCursor setForm(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.GetStartCursor>("setForm", var1);
        //        }

        //        public Drive.Changes.GetStartCursor setFields(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.GetStartCursor>("setFields", var1);

        //        }

        //        public Drive.Changes.GetStartCursor setPrettyPrint(Boolean var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.GetStartCursor>("setPrettyPrint", var1);

        //        }

        //        public Drive.Changes.GetStartCursor setQuotaId(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.GetStartCursor>("setQuotaId", var1);

        //        }

        //        public Drive.Changes.GetStartCursor set(String var1, AndroidJavaObject var2)
        //        {
        //            return CallAsWrapper<Drive.Changes.GetStartCursor>("set", var1, var2);

        //        }
        //    }

        //    public class List : DriveRequest<FileList>
        //    {
               
        //        public List(AndroidJavaObject javaObject) : base(javaObject) { }

               
        //        public Drive.Changes.List SetForm(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.List>("setForm", var1);
        //        }

        //        public Drive.Changes.List SetFields(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.List>("setFields", var1);
        //        }

        //        public Drive.Changes.List SetPrettyPrint(Boolean var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.List>("setPrettyPrint", var1);
        //        }

        //        public Drive.Changes.List SetQuotaId(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.List>("setQuotaId", var1);
        //        }

        //        public String GetCursor()
        //        {
        //            return Call<String>("getCursor");

        //        }

        //        public Drive.Changes.List SetCursor(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.List>("setPrettyPrint", var1);
        //        }

        //        public int GetPageSize()
        //        {
        //            return Call<int>("getPageSize");
        //        }

        //        public Drive.Changes.List SetPageSize(int var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.List>("setPageSize", var1);

        //        }

        //        public String GetContainers()
        //        {
        //            return Call<String>("getContainers");

        //        }

        //        public Drive.Changes.List SetContainers(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.List>("setContainers", var1);
        //        }

        //        public bool GetIncludeDeleted()
        //        {
        //            return Call<bool>("getIncludeDeleted");

        //        }

        //        public bool IsIncludeDeleted()
        //        {
        //            return Call<bool>("isIncludeDeleted");

        //        }

        //        public Drive.Changes.List SetIncludeDeleted(Boolean var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.List>("setIncludeDeleted", var1);
        //        }

        //        public Drive.Changes.List Set(String var1, AndroidJavaObject var2)
        //        {
        //            return CallAsWrapper<Drive.Changes.List>("set", var1, var2);
        //        }



        //    }
        //    public class Subscribe : JavaObjectWrapper
        //    {
                

        //        /*protected Subscribe(String var2, Channel var3)
        //        {
        //            super(Drive.this, "POST", "changes/subscribe", var3, Channel.class);
        //            this.cursor = (String) Preconditions.checkNotNull(var2, "Required parameter cursor must be specified.");
        //    }*/
        //        private Subscribe() : base("com.huawei.cloud.services.drive.model.changes/getStartCursor") { }

        //        public Drive.Changes.Subscribe setFields(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.Subscribe>("setFields", var1);
        //        }

        //        public Drive.Changes.Subscribe setForm(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.Subscribe>("setForm", var1);
        //        }

        //        public Drive.Changes.Subscribe setPrettyPrint(Boolean var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.Subscribe>("setPrettyPrint", var1);
        //        }

        //        public Drive.Changes.Subscribe setQuotaId(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.Subscribe>("setQuotaId", var1);
        //        }

        //        public String getCursor()
        //        {
        //            return Call<String>("getCursor");

        //            //return this.cursor;
        //        }

        //        public Drive.Changes.Subscribe setCursor(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.Subscribe>("setCursor", var1);
        //            //this.cursor = var1;
        //        }

        //        public int getPageSize()
        //        {
        //            return Call<int>("getPageSize");
        //            //return this.pageSize;
        //        }

        //        public Drive.Changes.Subscribe setPageSize(int var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.Subscribe>("setPageSize", var1);
        //            //this.pageSize = var1;
        //        }

        //        public String getContainers()
        //        {
        //            return Call<String>("getContainers");
        //            // return this.containers;
        //        }

        //        public Drive.Changes.Subscribe setContainers(String var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.Subscribe>("setContainers", var1);
        //            //this.containers = var1;
        //        }

        //        public Boolean getIncludeDeleted()
        //        {
        //            return Call<Boolean>("getIncludeDeleted");
        //            //return this.includeDeleted;
        //        }

        //        public Boolean isIncludeDeleted()
        //        {
        //            return Call<Boolean>("isIncludeDeleted");
        //            //return this.includeDeleted != null && this.includeDeleted != Data.NULL_BOOLEAN ? this.includeDeleted : true;
        //        }

        //        public Drive.Changes.Subscribe setIncludeDeleted(Boolean var1)
        //        {
        //            return CallAsWrapper<Drive.Changes.Subscribe>("setIncludeDeleted", var1);
        //            //this.includeDeleted = var1;
        //        }

        //        public Drive.Changes.Subscribe set(String var1, AndroidJavaObject var2)
        //        {
        //            return CallAsWrapper<Drive.Changes.Subscribe>("set", var1, var2);
        //            //return (Drive.Changes.Subscribe)super.set(var1, var2);
        //        }
        //    }

        //}

        public class Files : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Files(AndroidJavaObject javaObject) : base(javaObject) { }
           
            public Drive.Files.Copy copy(String var1, File var2) /*throws IOException*/
            {
                return CallAsWrapper<Drive.Files.Copy>("copy", var1, var2);
            }

            public Create create(File var1) /*throws IOException*/
            {
                return CallAsWrapper<Drive.Files.Create>("create", var1);

            }

            public Drive.Files.Create create(File var1, FileContent var2) /*throws IOException*/
            {
                return CallAsWrapper<Drive.Files.Create>("create", var1, var2);

            }

            public Drive.Files.Create create(File var1, InputStreamContent var2) /*throws IOException*/
            {
                return CallAsWrapper<Drive.Files.Create>("create", var1, var2);

            }

            public Drive.Files.Delete delete(String var1) /*throws IOException*/
            {
                return CallAsWrapper<Drive.Files.Delete>("delete", var1);
            }

            public Drive.Files.EmptyRecycle emptyRecycle()/*throws IOException*/
             {
                return CallAsWrapper<Drive.Files.EmptyRecycle>("emptyRecycle");

            }

            public Drive.Files.Get get(String var1)/*throws IOException*/
             {
                return CallAsWrapper<Drive.Files.Get>("get", var1);
            }

            public Drive.Files.List list() /*throws IOException*/
            {
                return CallAsWrapper<Drive.Files.List>("list");

            }

            public Drive.Files.Update update(String var1, File var2) /*throws IOException*/
             {
                return CallAsWrapper<Drive.Files.Update>("update", var1, var2);

            }

            public Drive.Files.Update update(String var1, File var2, AndroidJavaObject var3) /*throws IOException*/
            {
                return CallAsWrapper<Drive.Files.Update>("update", var1, var2, var3);

            }

            public Drive.Files.Subscribe subscribe(String var1, Channel var2) /*throws IOException*/
             {
                return CallAsWrapper<Drive.Files.Subscribe>("update", var1, var2);
            }
            public class Subscribe : DriveRequest<Channel>
            {
               // protected Subscribe(Drive var1, String var2, String var3, File var4, Type var5) : base(var1, var2, var3, var4, var5) { }
                
                [UnityEngine.Scripting.Preserve]
                public Subscribe(AndroidJavaObject javaObject) : base(javaObject) { }

                public Drive.Files.Subscribe SetForm(String var1)
                {
                    return CallAsWrapper<Drive.Files.Subscribe>("setForm", var1);
                }

                public Drive.Files.Subscribe SetFields(String var1)
                {
                    return CallAsWrapper<Drive.Files.Subscribe>("setFields", var1);
                }

                public Drive.Files.Subscribe SetPrettyPrint(Boolean var1)
                {
                    return CallAsWrapper<Drive.Files.Subscribe>("setPrettyPrint", var1);
                }

                public Drive.Files.Subscribe SetQuotaId(String var1)
                {
                    return CallAsWrapper<Drive.Files.Subscribe>("setQuotaId", var1);
                }

                public String GetFileId()
                {
                    return Call<String>("getFileId");
                }

                public Drive.Files.Subscribe SetFileId(String var1)
                {
                    return CallAsWrapper<Drive.Files.Subscribe>("setFileId", var1);
                }

                public Drive.Files.Subscribe Set(String var1, AndroidJavaObject var2)
                {
                    return CallAsWrapper<Drive.Files.Subscribe>("set", var1, var2);
                }
            }

            public class Update : DriveRequest<Comment>
            {
               
                //protected Update(Drive var1, String var2, String var3, File var4, Type var5) : base(var1, var2, var3, var4, var5) { }
                [UnityEngine.Scripting.Preserve]
                public Update(AndroidJavaObject javaObject) : base(javaObject) { }

                public Drive.Files.Update SetFields(String var1)
                {
                    return CallAsWrapper<Drive.Files.Update>("setFields", var1);

                }

                public Drive.Files.Update SetForm(String var1)
                {
                    return CallAsWrapper<Drive.Files.Update>("setForm", var1);
                }

                public Drive.Files.Update SetPrettyPrint(Boolean var1)
                {
                    return CallAsWrapper<Drive.Files.Update>("setPrettyPrint", var1);
                }

                public Drive.Files.Update SetQuotaId(String var1)
                {
                    return CallAsWrapper<Drive.Files.Update>("setQuotaId", var1);
                }
                public String getFileId()
                {

                    return Call<String>("getFileId");
                }

                public Drive.Files.Update SetFileId(String var1)
                {
                    
                    return CallAsWrapper<Drive.Files.Update>("setFileId",var1);
                }

                public String GetAddParentFolder()
                {
                    return Call<String>("getParentFolder");
                }

                public Drive.Files.Update SetAddParentFolder(String var1)
                {

                    return CallAsWrapper<Drive.Files.Update>("setAddParentFolder", var1);
                }

                public String GetRemoveParentFolder()
                {
                    return Call<String>("getRemoveParentFolder");
                }

                public Drive.Files.Update SetRemoveParentFolder(String var1)
                {
                    
                    return CallAsWrapper<Drive.Files.Update>("SetRemoveParentFolder", var1);

                }

                public Drive.Files.Update Set(String var1, AndroidJavaObject var2)
                {
                    // return (Drive.Files.Update)super.set(var1, var2);
                    return CallAsWrapper<Drive.Files.Update>("set", var1, var2);
                }
            }

            public class List : DriveRequest<FileList>
            {
                

                [UnityEngine.Scripting.Preserve]
                public List(AndroidJavaObject javaObject) : base(javaObject) { }

                public FileList Execute()
                {
                    return CallAsWrapper<FileList>("execute");
                }
                public Drive.Files.List SetFields(String var1)
                {
                    return CallAsWrapper<Drive.Files.List>("setFields", var1);
                }

                public Drive.Files.List SetForm(String var1)
                {
                    return CallAsWrapper<Drive.Files.List>("setForm", var1);
                }

                public Drive.Files.List SetPrettyPrint(Boolean var1)
                {
                    return CallAsWrapper<Drive.Files.List>("setPrettyPrint", var1);
                }

                public Drive.Files.List SetQuotaId(String var1)
                {
                    return CallAsWrapper<Drive.Files.List>("setQuotaId", var1);
                }

                public String GetOrderBy()
                {
                    return Call<String>("getOrderBy");
                }

                public Drive.Files.List SetOrderBy(String var1)
                {
                    return CallAsWrapper<Drive.Files.List>("setOrderBy", var1);
                }

                public int GetPageSize()
                {
                    return Call<int>("getPageSize");
                }

                public Drive.Files.List SetPageSize(int var1)
                {
                    return CallAsWrapper<Drive.Files.List>("setPageSize", var1);
                }

                public String GetCursor()
                {
                    return Call<String>("getCursor");
                }

                public Drive.Files.List SetCursor(String var1)
                {
                    return CallAsWrapper<Drive.Files.List>("setCursor", var1);
                }

                public String GetQueryParam()
                {
                    return Call<String>("getQueryParam");
                }

                public Drive.Files.List SetQueryParam(String var1)
                {
                    return CallAsWrapper<Drive.Files.List>("setQueryParam", var1);
                }

                public String GetContainers()
                {
                    return Call<String>("getContainers");
                }

                public Drive.Files.List SetContainers(String var1)
                {
                    return CallAsWrapper<Drive.Files.List>("setContainers", var1);
                }

                public Drive.Files.List Set(String var1, AndroidJavaObject var2)
                {
                    return CallAsWrapper<Drive.Files.List>("set", var1, var2);
                }
            }

            public class Get : /*JavaObjectWrapper*/DriveRequest<File>
            {
                [UnityEngine.Scripting.Preserve]
                public Get(AndroidJavaObject javaObject) : base(javaObject) { }
                              
                public File Execute()
                {
                    return CallAsWrapper<File>("execute");
                }
                public void ExecuteContentAndDownloadTo(AndroidJavaObject var1) 
                {
                    Call("executeContentAndDownloadTo", var1);
                }

                public AndroidJavaObject ExecuteContentAsInputStream()
                {
                    return Call<AndroidJavaObject>("executeContentAsInputStream");
                }

                public AndroidJavaObject ExecuteContent()
                {

                    return Call<AndroidJavaObject>("executeContent");
                }

                public Drive.Files.Get SetFields(String var1)
                {
                    return CallAsWrapper<Drive.Files.Get>("setFields", var1);
                }

                public Drive.Files.Get SetForm(String var1)
                {
                    return CallAsWrapper<Drive.Files.Get>("setForm", var1);
                }

                public Drive.Files.Get SetPrettyPrint(Boolean var1)
                {
                    return CallAsWrapper<Drive.Files.Get>("setPrettyPrint", var1);
                }

                public Drive.Files.Get SetQuotaId(String var1)
                {
                    return CallAsWrapper<Drive.Files.Get>("setQuotaId", var1);

                }

                public String GetFileId()
                {
                    return Call<String>("getFileId");
                }

                public Drive.Files.Get SetFileId(String var1)
                {
                    return CallAsWrapper<Drive.Files.Get>("setFileId", var1);
                }

                public bool GetAcknowledgeDownloadRisk()
                {
                    return Call<bool>("getAcknowledgeDownloadRisk");
                }

                //TODO: Data?
                public bool IsAcknowledgeDownloadRisk()
                {
                    return Call<bool>("IsAcknowledgeDownloadRisk");
                }

                public Drive.Files.Get SetAcknowledgeDownloadRisk(Boolean var1)
                {
                    return CallAsWrapper<Drive.Files.Get>("setAcknowledgeDownloadRisk", var1);

                }

                public Drive.Files.Get Set(String var1, AndroidJavaObject var2)
                {
                    return CallAsWrapper<Drive.Files.Get>("set", var1, var2);

                }
            }
            public class EmptyRecycle : DriveRequest<Utils.Void>
            {

                [UnityEngine.Scripting.Preserve]
                public EmptyRecycle(AndroidJavaObject javaObject) : base(javaObject) { }
                // protected EmptyRecycle(Drive var1, String var2, String var3, File var4, Type var5) : base(var1, var2, var3, var4, var5) { }


                /*public String GetContainers()
                {
                    return this.containers;
                }

                public Drive.Files.EmptyRecycle SetContainers(String var1)
                {
                    this.containers = var1;
                    return this;
                }*/

                public Drive.Files.EmptyRecycle SetForm(String var1)
                {
                    return CallAsWrapper<Drive.Files.EmptyRecycle>("setForm", var1);
                }

                public Drive.Files.EmptyRecycle SetFields(String var1)
                {
                    return CallAsWrapper<Drive.Files.EmptyRecycle>("setFields", var1);

                }

                public Drive.Files.EmptyRecycle SetPrettyPrint(Boolean var1)
                {
                    return CallAsWrapper<Drive.Files.EmptyRecycle>("setPrettyPrint", var1);
                }

                public Drive.Files.EmptyRecycle SetQuotaId(String var1)
                {
                    return CallAsWrapper<Drive.Files.EmptyRecycle>("setQuotaId", var1);
                }

                public Drive.Files.EmptyRecycle Set(String var1, AndroidJavaObject var2)
                {
                    return CallAsWrapper<Drive.Files.EmptyRecycle>("set", var1, var2);

                }
            }
            public class Delete : DriveRequest<Utils.Void>
            {

                [UnityEngine.Scripting.Preserve]
                public Delete(AndroidJavaObject javaObject) : base(javaObject) { }
                //protected Delete(Drive var1, String var2, String var3, File var4, Type var5) : base(var1, var2, var3, var4, var5) { }


                /*protected Delete(String var2) {
                    super(Drive.this, "DELETE", "files/{fileId}", (Object)null, Void.class);
                    this.fileId = (String)Preconditions.checkNotNull(var2, "Required parameter fileId must be specified.");
                }*/

                public Drive.Files.Delete SetForm(String var1)
                {
                    return CallAsWrapper<Drive.Files.Delete>("setForm", var1);

                }

                public Drive.Files.Delete SetFields(String var1)
                {
                    return CallAsWrapper<Drive.Files.Delete>("setFields", var1);

                }

                public Drive.Files.Delete SetPrettyPrint(Boolean var1)
                {
                    return CallAsWrapper<Drive.Files.Delete>("setPrettyPrint", var1);

                }

                public Drive.Files.Delete SetQuotaId(String var1)
                {
                    return CallAsWrapper<Drive.Files.Delete>("setQuotaId", var1);

                }

                /*public String GetFileId()
                {
                    return this.fileId;
                }

                public Drive.Files.Delete setFileId(String var1)
                {
                    this.fileId = var1;
                    return this;
                }*/

                public Drive.Files.Delete Set(String var1, AndroidJavaObject var2)
                {
                    return CallAsWrapper<Drive.Files.Delete>("set", var1, var2);

                }
            }

            public class Create : DriveRequest<File>
            {
                [UnityEngine.Scripting.Preserve]
                public Create(AndroidJavaObject javaObject) : base(javaObject) { }


                public Drive.Files.Create SetForm(String var1)
                {

                    return CallAsWrapper<Drive.Files.Create>("setForm", var1);

                }

                public File Execute()

                {

                    return CallAsWrapper<File>("execute");

                }


                public Drive.Files.Create SetPrettyPrint(Boolean var1)
                {

                    return CallAsWrapper<Drive.Files.Create>("setPrettyPrint", var1);

                }

                public Drive.Files.Create SetQuotaId(String var1)
                {
                    return CallAsWrapper<Drive.Files.Create>("setQuotaId", var1);
                }

                public Drive.Files.Create SetFields(String var1)
                {
                    return CallAsWrapper<Drive.Files.Create>("setFields", var1);
                }

                public Drive.Files.Create Set(String var1, AndroidJavaObject var2)
                {
                    return CallAsWrapper<Drive.Files.Create>("set", var1, var2);
                }
            }

            public class Copy : DriveRequest<File>
            {
                [UnityEngine.Scripting.Preserve]
                public Copy(AndroidJavaObject javaObject) : base(javaObject) { }
                ///protected Copy(Drive var1, String var2, String var3, File var4, Type var5) : base(var1, var2, var3, var4, var5) { }


                //  protected Copy(string var2, FileInfo var3) : base(this, "POST", "files/{fileId}/copy", var3, File.) { }

                /*  protected Copy(string var2, FileInfo var3) 
                  {
                      base(this, "POST", "files/{fileId}/copy", var3, FileInfo.class);
                      this.fileId = (String)Preconditions.checkNotNull(var2, "Required parameter fileId must be specified.");
                  }
                */
                public Drive.Files.Copy SetForm(String var1)
                {
                    return CallAsWrapper<Drive.Files.Copy>("setForm", var1);
                }

                public Drive.Files.Copy SetFields(String var1)
                {
                    return CallAsWrapper<Drive.Files.Copy>("setFields", var1);
                }

                public Drive.Files.Copy SetPrettyPrint(Boolean var1)
                {
                    return CallAsWrapper<Drive.Files.Copy>("setPrettyPrint", var1);
                }

                public Drive.Files.Copy SetQuotaId(String var1)
                {
                    return CallAsWrapper<Drive.Files.Copy>("setQuotaId", var1);
                }

               /* public String getFileId()
                {
                    return this.fileId;
                }

                //TODO: fileId?
                public Drive.Files.Copy setFileId(String var1)
                {
                    //   this.fileId = var1;
                    return this;
                }*/

                public Drive.Files.Copy Set(String var1, AndroidJavaObject var2)
                {
                    return CallAsWrapper<Drive.Files.Copy>("set", var1, var2);
                }

            }

        }


        public class Channels
        {

        }


        public class Comments
        {

        }

        public class Replies
        {

        }

        public class HistoryVersions
        {

        }

        public class DriveScopes
        {
            public static readonly String SCOPE_DRIVE = "https://www.huawei.com/auth/drive";
            public static readonly String SCOPE_DRIVE_FILE = "https://www.huawei.com/auth/drive.file";
            public static readonly String SCOPE_DRIVE_READONLY = "https://www.huawei.com/auth/drive.readonly";
            public static readonly String SCOPE_DRIVE_METADATA = "https://www.huawei.com/auth/drive.metadata";
            public static readonly String SCOPE_DRIVE_METADATA_READONLY = "https://www.huawei.com/auth/drive.metadata.readonly";
            public static readonly String SCOPE_DRIVE_APPDATA = "https://www.huawei.com/auth/drive.appdata";

            private DriveScopes()
            {
            }

            public static HashSet<String> all()
            {
                HashSet<String> var0 = new HashSet<String>();
                var0.Add("https://www.huawei.com/auth/drive");
                var0.Add("https://www.huawei.com/auth/drive.file");
                var0.Add("https://www.huawei.com/auth/drive.metadata");
                var0.Add("https://www.huawei.com/auth/drive.metadata.readonly");
                var0.Add("https://www.huawei.com/auth/drive.readonly");
                var0.Add("https://www.huawei.com/auth/drive.appdata");
                return var0;
                //Collections.unmodifiableSet(var0);
            }
        }
    }
}
