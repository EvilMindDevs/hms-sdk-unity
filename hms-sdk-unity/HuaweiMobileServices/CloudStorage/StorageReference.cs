using HuaweiMobileServices.Base;
using HuaweiMobileServices.Utils;
using HuaweiMobileServices.Utils.java.io;

using System.Collections.Generic;

using UnityEngine;

namespace HuaweiMobileServices.CloudStorage
{
    public class StorageReference : JavaObjectWrapper
    {
        public StorageReference(AndroidJavaObject javaObject) : base(javaObject) { }

        // private static AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.cloud.storage.core.StorageReference");

        public AGCStorageManagement GetStorage() => CallAsWrapper<AGCStorageManagement>("getStorage");

        public StorageReference Child(string objectPath) => CallAsWrapper<StorageReference>("child", objectPath);

        public StorageReference GetParent() => CallAsWrapper<StorageReference>("getParent");

        public StorageReference GetRoot() => CallAsWrapper<StorageReference>("getRoot");

        public string GetBucket() => CallAsString("getBucket");

        public string GetName() => CallAsString("getName");

        public string GetPath() => CallAsString("getPath");

        public ITask<FileMetadata> GetFileMetadata() => CallAsWrapper<TaskJavaObjectWrapper<FileMetadata>>("getFileMetadata");

        public ITask<FileMetadata> UpdateFileMetadata(FileMetadata attribute) => CallAsWrapper<TaskJavaObjectWrapper<FileMetadata>>("updateFileMetadata", attribute);

        public ITask<Void> Delete() => CallAsWrapper<TaskVoidWrapper>("delete");

        public ITask<ListResult> List(int max, string marker) => CallAsWrapper<TaskJavaObjectWrapper<ListResult>>("list", max, marker);

        public ITask<ListResult> List(int max) => CallAsWrapper<TaskJavaObjectWrapper<ListResult>>("list", max);

        public ITask<ListResult> ListAll() => CallAsWrapper<TaskJavaObjectWrapper<ListResult>>("listAll");

        public UploadTask PutFile(File srcFile, FileMetadata attribute, long offset) => CallAsWrapper<UploadTask>("putFile", srcFile, attribute, offset.AsJavaLong());

        public UploadTask PutFile(File srcFile, FileMetadata attribute) => CallAsWrapper<UploadTask>("putFile", srcFile, attribute);

        public UploadTask PutFile(File srcFile) => CallAsWrapper<UploadTask>("putFile", srcFile);

        public UploadTask PutBytes(byte[] bytes, FileMetadata attribute) => CallAsWrapper<UploadTask>("putBytes", bytes, attribute);

        public UploadTask PutBytes(byte[] bytes, FileMetadata attribute, long offset) => CallAsWrapper<UploadTask>("putBytes", bytes, attribute, offset.AsJavaLong());

        public DownloadTask GetFile(File destFile) => CallAsWrapper<DownloadTask>("getFile", destFile);

        public DownloadTask GetFile(string destUri) => CallAsWrapper<DownloadTask>("getFile", destUri.AsJavaUri());

        public StreamDownloadTask GetStream() => CallAsWrapper<StreamDownloadTask>("getStream");

        public StreamDownloadTask GetStream(StreamDownloadTask.StreamHandler streamHandler) => CallAsWrapper<StreamDownloadTask>("getStream", streamHandler);

        public ITask<byte[]> GetBytes(long maxDownloadBytes) => CallAsWrapper<TaskPrimitive<byte[]>>("getBytes", maxDownloadBytes);

        public ITask<Uri> getDownloadUrl() => CallAsWrapper<TaskJavaObjectWrapper<Uri>>("getDownloadUrl");

        public IList<UploadTask> GetActiveUploadTasks() => CallAsWrapperList<UploadTask>("getActiveUploadTasks");

        public IList<DownloadTask> GetActiveDownloadTasks() => CallAsWrapperList<DownloadTask>("getActiveDownloadTasks");

        public int CompareTo(StorageReference other) => Call<int>("compareTo", other);

        override public string ToString() => CallAsString("toString");

        public bool Equals(Object other) => CallAsBool("equals", other);

        public int HashCode() => Call<int>("hashCode");

    }
}