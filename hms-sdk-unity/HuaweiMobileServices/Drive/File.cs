using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class File : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public File(AndroidJavaObject javaObject) : base(javaObject) { }

        [UnityEngine.Scripting.Preserve]
        public File() : base("com.huawei.cloud.services.drive.model.File")
        {
        }


        public Boolean GetDirectlyRecycled()
        {
            return Call<Boolean>("getDirectlyRecycled");
        }

        public File SetDirectlyRecycled(Boolean var1)
        {
            return CallAsWrapper<File>("setDirectlyRecylcled");
        }

        public String GetFileSuffix()
        {
            return Call<String>("getFileSuffix");
        }

        public File SetFileSuffix(String var1)
        {
            return CallAsWrapper<File>("setFileSuffix", var1);
        }

        public String GetFullFileSuffix()
        {
            return Call<String>("getFullFileSuffix");
        }

        public File SetFullFileSuffix(String var1)
        {
            return CallAsWrapper<File>("setFullFileSuffix", var1);
        }

        public Boolean GetIsAppAuthorized()
        {
            return Call<Boolean>("getIsAppAuthorized");
        }

        public File SetIsAppAuthorized(Boolean var1)
        {
            return CallAsWrapper<File>("setIsAppAuthorized", var1);
        }

        public String GetCategory()
        {
            return Call<String>("getCategory");
        }

        public File SetCategory(String var1)
        {
            return CallAsWrapper<File>("setCategory", var1);
        }

       public File.ContentExtras GetContentExtras()
        {
            return CallAsWrapper<File.ContentExtras>("getContentExtras");
        }

        public File SetContentExtras(File.ContentExtras var1)
        {
            return CallAsWrapper<File>("setContentExtras");

        }


        public String GetId()
        {
            return Call<String>("getId");
        }

        public File SetId(String var1)
        {
            return CallAsWrapper<File>("setId");
        }

        public String GetFileName()
        {
            return Call<String>("getFileName");
        }

        public File SetFileName(String var1)
        {
            return CallAsWrapper<File>("setFileName",var1);
        }

        public AndroidJavaObject GetSize() => Call<AndroidJavaObject>("getSize");

        public File SetSize(long var1)
        {
            return CallAsWrapper<File>("setSize");

        }

        public String GetMimeType()
        {
            return Call<String>("getMimeType");
        }

        public File SetMimeType(String var1)
        {
            return CallAsWrapper<File>("setMimeType",var1);

        }

        public IList<string> GetParentFolder()
        {
            return Call<AndroidJavaObject>("getParentFolder").AsStringList();

        }

    public File SetParentFolder(AndroidJavaObject var1)
        {
            return CallAsWrapper<File>("setParentFolder", var1);

        }

       /* public DateTime GetCreatedTime()
        {
            return this.createdTime;
        }

        public File SetCreatedTime(DateTime var1)
        {
            this.createdTime = var1;
            return this;
        }

        public DateTime GetEditedTime()
        {
            return this.editedTime;
        }

        public File SetEditedTime(DateTime var1)
        {
            this.editedTime = var1;
            return this;
        }

        public String GetDescription()
        {
            return this.description;
        }

        public File SetDescription(String var1)
        {
            this.description = var1;
            return this;
        }

        public List<User> GetOwners()
        {
            return this.owners;
        }

        public File SetOwners(List<User> var1)
        {
            this.owners = var1;
            return this;
        }

        public Boolean GetFavorite()
        {
            return this.favorite;
        }

        public File SetFavorite(Boolean var1)
        {
            this.favorite = var1;
            return this;
        }

        public Boolean GetRecycled()
        {
            return this.recycled;
        }

        public File SetRecycled(Boolean var1)
        {
            this.recycled = var1;
            return this;
        }*/

        public Dictionary<String, String> GetAppSettings()
        {
            return Call<Dictionary<String,String>>("getAppSettings");
        }

        public File SetAppSettings(Dictionary<String, String> var1)
        {
            return CallAsWrapper<File>("setAppSettings", var1);

        }

        /*public Map<String, String> GetProperties()
        {
            return this.properties;
        }

        public File SetProperties(Map<String, String> var1)
        {
            this.properties = var1;
            return this;
        }

        public String GetLastHistoryVersionId()
        {
            return this.lastHistoryVersionId;
        }

        public File SetLastHistoryVersionId(String var1)
        {
            this.lastHistoryVersionId = var1;
            return this;
        }*/

        public String GetOriginalFilename()
        {
            return Call<String>("getOriginalFilename");
        }

        public File SetOriginalFilename(String var1)
        {
            return CallAsWrapper<File>("setOriginalFilename", var1);

        }

        public long GetThumbnailVersion()
        {
            return Call<long>("getThumbnailVersion");
        }

        public File SetThumbnailVersion(long var1)
        {
            return CallAsWrapper<File>("setThumbnailVersion", var1);

        }

        public long GetVersion()
        {
            return Call<long>("getVersion");
        }

        public File SetVersion(long var1)
        {
            return CallAsWrapper<File>("setVersion", var1);

        }

        public String GetContentVersion()
        {
            return Call<String>("getContentVersion");
        }

        public File SetContentVersion(String var1)
        {
            return CallAsWrapper<File>("setContentVersion", var1);

        }

        public String GetOnLineViewLink()
        {
            return Call<String>("getOnLineViewLink");
        }

        public File SetOnLineViewLink(String var1)
        {
            return CallAsWrapper<File>("setOnLineViewLink", var1);

        }

        public File Set(String var1, AndroidJavaObject var2) => CallAsWrapper<File>("set", var1, var2);

        public File Clone() => CallAsWrapper<File>("clone");

        /*public File.Capabilities getCapabilities()
        {
            return this.capabilities;
        }

        public File setCapabilities(File.Capabilities var1)
        {
            this.capabilities = var1;
            return this;
        }*/

        /*public File.PictureMetadata getPictureMetadata()
        {
            return this.pictureMetadata;
        }*/

        /*public File setPictureMetadata(File.PictureMetadata var1)
        {
            this.pictureMetadata = var1;
            return this;
        }*/

        /*public File.VideoMetadata getVideoMetadata()
        {
            return this.videoMetadata;
        }*/

        /*public File setVideoMetadata(File.VideoMetadata var1)
        {
            this.videoMetadata = var1;
            return this;
        }*/

        public Boolean GetExistThumbnail()
        {
            return Call<Boolean>("getExistThumbnail");
        }

        public File SetExistThumbnail(Boolean var1)
        {
            return CallAsWrapper<File>("setExistThumbnail");

        }

        /*public String getIconDownloadLink()
        {
            return this.iconDownloadLink;
        }

        public File setIconDownloadLink(String var1)
        {
            this.iconDownloadLink = var1;
            return this;
        }

        public String getSha256()
        {
            return this.sha256;
        }

        public File setSha256(String var1)
        {
            this.sha256 = var1;
            return this;
        }

        /*public Long getOccupiedSpace()
        {
            return this.occupiedSpace;
        }*/

        /*public File setOccupiedSpace(Long var1)
        {
            this.occupiedSpace = var1;
            return this;
        }*/

        /*public List<String> getContainers()
        {
            return this.containers;
        }

        public File setContainers(List<String> var1)
        {
            this.containers = var1;
            return this;
        }*/

        public String GetThumbnailDownloadLink()
        {
            return Call<String>("getThumbnailDownloadLink");
        }

        public String GetSmallThumbnailDownloadLink()
        {
            return Call<String>("getSmallThumbnailDownloadLink");
        }

        public File SetThumbnailDownloadLink(String var1)
        {
            return CallAsWrapper<File>("setThumbnailDownloadLink",var1);
        }

        public File SetSmallThumbnailDownloadLink(String var1)
        {
            return CallAsWrapper<File>("setSmallThumbnailDownloadLink", var1);

        }

        /*public DateTime getRecycledTime()
        {
            return this.recycledTime;
        }

        public File setRecycledTime(DateTime var1)
        {
            this.recycledTime = var1;
            return this;
        }

        public String getContentDownloadLink()
        {
            return this.contentDownloadLink;
        }

        public File setContentDownloadLink(String var1)
        {
            this.contentDownloadLink = var1;
            return this;
        }

        public String getSignedDownloadLink()
        {
            return this.signedDownloadLink;
        }

        public File setSignedDownloadLink(String var1)
        {
            this.signedDownloadLink = var1;
            return this;
        }

        public Boolean getEditedByMe()
        {
            return this.editedByMe;
        }

        public File setEditedByMe(Boolean var1)
        {
            this.editedByMe = var1;
            return this;
        }

        public DateTime getEditedByMeTime()
        {
            return this.editedByMeTime;
        }

        public File setEditedByMeTime(DateTime var1)
        {
            this.editedByMeTime = var1;
            return this;
        }

        public Boolean getOwnedByMe()
        {
            return this.ownedByMe;
        }

        public File setOwnedByMe(Boolean var1)
        {
            this.ownedByMe = var1;
            return this;
        }

        public List<String> getPermissionIds()
        {
            return this.permissionIds;
        }

        public File setPermissionIds(List<String> var1)
        {
            this.permissionIds = var1;
            return this;
        }*/

        /*public List<Permission> getPermissions()
        {
            return this.permissions;
        }*/

        /*public File setPermissions(List<Permission> var1)
        {
            this.permissions = var1;
            return this;
        }*/

        /*public Boolean getHasShared()
        {
            return this.hasShared;
        }

        public File setHasShared(Boolean var1)
        {
            this.hasShared = var1;
            return this;
        }

        public DateTime getSharedWithMeTime()
        {
            return this.sharedWithMeTime;
        }

        public File setSharedWithMeTime(DateTime var1)
        {
            this.sharedWithMeTime = var1;
            return this;
        }

        public User getSharer()
        {
            return this.sharer;
        }*/

        public File setSharer(User var1)
        {
            return CallAsWrapper<File>("setSharer", var1);

        }

        public User GetRecyclingUser()
        {
            return CallAsWrapper<User>("getRecyclingUser");
        }

        public File SetRecyclingUser(User var1)
        {
            return CallAsWrapper<File>("setRecyclingUser", var1);

        }

        public Boolean GetWritersHasSharePermission()
        {
            return Call<Boolean>("getWritersHasSharePermission");
        }

        public File SetWritersHasSharePermission(Boolean var1)
        {
            return CallAsWrapper<File>("setWritersHasSharePermission", var1);

        }

        public Boolean GetWriterHasCopyPermission()
        {
            return Call<Boolean>("getWriterHasCopyPermission");
        }

        public File SetWriterHasCopyPermission(Boolean var1)
        {
            return CallAsWrapper<File>("WriterHasCopyPermission", var1);

        }

        public User GetLastEditor()
        {
            return CallAsWrapper<User>("getLasEditor");
        }

        public File SetLastEditor(User var1)
        {
            return CallAsWrapper<File>("setLastEditor", var1);

        }
        public class Capabilities : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Capabilities(AndroidJavaObject javaObject) : base(javaObject)
            {
            }

            [UnityEngine.Scripting.Preserve]
            public Capabilities() : base("com.huawei.cloud.services.drive.model.File$Capabilities")
            {
            }
            //public Boolean getAddChildNodePermission()
            // {
            //     return this.addChildNodePermission;
            // }

            // public File.Capabilities setAddChildNodePermission(Boolean var1)
            // {
            //     this.addChildNodePermission = var1;
            //     return this;
            // }

            // public Boolean getWriterHasCopyPermission()
            // {
            //     return this.writerHasCopyPermission;
            // }

            // public File.Capabilities setWriterHasCopyPermission(Boolean var1)
            // {
            //     this.writerHasCopyPermission = var1;
            //     return this;
            // }

            // public Boolean getCommentPermission()
            // {
            //     return this.commentPermission;
            // }

            // public File.Capabilities setCommentPermission(Boolean var1)
            // {
            //     this.commentPermission = var1;
            //     return this;
            // }

            // public Boolean getCopyPermission()
            // {
            //     return this.copyPermission;
            // }

            // public File.Capabilities setCopyPermission(Boolean var1)
            // {
            //     this.copyPermission = var1;
            //     return this;
            // }

            // public Boolean getDeletePermission()
            // {
            //     return this.deletePermission;
            // }

            // public File.Capabilities setDeletePermission(Boolean var1)
            // {
            //     this.deletePermission = var1;
            //     return this;
            // }

            // public Boolean getDeleteChildNodePermission()
            // {
            //     return this.deleteChildNodePermission;
            // }

            // public File.Capabilities setDeleteChildNodePermission(Boolean var1)
            // {
            //     this.deleteChildNodePermission = var1;
            //     return this;
            // }

            // public Boolean getDownloadPermission()
            // {
            //     return this.downloadPermission;
            // }

            // public File.Capabilities setDownloadPermission(Boolean var1)
            // {
            //     this.downloadPermission = var1;
            //     return this;
            // }

            // public Boolean getEditPermission()
            // {
            //     return this.editPermission;
            // }

            // public File.Capabilities setEditPermission(Boolean var1)
            // {
            //     this.editPermission = var1;
            //     return this;
            // }

            // public Boolean getRenameFilePermission()
            // {
            //     return this.renameFilePermission;
            // }

            // public File.Capabilities setRenameFilePermission(Boolean var1)
            // {
            //     this.renameFilePermission = var1;
            //     return this;
            // }

            // public Boolean getShareFilePermission()
            // {
            //     return this.shareFilePermission;
            // }

            // public File.Capabilities setShareFilePermission(Boolean var1)
            // {
            //     this.shareFilePermission = var1;
            //     return this;
            // }

            // public Boolean getRecyclePermission()
            // {
            //     return this.recyclePermission;
            // }

            // public File.Capabilities setRecyclePermission(Boolean var1)
            // {
            //     this.recyclePermission = var1;
            //     return this;
            // }

            // public Boolean getRecycleChildNodePermission()
            // {
            //     return this.recycleChildNodePermission;
            // }

            // public File.Capabilities setRecycleChildNodePermission(Boolean var1)
            // {
            //     this.recycleChildNodePermission = var1;
            //     return this;
            // }

            // public Boolean getUnrecyclePermission()
            // {
            //     return this.unrecyclePermission;
            // }

            // public File.Capabilities setUnrecyclePermission(Boolean var1)
            // {
            //     this.unrecyclePermission = var1;
            //     return this;
            // }

            // public Boolean getListChildNodePermission()
            // {
            //     return this.listChildNodePermission;
            // }

            // public File.Capabilities setListChildNodePermission(Boolean var1)
            // {
            //     this.listChildNodePermission = var1;
            //     return this;
            // }

            // public Boolean getReadHistoryVersionPermission()
            // {
            //     return this.readHistoryVersionPermission;
            // }

            // public File.Capabilities setReadHistoryVersionPermission(Boolean var1)
            // {
            //     this.readHistoryVersionPermission = var1;
            //     return this;
            // }

            // public Boolean getRemoveChildNodePermission()
            // {
            //     return this.removeChildNodePermission;
            // }

            // public File.Capabilities setRemoveChildNodePermission(Boolean var1)
            // {
            //     this.removeChildNodePermission = var1;
            //     return this;
            // }

            // public Boolean getEditContentPermission()
            // {
            //     return this.editContentPermission;
            // }

            // public File.Capabilities setEditContentPermission(Boolean var1)
            // {
            //     this.editContentPermission = var1;
            //     return this;
            // }

            // public File.Capabilities set(String var1, Object var2)
            // {
            //     return (File.Capabilities)super.set(var1, var2);
            // }

            // public File.Capabilities clone()
            // {
            //     return (File.Capabilities)super.clone();
            // }
        }

        public class ContentExtras : JavaObjectWrapper
        {

            [UnityEngine.Scripting.Preserve]
            public ContentExtras(AndroidJavaObject javaObject) : base(javaObject)
            {
            }

            [UnityEngine.Scripting.Preserve]
            public ContentExtras() : base("com.huawei.cloud.services.drive.model.File$ContentExtras")
            {
            }

            public File.ContentExtras SetThumbnail(File.ContentExtras.Thumbnail var1)
            {
                return CallAsWrapper<File.ContentExtras>("setThumbnail", var1);

            }

            public class Thumbnail : JavaObjectWrapper
            {
            [UnityEngine.Scripting.Preserve]

            public Thumbnail(AndroidJavaObject javaObject): base(javaObject)
            {
            }
            [UnityEngine.Scripting.Preserve]
            public Thumbnail() : base("com.huawei.cloud.services.drive.model.File.ContentExtras$Thumbnail")
            {
            }
            public File.ContentExtras.Thumbnail SetThumbnailPublic(Boolean var1)
            {
                return CallAsWrapper<File.ContentExtras.Thumbnail>("setThumbnailPublic", var1);
            }

            public File.ContentExtras.Thumbnail SetContent(String var1) {

                return CallAsWrapper<File.ContentExtras.Thumbnail>("setContent", var1);

            }
            public File.ContentExtras.Thumbnail SetMimeType(String var1) {
                
                return CallAsWrapper<File.ContentExtras.Thumbnail>("setMimeType", var1);

            }

                //public Boolean getThumbnailPublic()
                //{
                //    return this.thumbnailPublic;
                //}



                //public String getContent()
                //{
                //    return this.content;
                //}

                //public File.ContentExtras.Thumbnail setContent(String var1)
                //{
                //    this.content = var1;
                //    return this;
                //}

                //public byte[] decodeContent()
                //{
                //    return Base64.decodeBase64(this.content);
                //}

                //public File.ContentExtras.Thumbnail encodeContent(byte[] var1)
                //{
                //    this.content = Base64.encodeBase64URLSafeString(var1);
                //    return this;
                //}

                //public String getMimeType()
                //{
                //    return this.mimeType;
                //}

                //public File.ContentExtras.Thumbnail setMimeType(String var1)
                //{
                //    this.mimeType = var1;
                //    return this;
                //}

                //public File.ContentExtras.Thumbnail set(String var1, Object var2)
                //{
                //    return (File.ContentExtras.Thumbnail)super.set(var1, var2);
                //}

                //public File.ContentExtras.Thumbnail clone()
                //{
                //    return (File.ContentExtras.Thumbnail)super.clone();
                //}
            }

        }

}
}
