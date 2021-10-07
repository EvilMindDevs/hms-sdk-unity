using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class File : JavaObjectWrapper
    {
        
        public File(AndroidJavaObject javaObject) : base(javaObject) { }
        public File() : base("com.huawei.cloud.services.drive.model.File") { }

        public string GetCategory() => Call<string>("getCategory");
        public File SetCategory(string var1) => CallAsWrapper<File>("setCategory", var1);

        public string GetId() => Call<string>("getId");
        public File SetId(string var1) => CallAsWrapper<File>("setId", var1);

        public string GetFileName() => Call<string>("getFileName");
        public File SetFileName(string var1) => CallAsWrapper<File>("setFileName", var1);

        public long GetSize() => Call<long>("getSize");
        public File SetSize(long var1) => CallAsWrapper<File>("setSize", var1);

        public string GetMimeType() => Call<string>("getMimeType");
        public File SetMimeType(string var1) => CallAsWrapper<File>("setMimeType", var1);

        public IList<string> GetParentFolder() => Call<AndroidJavaObject>("getParentFolder").AsStringList();
        public File SetParentFolder(AndroidJavaObject var1) => CallAsWrapper<File>("setParentFolder", var1);

        public string GetDescription() => Call<string>("getDescription");
        public File SetDescription(string var1) => CallAsWrapper<File>("setDescription", var1);

        public bool SetFavorite() => Call<bool>("getFavorite");
        public File SetFavorite(bool var1) => CallAsWrapper<File>("setFavorite", var1);

        public bool GetRecycled() => Call<bool>("getRecycled");
        public File SetRecycled(bool var1) => CallAsWrapper<File>("setRecycled", var1);

        public Dictionary<string, string> GetAppSettings() => Call<Dictionary<string, string>>("getAppSettings");
        public File SetAppSettings(Dictionary<string, string> var1) => CallAsWrapper<File>("setAppSettings", var1);

        public Dictionary<string, string> GetProperties() => Call<Dictionary<string, string>>("getProperties");
        public File SetProperties(Dictionary<string, string> var1) => CallAsWrapper<File>("setProperties", var1);

        public bool GetWriterHasCopyPermission() => Call<bool>("getWriterHasCopyPermission");
        public File SetWriterHasCopyPermission(bool var1) => CallAsWrapper<File>("WriterHasCopyPermission", var1);

        public bool GetDirectlyRecycled() => Call<bool>("getDirectlyRecycled");
        public File SetDirectlyRecycled(bool var1) => CallAsWrapper<File>("setDirectlyRecylcled", var1);

        public string GetFileSuffix() => Call<string>("getFileSuffix");
        public File SetFileSuffix(string var1) => CallAsWrapper<File>("setFileSuffix", var1);

        public string GetFullFileSuffix() => Call<string>("getFullFileSuffix");
        public File SetFullFileSuffix(string var1) => CallAsWrapper<File>("setFullFileSuffix", var1);

        public bool GetExistThumbnail() => Call<bool>("getExistThumbnail");
        public File SetExistThumbnail(bool var1) => CallAsWrapper<File>("setExistThumbnail", var1);

        public string GetIconDownloadLink() => Call<string>("getIconDownloadLink");
        public File SetIconDownloadLink(string var1) => CallAsWrapper<File>("setIconDownloadLink", var1);

        public bool GetIsAppAuthorized() => Call<bool>("getIsAppAuthorized");
        public File SetIsAppAuthorized(bool var1) => CallAsWrapper<File>("setIsAppAuthorized", var1);

        public User GetLastEditor() => CallAsWrapper<User>("getLasEditor");
        public File SetLastEditor(User var1) => CallAsWrapper<File>("setLastEditor", var1);

        public bool GetEditedByMe() => Call<bool>("getEditedByMe");
        public File SetEditedByMe(bool var1) => CallAsWrapper<File>("setEditedByMe", var1);

        public bool GetOwnedByMe() => Call<bool>("getOwnedByMe");
        public File SetOwnedByMe(bool var1) => CallAsWrapper<File>("setOwnedByMe", var1);

        public long GetOccupiedSpace() => Call<long>("getOccupiedSpace");
        public File SetOccupiedSpace(long var1) => CallAsWrapper<File>("setOccupiedSpace", var1);

        public string GetSha256() => Call<string>("getSha256");
        public File SetSha256(string var1) => CallAsWrapper<File>("setSha256", var1);

        public bool GetHasShared() => Call<bool>("getHasShared");
        public File SetHasShared(bool var1) => CallAsWrapper<File>("setHasShared", var1);

        public User GetSharer() => CallAsWrapper<User>("getSharer");
        public File SetSharer(User var1) => CallAsWrapper<File>("setSharer", var1);

        public string GetThumbnailDownloadLink() => Call<string>("getThumbnailDownloadLink");
        public File SetThumbnailDownloadLink(string var1) => CallAsWrapper<File>("setThumbnailDownloadLink", var1);

        public string GetSmallThumbnailDownloadLink() => Call<string>("getSmallThumbnailDownloadLink");
        public File SetSmallThumbnailDownloadLink(string var1) => CallAsWrapper<File>("setSmallThumbnailDownloadLink", var1);

        public User GetRecyclingUser() => CallAsWrapper<User>("getRecyclingUser");
        public File SetRecyclingUser(User var1) => CallAsWrapper<File>("setRecyclingUser", var1);

        public string GetContentDownloadLink() => Call<string>("getContentDownloadLink");
        public File SetContentDownloadLink(string var1) => CallAsWrapper<File>("setContentDownloadLink", var1);

        public bool GetWritersHasSharePermission() => Call<bool>("getWritersHasSharePermission");
        public File SetWritersHasSharePermission(bool var1) => CallAsWrapper<File>("setWritersHasSharePermission", var1);

        public string GetContentVersion() => Call<string>("getContentVersion");
        public File SetContentVersion(string var1) => CallAsWrapper<File>("setContentVersion", var1);

        public string GetLastHistoryVersionId() => Call<string>("getLastHistoryVersionId");
        public File SetLastHistoryVersionId(string var1) => CallAsWrapper<File>("setLastHistoryVersionId", var1);

        public string GetOriginalFilename() => Call<string>("getOriginalFilename");
        public File SetOriginalFilename(string var1) => CallAsWrapper<File>("setOriginalFilename", var1);

        public long GetThumbnailVersion() => Call<long>("getThumbnailVersion");
        public File SetThumbnailVersion(long var1) => CallAsWrapper<File>("setThumbnailVersion", var1);

        public long GetVersion() => Call<long>("getVersion");
        public File SetVersion(long var1) => CallAsWrapper<File>("setVersion", var1);

        public string GetOnLineViewLink() => Call<string>("getOnLineViewLink");
        public File SetOnLineViewLink(string var1) => CallAsWrapper<File>("setOnLineViewLink", var1);

        public class Capabilities : JavaObjectWrapper
        {
            public Capabilities(AndroidJavaObject javaObject) : base(javaObject){}
            public Capabilities() : base("com.huawei.cloud.services.drive.model.File$Capabilities") { }
        }

        public class ContentExtras : JavaObjectWrapper
        {
            public ContentExtras(AndroidJavaObject javaObject) : base(javaObject) { }            
            public ContentExtras() : base("com.huawei.cloud.services.drive.model.File$ContentExtras") { }

            public File.ContentExtras SetThumbnail(File.ContentExtras.Thumbnail var1) => CallAsWrapper<File.ContentExtras>("setThumbnail", var1);

            public class Thumbnail : JavaObjectWrapper
            {
                public Thumbnail(AndroidJavaObject javaObject) : base(javaObject){}
                public Thumbnail() : base("com.huawei.cloud.services.drive.model.File.ContentExtras$Thumbnail") { }

                public File.ContentExtras.Thumbnail SetThumbnailPublic(Boolean var1) => CallAsWrapper<File.ContentExtras.Thumbnail>("setThumbnailPublic", var1);
                public File.ContentExtras.Thumbnail SetContent(String var1) => CallAsWrapper<File.ContentExtras.Thumbnail>("setContent", var1);
                public File.ContentExtras.Thumbnail SetMimeType(String var1) => CallAsWrapper<File.ContentExtras.Thumbnail>("setMimeType", var1);
            }
        }
    }
}
