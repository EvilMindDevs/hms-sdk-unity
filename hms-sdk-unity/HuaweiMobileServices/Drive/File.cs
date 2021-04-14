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

        public Boolean GetDirectlyRecycled() => Call<Boolean>("getDirectlyRecycled");

        public File SetDirectlyRecycled(Boolean var1) => CallAsWrapper<File>("setDirectlyRecylcled", var1);

        public String GetFileSuffix() => Call<String>("getFileSuffix");

        public File SetFileSuffix(String var1) => CallAsWrapper<File>("setFileSuffix", var1);

        public String GetFullFileSuffix() => Call<String>("getFullFileSuffix");

        public File SetFullFileSuffix(String var1) => CallAsWrapper<File>("setFullFileSuffix", var1);

        public Boolean GetIsAppAuthorized() => Call<Boolean>("getIsAppAuthorized");

        public File SetIsAppAuthorized(Boolean var1) => CallAsWrapper<File>("setIsAppAuthorized", var1);

        public String GetCategory() => Call<String>("getCategory");

        public File SetCategory(String var1) => CallAsWrapper<File>("setCategory", var1);

        public File.ContentExtras GetContentExtras() => CallAsWrapper<File.ContentExtras>("getContentExtras");

        public File SetContentExtras(File.ContentExtras var1) => CallAsWrapper<File>("setContentExtras");

        public String GetId() => Call<String>("getId");

        public File SetId(String var1) => CallAsWrapper<File>("setId", var1);

        public String GetFileName() => Call<String>("getFileName");

        public File SetFileName(String var1) => CallAsWrapper<File>("setFileName", var1);

        public AndroidJavaObject GetSize() => Call<AndroidJavaObject>("getSize");

        public File SetSize(long var1) => CallAsWrapper<File>("setSize", var1);

        public String GetMimeType() => Call<String>("getMimeType");

        public File SetMimeType(String var1) => CallAsWrapper<File>("setMimeType", var1);

        public IList<string> GetParentFolder() => Call<AndroidJavaObject>("getParentFolder").AsStringList();

        public File SetParentFolder(AndroidJavaObject var1) => CallAsWrapper<File>("setParentFolder", var1);

        public Dictionary<String, String> GetAppSettings() => Call<Dictionary<String, String>>("getAppSettings");

        public File SetAppSettings(Dictionary<String, String> var1) => CallAsWrapper<File>("setAppSettings", var1);

        public String GetOriginalFilename() => Call<String>("getOriginalFilename");

        public File SetOriginalFilename(String var1) => CallAsWrapper<File>("setOriginalFilename", var1);

        public long GetThumbnailVersion() => Call<long>("getThumbnailVersion");

        public File SetThumbnailVersion(long var1) => CallAsWrapper<File>("setThumbnailVersion", var1);

        public long GetVersion() => Call<long>("getVersion");

        public File SetVersion(long var1) => CallAsWrapper<File>("setVersion", var1);

        public String GetContentVersion() => Call<String>("getContentVersion");

        public File SetContentVersion(String var1) => CallAsWrapper<File>("setContentVersion", var1);

        public String GetOnLineViewLink() => Call<String>("getOnLineViewLink");

        public File SetOnLineViewLink(String var1) => CallAsWrapper<File>("setOnLineViewLink", var1);

        public File Set(String var1, AndroidJavaObject var2) => CallAsWrapper<File>("set", var1, var2);

        public File Clone() => CallAsWrapper<File>("clone");

        public Boolean GetExistThumbnail() => Call<Boolean>("getExistThumbnail");

        public File SetExistThumbnail(Boolean var1) => CallAsWrapper<File>("setExistThumbnail");

        public String GetThumbnailDownloadLink() => Call<String>("getThumbnailDownloadLink");

        public String GetSmallThumbnailDownloadLink() => Call<String>("getSmallThumbnailDownloadLink");

        public File SetThumbnailDownloadLink(String var1) => CallAsWrapper<File>("setThumbnailDownloadLink", var1);

        public File SetSmallThumbnailDownloadLink(String var1) => CallAsWrapper<File>("setSmallThumbnailDownloadLink", var1);

        public File SetSharer(User var1) => CallAsWrapper<File>("setSharer", var1);

        public User GetRecyclingUser() => CallAsWrapper<User>("getRecyclingUser");

        public File SetRecyclingUser(User var1) => CallAsWrapper<File>("setRecyclingUser", var1);

        public Boolean GetWritersHasSharePermission() => Call<Boolean>("getWritersHasSharePermission");

        public File SetWritersHasSharePermission(Boolean var1) => CallAsWrapper<File>("setWritersHasSharePermission", var1);

        public Boolean GetWriterHasCopyPermission() => Call<Boolean>("getWriterHasCopyPermission");

        public File SetWriterHasCopyPermission(Boolean var1) => CallAsWrapper<File>("WriterHasCopyPermission", var1);

        public User GetLastEditor() => CallAsWrapper<User>("getLasEditor");

        public File SetLastEditor(User var1) => CallAsWrapper<File>("setLastEditor", var1);

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
