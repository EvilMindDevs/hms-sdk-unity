using System.IO;

namespace HuaweiMobileServices.Drive
{
    using HuaweiMobileServices.Utils;
    using System;
    using System.Collections.Generic;
    using UnityEngine;


    public class Drive : JavaObjectWrapper
    {
        
        public Drive(AndroidJavaObject javaObject) : base(javaObject) { }

        public About about() => CallAsWrapper<About>("about");
        public Changes changes() => CallAsWrapper<Changes>("changes");
        public Channels channels() => CallAsWrapper<Channels>("channels");
        public Comments comments() => CallAsWrapper<Comments>("comments");
        public Files files() => CallAsWrapper<Files>("files");
        public HistoryVersions historyVersions() => CallAsWrapper<HistoryVersions>("historyVersions");
        public Replies replies() => CallAsWrapper<Replies>("replies");

        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }
            public Builder(DriveCredential credential) : base("com.huawei.cloud.services.drive.Drive$Builder", credential, AndroidContext.ActivityContext){}

            public Drive Build() => CallAsWrapper<Drive>("build");
        }

        public class Files : JavaObjectWrapper
        {
            public Files(AndroidJavaObject javaObject) : base(javaObject) { }
            public Copy copy(string var1, File var2) => CallAsWrapper<Copy>("copy", var1, var2);
            public Create create(File var1) => CallAsWrapper<Create>("create", var1);
            public Create create(File var1, FileContent var2) => CallAsWrapper<Create>("create", var1, var2);
            public Create create(File var1, InputStreamContent var2) => CallAsWrapper<Create>("create", var1, var2);
            public Delete delete(string var1) => CallAsWrapper<Delete>("delete", var1);
            public EmptyRecycle emptyRecycle() => CallAsWrapper<EmptyRecycle>("emptyRecycle");
            public Get get(string var1) => CallAsWrapper<Get>("get", var1);
            public List list() => CallAsWrapper<List>("list");
            public Update update(string var1, File var2) => CallAsWrapper<Update>("update", var1, var2);
            public Update update(string var1, File var2, AndroidJavaObject var3) => CallAsWrapper<Update>("update", var1, var2, var3);
            public Subscribe subscribe(string var1, Channel var2) => CallAsWrapper<Subscribe>("update", var1, var2);

            public class Subscribe : DriveRequest<Channel>
            {
                public Subscribe(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Subscribe SetForm(string var1) => CallAsWrapper<Subscribe>("setForm", var1);
                public new Subscribe SetFields(string var1) => CallAsWrapper<Subscribe>("setFields", var1);
                public new Subscribe SetPrettyPrint(bool var1) => CallAsWrapper<Subscribe>("setPrettyPrint", var1);
                public new Subscribe SetQuotaId(string var1) => CallAsWrapper<Subscribe>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public Subscribe SetFileId(string var1) => CallAsWrapper<Subscribe>("setFileId", var1);
                public new Subscribe Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Subscribe>("set", var1, var2);
                public new Channel Execute() => CallAsWrapper<Channel>("execute");
            }
            public class Update : DriveRequest<File>
            {                
                public Update(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Update SetFields(string var1) => CallAsWrapper<Update>("setFields", var1);
                public new Update SetForm(string var1) => CallAsWrapper<Update>("setForm", var1);
                public new Update SetPrettyPrint(bool var1) => CallAsWrapper<Update>("setPrettyPrint", var1);
                public new Update SetQuotaId(string var1) => CallAsWrapper<Update>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public Update SetFileId(string var1) => CallAsWrapper<Update>("setFileId", var1);
                public string GetAddParentFolder() => Call<string>("getParentFolder");
                public Update SetAddParentFolder(string var1) => CallAsWrapper<Update>("setAddParentFolder", var1);
                public string GetRemoveParentFolder() => Call<string>("getRemoveParentFolder");
                public Update SetRemoveParentFolder(string var1) => CallAsWrapper<Update>("SetRemoveParentFolder", var1);
                public new Update Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Update>("set", var1, var2);
                public new File Execute() => CallAsWrapper<File>("execute");
            }
            public class List : DriveRequest<FileList>
            {
                public List(AndroidJavaObject javaObject) : base(javaObject) { }
                public new FileList Execute() => CallAsWrapper<FileList>("execute");
                public new List SetFields(string var1) => CallAsWrapper<List>("setFields", var1);
                public new List SetForm(string var1) => CallAsWrapper<List>("setForm", var1);
                public new List SetPrettyPrint(bool var1) => CallAsWrapper<List>("setPrettyPrint", var1);
                public new List SetQuotaId(string var1) => CallAsWrapper<List>("setQuotaId", var1);
                public string GetOrderBy() => Call<string>("getOrderBy");
                public List SetOrderBy(string var1) => CallAsWrapper<List>("setOrderBy", var1);
                public int GetPageSize() => Call<int>("getPageSize");
                public List SetPageSize(int var1) => CallAsWrapper<List>("setPageSize", var1);
                public string GetCursor() => Call<string>("getCursor");
                public List SetCursor(string var1) => CallAsWrapper<List>("setCursor", var1);
                public string GetQueryParam() => Call<string>("getQueryParam");
                public List SetQueryParam(string var1) => CallAsWrapper<List>("setQueryParam", var1);
                public string GetContainers() => Call<string>("getContainers");
                public List SetContainers(string var1) => CallAsWrapper<List>("setContainers", var1);
                public new List Set(string var1, AndroidJavaObject var2) => CallAsWrapper<List>("set", var1, var2);
            }
            public class Get : DriveRequest<File>
            {
                public Get(AndroidJavaObject javaObject) : base(javaObject) { }
                public new File Execute() => CallAsWrapper<File>("execute");
                public void ExecuteContentAndDownloadTo(AndroidJavaObject var1) => Call("executeContentAndDownloadTo", var1);
                public AndroidJavaObject ExecuteContentAsInputStream() => Call<AndroidJavaObject>("executeContentAsInputStream");
                public AndroidJavaObject ExecuteContent() => Call<AndroidJavaObject>("executeContent");
                public new Get SetFields(string var1) => CallAsWrapper<Get>("setFields", var1);
                public new Get SetForm(string var1) => CallAsWrapper<Get>("setForm", var1);
                public new Get SetPrettyPrint(bool var1) => CallAsWrapper<Get>("setPrettyPrint", var1);
                public new Get SetQuotaId(string var1) => CallAsWrapper<Get>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public Get SetFileId(string var1) => CallAsWrapper<Get>("setFileId", var1);
                public bool GetAcknowledgeDownloadRisk() => Call<bool>("getAcknowledgeDownloadRisk");
                public bool IsAcknowledgeDownloadRisk() => Call<bool>("IsAcknowledgeDownloadRisk");
                public Get SetAcknowledgeDownloadRisk(bool var1) => CallAsWrapper<Get>("setAcknowledgeDownloadRisk", var1);
                public new Get Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Get>("set", var1, var2);
            }
            public class EmptyRecycle : DriveRequest<Utils.Void>
            {
                public EmptyRecycle(AndroidJavaObject javaObject) : base(javaObject) { }
                public new EmptyRecycle SetForm(string var1) => CallAsWrapper<EmptyRecycle>("setForm", var1);
                public new EmptyRecycle SetFields(string var1) => CallAsWrapper<EmptyRecycle>("setFields", var1);
                public new EmptyRecycle SetPrettyPrint(bool var1) => CallAsWrapper<EmptyRecycle>("setPrettyPrint", var1);
                public new EmptyRecycle SetQuotaId(string var1) => CallAsWrapper<EmptyRecycle>("setQuotaId", var1);
                public new EmptyRecycle Set(string var1, AndroidJavaObject var2) => CallAsWrapper<EmptyRecycle>("set", var1, var2);
                public new void Execute() => Call("Execute");
            }
            public class Delete : DriveRequest<Utils.Void>
            {
                public Delete(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Delete SetForm(string var1) => CallAsWrapper<Delete>("setForm", var1);
                public new Delete SetFields(string var1) => CallAsWrapper<Delete>("setFields", var1);
                public new Delete SetPrettyPrint(bool var1) => CallAsWrapper<Delete>("setPrettyPrint", var1);
                public new Delete SetQuotaId(string var1) => CallAsWrapper<Delete>("setQuotaId", var1);
                public new Delete Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Delete>("set", var1, var2);
                public new void Execute() => Call("Execute");
            }
            public class Create : DriveRequest<File>
            {
                public Create(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Create SetForm(string var1) => CallAsWrapper<Create>("setForm", var1);
                public new File Execute() => CallAsWrapper<File>("execute");
                public new Create SetPrettyPrint(bool var1) => CallAsWrapper<Create>("setPrettyPrint", var1);
                public new Create SetQuotaId(string var1) => CallAsWrapper<Create>("setQuotaId", var1);
                public new Create SetFields(string var1) => CallAsWrapper<Create>("setFields", var1);
                public new Create Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Create>("set", var1, var2);
            }
            public class Copy : DriveRequest<File>
            {
                public Copy(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Copy SetForm(string var1) => CallAsWrapper<Copy>("setForm", var1);
                public new Copy SetFields(string var1) => CallAsWrapper<Copy>("setFields", var1);
                public new Copy SetPrettyPrint(bool var1) => CallAsWrapper<Copy>("setPrettyPrint", var1);
                public new Copy SetQuotaId(string var1) => CallAsWrapper<Copy>("setQuotaId", var1);
                public new Copy Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Copy>("set", var1, var2);
                public new File Execute() => CallAsWrapper<File>("execute");
            }
        }

        public class Channels : JavaObjectWrapper
        {
            public Channels(AndroidJavaObject javaObject) : base(javaObject) { }

            public Stop stop(Channel var1) => CallAsWrapper<Stop>("stop", var1);

            public class Stop : DriveRequest<Utils.Void>
            {
                public Stop(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Stop Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Stop>("set", var1, var2);
                public new Stop SetForm(string var1) => CallAsWrapper<Stop>("setForm", var1);
                public new Stop SetFields(string var1) => CallAsWrapper<Stop>("setFields", var1);
                public new Stop SetPrettyPrint(bool var1) => CallAsWrapper<Stop>("setPrettyPrint", var1);
                public new Stop SetQuotaId(string var1) => CallAsWrapper<Stop>("setQuotaId", var1);
                public new void Execute() => Call("Execute");
            }
        }

        public class Replies : JavaObjectWrapper
        {
            public Replies(AndroidJavaObject javaObject) : base(javaObject) { }

            public Create create(string var1, string var2, Reply var3) => CallAsWrapper<Create>("create", var1, var2, var3);
            public Delete delete(string var1, string var2, string var3) => CallAsWrapper<Delete>("delete", var1, var2, var3);
            public Get get(string var1, string var2, string var3) => CallAsWrapper<Get>("get", var1, var2, var3);
            public List list(string var1, string var2) => CallAsWrapper<List>("list", var1, var2);
            public Update update(string var1, string var2, string var3, Reply var4) => CallAsWrapper<Update>("update", var1, var2, var3, var4);

            public class Create : DriveRequest<Reply>
            {
                public Create(AndroidJavaObject javaObject) : base(javaObject) { }

                public new Reply Execute() => CallAsWrapper<Reply>("execute");
                public new Create SetForm(string var1) => CallAsWrapper<Create>("setForm", var1);
                public new Create SetFields(string var1) => CallAsWrapper<Create>("setFields", var1);
                public new Create SetPrettyPrint(bool var1) => CallAsWrapper<Create>("setPrettyPrint", var1);
                public new Create SetQuotaId(string var1) => CallAsWrapper<Create>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public Create SetFileId(string var1) => CallAsWrapper<Create>("setFileId", var1);
                public string GetCommentId() => Call<string>("getCommentId");
                public Create SetCommentId(string var1) => CallAsWrapper<Create>("setCommentId", var1);
                public new Create Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Create>("set", var1, var2);
            }
            public class Delete : DriveRequest<Utils.Void>
            {
                public Delete(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Delete SetForm(string var1) => CallAsWrapper<Delete>("setForm", var1);
                public new Delete SetFields(string var1) => CallAsWrapper<Delete>("setFields", var1);
                public Delete SetFileId(string var1) => CallAsWrapper<Delete>("setFileId", var1);
                public Delete GetFileId() => CallAsWrapper<Delete>("getFileId");
                public Delete SetCommentId(string var1) => CallAsWrapper<Delete>("setCommentId", var1);
                public Delete GetCommentId() => CallAsWrapper<Delete>("getCommentId");
                public Delete SetReplyId(string var1) => CallAsWrapper<Delete>("setReplyId", var1);
                public Delete GetReplyId() => CallAsWrapper<Delete>("getReplyId");
                public new Delete SetPrettyPrint(bool var1) => CallAsWrapper<Delete>("setPrettyPrint", var1);
                public new Delete SetQuotaId(string var1) => CallAsWrapper<Delete>("setQuotaId", var1);
                public new Delete Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Delete>("set", var1, var2);
                public new void Execute() => Call("execute");
            }
            public class Get : DriveRequest<Reply>
            {
                public Get(AndroidJavaObject javaObject) : base(javaObject) { }
                public string GetCommentId() => Call<string>("getCommentId");
                public Get SetCommentId(string var1) => CallAsWrapper<Get>("setCommentId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public Get SetFileId(string var1) => CallAsWrapper<Get>("setFileId", var1);
                public bool IsIncludeDeleted() => Call<bool>("isIncludeDeleted");
                public Get SetIncludeDeleted(bool var1) => CallAsWrapper<Get>("isIncludeDeleted", var1);
                public new Get Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Get>("set", var1, var2);
                public new Get SetForm(string var1) => CallAsWrapper<Get>("setForm", var1);
                public new Get SetFields(string var1) => CallAsWrapper<Get>("setFields", var1);
                public new Get SetPrettyPrint(bool var1) => CallAsWrapper<Get>("setPrettyPrint", var1);
                public new Get SetQuotaId(string var1) => CallAsWrapper<Get>("setQuotaId", var1);
                public new Reply Execute() => CallAsWrapper<Reply>("execute");
            }
            public class List : DriveRequest<ReplyList>
            {
                public List(AndroidJavaObject javaObject) : base(javaObject) { }

                public new List SetForm(string var1) => CallAsWrapper<List>("setForm", var1);
                public new List SetFields(string var1) => CallAsWrapper<List>("setFields", var1);
                public new List SetPrettyPrint(bool var1) => CallAsWrapper<List>("setPrettyPrint", var1);
                public new List SetQuotaId(string var1) => CallAsWrapper<List>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public List SetFileId(string var1) => CallAsWrapper<List>("setFileId", var1);
                public string GetCommentId() => Call<string>("getCommentId");
                public List SetCommentId(int var1) => CallAsWrapper<List>("setCommentId", var1);
                public bool GetIncludeDeleted() => Call<bool>("getIncludeDeleted");
                public bool IsIncludeDeleted() => Call<bool>("isIncludeDeleted");
                public List SetIncludeDeleted(bool var1) => CallAsWrapper<List>("setIncludeDeleted", var1);
                public int GetPageSize() => Call<int>("getPageSize");
                public List SetPageSize(int var1) => CallAsWrapper<List>("setPageSize", var1);
                public string GetCursor() => Call<string>("getCursor");
                public List SetCursor(string var1) => CallAsWrapper<List>("setCursor", var1);
                public new ReplyList Execute() => CallAsWrapper<ReplyList>("execute");
                public new List Set(string var1, AndroidJavaObject var2) => CallAsWrapper<List>("set", var1, var2);
            }
            public class Update : DriveRequest<Reply>
            {
                public Update(AndroidJavaObject javaObject) : base(javaObject) { }

                public string GetFileId() => Call<string>("getFileId");
                public Update SetFileId(string var1) => CallAsWrapper<Update>("setFileId", var1);
                public string GetReplyId() => Call<string>("getReplyId");
                public Update SetReplyId(string var1) => CallAsWrapper<Update>("setReplyId", var1);
                public new Update SetForm(string var1) => CallAsWrapper<Update>("setForm", var1);
                public new Update SetFields(string var1) => CallAsWrapper<Update>("setFields", var1);
                public new Update SetPrettyPrint(bool var1) => CallAsWrapper<Update>("setPrettyPrint", var1);
                public new Update SetQuotaId(string var1) => CallAsWrapper<Update>("setQuotaId", var1);
                public new Update Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Update>("set", var1, var2);
                public new Reply Execute() => CallAsWrapper<Reply>("execute");
            }
        }

        public class Comments : JavaObjectWrapper
        {
            public Comments(AndroidJavaObject javaObject) : base(javaObject) { }

            public Create create(string var1, Comment var2) => CallAsWrapper<Create>("create", var1, var2);
            public Delete delete(string var1, string var2) => CallAsWrapper<Delete>("delete", var1, var2);
            public Get get(string var1, string var2) => CallAsWrapper<Get>("get", var1, var2);
            public List list(string var1) => CallAsWrapper<List>("list", var1);
            public Update update(string var1, string var2, HuaweiMobileServices.Drive.Comment var3) => CallAsWrapper<Update>("update", var1, var2, var3);

            public class Create : DriveRequest<Comment>
            {
                public Create(AndroidJavaObject javaObject) : base(javaObject) { }

                public new Comment Execute() => CallAsWrapper<Comment>("execute");
                public new Create SetForm(string var1) => CallAsWrapper<Create>("setForm", var1);
                public new Create SetFields(string var1) => CallAsWrapper<Create>("setFields", var1);
                public new Create SetPrettyPrint(bool var1) => CallAsWrapper<Create>("setPrettyPrint", var1);
                public new Create SetQuotaId(string var1) => CallAsWrapper<Create>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public Create SetFileId(string var1) => CallAsWrapper<Create>("setFileId", var1);
                public new Create Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Create>("set", var1, var2);
            }
            public class Delete : DriveRequest<Utils.Void>
            {
                public Delete(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Delete SetForm(string var1) => CallAsWrapper<Delete>("setForm", var1);
                public new Delete SetFields(string var1) => CallAsWrapper<Delete>("setFields", var1);
                public Delete SetFileId(string var1) => CallAsWrapper<Delete>("setFileId", var1);
                public Delete GetFileId() => CallAsWrapper<Delete>("getFileId");
                public Delete SetCommentId(string var1) => CallAsWrapper<Delete>("setCommentId", var1);
                public Delete GetCommentId() => CallAsWrapper<Delete>("getCommentId");
                public new Delete SetPrettyPrint(bool var1) => CallAsWrapper<Delete>("setPrettyPrint", var1);
                public new Delete SetQuotaId(string var1) => CallAsWrapper<Delete>("setQuotaId", var1);
                public new Delete Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Delete>("set", var1, var2);
                public new void Execute() => Call("execute");
            }
            public class Get : DriveRequest<Comment>
            {
                public Get(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Comment Execute() => CallAsWrapper<Comment>("execute");
                public new Get SetForm(string var1) => CallAsWrapper<Get>("setForm", var1);
                public new Get SetPrettyPrint(bool var1) => CallAsWrapper<Get>("setPrettyPrint", var1);
                public new Get SetQuotaId(string var1) => CallAsWrapper<Get>("setQuotaId", var1);
                public new Get Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Get>("set", var1, var2);
                public string GetFileId() => Call<string>("getFileId");
                public Get SetFileId(string var1) => CallAsWrapper<Get>("setFileId", var1);
                public string GetCommentId() => Call<string>("getCommentId");
                public Get SetCommentId(string var1) => CallAsWrapper<Get>("setCommentId", var1);
                public bool GetIncludeDeleted() => Call<bool>("getIncludeDeleted");
                public bool IsIncludeDeleted() => Call<bool>("isIncludeDeleted");
                public Get SetIncludeDeleted(bool var1) => CallAsWrapper<Get>("isIncludeDeleted", var1);
            }
            public class List : DriveRequest<CommentList>
            {
                public List(AndroidJavaObject javaObject) : base(javaObject) { }
                public new CommentList Execute() => CallAsWrapper<CommentList>("execute");
                public new List SetFields(string var1) => CallAsWrapper<List>("setFields", var1);
                public new List SetForm(string var1) => CallAsWrapper<List>("setForm", var1);
                public new List SetPrettyPrint(bool var1) => CallAsWrapper<List>("setPrettyPrint", var1);
                public new List SetQuotaId(string var1) => CallAsWrapper<List>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public List SetFileId(string var1) => CallAsWrapper<List>("setFileId", var1);
                public int GetPageSize() => Call<int>("getPageSize");
                public List SetPageSize(int var1) => CallAsWrapper<List>("setPageSize", var1);
                public string GetCursor() => Call<string>("getCursor");
                public List SetCursor(string var1) => CallAsWrapper<List>("setCursor", var1);
                public bool GetIncludeDeleted() => Call<bool>("getIncludeDeleted");
                public bool IsIncludeDeleted() => Call<bool>("isIncludeDeleted");
                public List SetIncludeDeleted(bool var1) => CallAsWrapper<List>("setIncludeDeleted", var1);
                public string GetStartEditedTime() => Call<string>("getStartEditedTime");
                public List SetStartEditedTime(string var1) => CallAsWrapper<List>("setStartEditedTime", var1);
                public new List Set(string var1, AndroidJavaObject var2) => CallAsWrapper<List>("set", var1, var2);
            }
            public class Update : DriveRequest<Comment>
            {
                public Update(AndroidJavaObject javaObject) : base(javaObject) { }

                public new Update SetFields(string var1) => CallAsWrapper<Update>("setFields", var1);
                public new Update SetForm(string var1) => CallAsWrapper<Update>("setForm", var1);
                public new Update SetPrettyPrint(bool var1) => CallAsWrapper<Update>("setPrettyPrint", var1);
                public new Update SetQuotaId(string var1) => CallAsWrapper<Update>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public Update SetFileId(string var1) => CallAsWrapper<Update>("setFileId", var1);
                public string GetCommentId() => Call<string>("getCommentId");
                public Update SetCommentId(string var1) => CallAsWrapper<Update>("setCommentId", var1);
                public new Update Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Update>("set", var1, var2);
                public new Comment Execute() => CallAsWrapper<Comment>("execute");
            }
        }

        public class HistoryVersions : JavaObjectWrapper
        {
            public HistoryVersions(AndroidJavaObject javaObject) : base(javaObject) { }

            public Delete delete(string var1, string var2) => CallAsWrapper<Delete>("delete", var1, var2);
            public Get get(string var1, string var2) => CallAsWrapper<Get>("get", var1, var2);
            public List list(string var1) => CallAsWrapper<List>("list", var1);
            public Update update(string var1, string var2, HistoryVersion var3) => CallAsWrapper<Update>("update", var1, var2, var3);

            public class Delete : DriveRequest<Utils.Void>
            {
                public Delete(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Delete Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Delete>("set", var1, var2);
                public new Delete SetForm(string var1) => CallAsWrapper<Delete>("setForm", var1);
                public new Delete SetFields(string var1) => CallAsWrapper<Delete>("setFields", var1);
                public new Delete SetPrettyPrint(bool var1) => CallAsWrapper<Delete>("setPrettyPrint", var1);
                public new Delete SetQuotaId(string var1) => CallAsWrapper<Delete>("setQuotaId", var1);
                public Delete SetFileId(string var1) => CallAsWrapper<Delete>("setFileId", var1);
                public Delete GetFileId() => CallAsWrapper<Delete>("getFileId");
                public Delete GetHistoryVersionId() => CallAsWrapper<Delete>("getHistoryVersionId");
                public Delete SetHistoryVersionId(string var1) => CallAsWrapper<Delete>("setHistoryVersionId", var1);
                public new void Execute() => Call("execute");
            }
            public class Get : DriveRequest<HistoryVersion>
            {
                public Get(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Get SetQuotaId(string var1) => CallAsWrapper<Get>("setQuotaId", var1);
                public new Get SetPrettyPrint(bool var1) => CallAsWrapper<Get>("setPrettyPrint", var1);
                public new Get SetFields(string var1) => CallAsWrapper<Get>("setFields", var1);
                public new Get SetForm(string var1) => CallAsWrapper<Get>("setForm", var1);
                public new Get Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Get>("set", var1, var2);
                public string GetHistoryVersionId() => Call<string>("getHistoryVersionId");
                public Get SetHistoryVersionId(string var1) => CallAsWrapper<Get>("setHistoryVersionId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public Get SetFileId(string var1) => CallAsWrapper<Get>("setFileId", var1);
                public Get SetAcknowledgeDownloadRisk(bool var1) => CallAsWrapper<Get>("setAcknowledgeDownloadRisk", var1);
                public bool IsAcknowledgeDownloadRisk() => Call<bool>("isAcknowledgeDownloadRisk");
                public bool GetAcknowledgeDownloadRisk() => Call<bool>("getAcknowledgeDownloadRisk");
                public AndroidJavaObject ExecuteContentAsInputStream() => Call<AndroidJavaObject>("executeContentAsInputStream");
                public void ExecuteContentAndDownloadTo(AndroidJavaObject var1) => Call("executeContentAndDownloadTo", var1);
                public AndroidJavaObject ExecuteContent() => Call<AndroidJavaObject>("executeContent");
                public new HistoryVersion Execute() => CallAsWrapper<HistoryVersion>("execute");
            }
            public class List : DriveRequest<HistoryVersionList>
            {
                public List(AndroidJavaObject javaObject) : base(javaObject) { }

                public new List SetForm(string var1) => CallAsWrapper<List>("setForm", var1);

                public new List SetFields(string var1) => CallAsWrapper<List>("setFields", var1);
                public new List SetPrettyPrint(bool var1) => CallAsWrapper<List>("setPrettyPrint", var1);
                public new List SetQuotaId(string var1) => CallAsWrapper<List>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public List SetFileId(string var1) => CallAsWrapper<List>("setFileId", var1);
                public int GetPageSize() => Call<int>("getPageSize");
                public List SetPageSize(int var1) => CallAsWrapper<List>("setPageSize", var1);
                public string GetCursor() => Call<string>("getCursor");
                public List SetCursor(string var1) => CallAsWrapper<List>("setCursor", var1);
                public new HistoryVersionList Execute() => CallAsWrapper<HistoryVersionList>("execute");
                public new List Set(string var1, AndroidJavaObject var2) => CallAsWrapper<List>("set", var1, var2);
            }
            public class Update : DriveRequest<HistoryVersion>
            {
                public Update(AndroidJavaObject javaObject) : base(javaObject) { }

                public new Update SetForm(string var1) => CallAsWrapper<Update>("setForm", var1);
                public new Update SetFields(string var1) => CallAsWrapper<Update>("setFields", var1);
                public new Update SetPrettyPrint(bool var1) => CallAsWrapper<Update>("setPrettyPrint", var1);
                public new Update SetQuotaId(string var1) => CallAsWrapper<Update>("setQuotaId", var1);
                public string GetFileId() => Call<string>("getFileId");
                public Update SetFileId(string var1) => CallAsWrapper<Update>("setFileId", var1);
                public string GetHistoryVersionId() => Call<string>("getHistoryVersionId");
                public Update SetHistoryVersionId(string var1) => CallAsWrapper<Update>("setHistoryVersionId", var1);
                public new Update Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Update>("set", var1, var2);
                public new HistoryVersion Execute() => CallAsWrapper<HistoryVersion>("execute");
            }
        }

        public class Changes : JavaObjectWrapper
        {
            public Changes(AndroidJavaObject javaObject) : base(javaObject) { }

            public GetStartCursor getStartCursor() => CallAsWrapper<GetStartCursor>("getStartCursor");
            public List list(string var1) => CallAsWrapper<List>("list", var1);
            public Subscribe subscribe(string var1, Channel var2) => CallAsWrapper<Subscribe>("subscribe", var1, var2);

            public class GetStartCursor : DriveRequest<StartCursor>
            {
                public GetStartCursor(AndroidJavaObject javaObject) : base(javaObject) { }

                public new StartCursor Set(string var1, AndroidJavaObject var2) => CallAsWrapper<StartCursor>("set", var1, var2);
                public new StartCursor SetForm(string var1) => CallAsWrapper<StartCursor>("setForm", var1);
                public new StartCursor SetFields(string var1) => CallAsWrapper<StartCursor>("setFields", var1);
                public new StartCursor SetPrettyPrint(bool var1) => CallAsWrapper<StartCursor>("setPrettyPrint", var1);
                public new StartCursor SetQuotaId(string var1) => CallAsWrapper<StartCursor>("setQuotaId", var1);
                public new StartCursor Execute() => CallAsWrapper<StartCursor>("execute");
            }
            public class Subscribe : DriveRequest<Channel>
            {
                public Subscribe(AndroidJavaObject javaObject) : base(javaObject) { }

                public new Subscribe Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Subscribe>("set", var1, var2);
                public new Subscribe SetForm(string var1) => CallAsWrapper<Subscribe>("setForm", var1);
                public new Subscribe SetFields(string var1) => CallAsWrapper<Subscribe>("setFields", var1);
                public new Subscribe SetPrettyPrint(bool var1) => CallAsWrapper<Subscribe>("setPrettyPrint", var1);
                public new Subscribe SetQuotaId(string var1) => CallAsWrapper<Subscribe>("setQuotaId", var1);
                public string GetCursor() => Call<string>("getCursor");
                public Subscribe SetCursor(string var1) => CallAsWrapper<Subscribe>("setCursor", var1);
                public int GetPageSize() => Call<int>("getPageSize");
                public Subscribe SetPageSize(int var1) => CallAsWrapper<Subscribe>("setPageSize", var1);
                public string GetContainers() => Call<string>("getContainers");
                public Subscribe SetContainers(string var1) => CallAsWrapper<Subscribe>("setContainers", var1);
                public bool GetIncludeDeleted() => Call<bool>("getIncludeDeleted");
                public bool IsIncludeDeleted() => Call<bool>("isIncludeDeleted");
                public Subscribe SetIncludeDeleted(bool var1) => CallAsWrapper<Subscribe>("setIncludeDeleted", var1);
                public new Channel Execute() => CallAsWrapper<Channel>("execute");
            }
            public class List : DriveRequest<ChangeList>
            {
                public List(AndroidJavaObject javaObject) : base(javaObject) { }

                public new List Set(string var1, AndroidJavaObject var2) => CallAsWrapper<List>("set", var1, var2);
                public new List SetForm(string var1) => CallAsWrapper<List>("setForm", var1);
                public new List SetFields(string var1) => CallAsWrapper<List>("setFields", var1);
                public new List SetPrettyPrint(bool var1) => CallAsWrapper<List>("setPrettyPrint", var1);
                public new List SetQuotaId(string var1) => CallAsWrapper<List>("setQuotaId", var1);
                public string GetCursor() => Call<string>("getCursor");
                public List SetCursor(string var1) => CallAsWrapper<List>("setCursor", var1);
                public int GetPageSize() => Call<int>("getPageSize");
                public List SetPageSize(int var1) => CallAsWrapper<List>("setPageSize", var1);
                public string GetContainers() => Call<string>("getContainers");
                public List SetContainers(string var1) => CallAsWrapper<List>("setContainers", var1);
                public bool GetIncludeDeleted() => Call<bool>("getIncludeDeleted");
                public bool IsIncludeDeleted() => Call<bool>("isIncludeDeleted");
                public List SetIncludeDeleted(bool var1) => CallAsWrapper<List>("setIncludeDeleted", var1);
                public new ChangeList Execute() => CallAsWrapper<ChangeList>("execute");
            }
        }

        public class About : JavaObjectWrapper
        {
            public About(AndroidJavaObject javaObject) : base(javaObject) { }

            public Get get() => CallAsWrapper<Get>("get");

            public class Get : DriveRequest<About>
            {
                public Get(AndroidJavaObject javaObject) : base(javaObject) { }
                public new Get Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Get>("set", var1, var2);
                public new Get SetForm(string var1) => CallAsWrapper<Get>("setForm", var1);
                public new Get SetFields(string var1) => CallAsWrapper<Get>("setFields", var1);
                public new Get SetPrettyPrint(bool var1) => CallAsWrapper<Get>("setPrettyPrint", var1);
                public new Get SetQuotaId(string var1) => CallAsWrapper<Get>("setQuotaId", var1);
                public new HuaweiMobileServices.Drive.About Execute() => CallAsWrapper<HuaweiMobileServices.Drive.About>("execute");
            }
        }

        public class DriveScopes : JavaObjectWrapper
        {
            private const string CLASS_NAME = "com.huawei.cloud.services.drive.DriveScopes";

            private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass(CLASS_NAME);
            public static string SCOPE_DRIVE = sJavaClass.GetStatic<string>("SCOPE_DRIVE");
            public static string SCOPE_DRIVE_FILE = sJavaClass.GetStatic<string>("SCOPE_DRIVE_FILE");
            public static string SCOPE_DRIVE_READONLY = sJavaClass.GetStatic<string>("SCOPE_DRIVE_READONLY");
            public static string SCOPE_DRIVE_METADATA = sJavaClass.GetStatic<string>("SCOPE_DRIVE_METADATA");
            public static string SCOPE_DRIVE_METADATA_READONLY = sJavaClass.GetStatic<string>("SCOPE_DRIVE_METADATA_READONLY");
            public static string SCOPE_DRIVE_APPDATA = sJavaClass.GetStatic<string>("SCOPE_DRIVE_APPDATA");

            public DriveScopes(AndroidJavaObject javaObject) : base(javaObject) { }
            public static HashSet<string> all()
            {
                HashSet<string> var0 = new HashSet<string>();
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
