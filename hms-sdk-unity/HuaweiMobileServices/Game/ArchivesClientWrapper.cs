using System.Collections.Generic;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Base;
    using HuaweiMobileServices.Utils;
    using System;
    using UnityEngine;

    internal class ArchivesClientWrapper : JavaObjectWrapper, IArchivesClient
    {

        [UnityEngine.Scripting.Preserve]
        public ArchivesClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.GenericBridge");

        public ITask<int> LimitThumbnailSize => CallAsWrapper<TaskPrimitive<int>>("getLimitThumbnailSize");

        public ITask<int> LimitDetailsSize => CallAsWrapper<TaskPrimitive<int>>("getLimitDetailsSize");

        public ITask<ArchiveSummary> AddArchive(ArchiveDetails paramArchiveDetails, ArchiveSummaryUpdate paramArchiveSummaryUpdate, bool paramBoolean) =>
            CallAsWrapper<TaskJavaObjectWrapper<ArchiveSummary>>("addArchive", paramArchiveDetails, paramArchiveSummaryUpdate, paramBoolean);

        public ITask<IList<ArchiveSummary>> GetArchiveSummaryList(bool paramBoolean)
        {
            var task = Call<AndroidJavaObject>("getArchiveSummaryList", paramBoolean);
            return new TaskWrapper<IList<ArchiveSummary>>(task, AndroidJavaObjectExtensions.AsListFromWrappable<ArchiveSummary>);
        }

        public void ShowArchiveListIntent(String title, Boolean allowAddBtn, Boolean allowDeleteBtn, int maxArchive) {
            ITask<AndroidIntent> task = CallAsWrapper<TaskJavaObjectWrapper<AndroidIntent>>("getShowArchiveListIntent", title, allowAddBtn, allowDeleteBtn, maxArchive);
            task.AddOnSuccessListener((result) =>
            {
                var callback = new GenericBridgeCallbackWrapper();
                sJavaClass.CallStatic("receiveShow", result.Intent, callback);
            }).AddOnFailureListener((onFailure) =>
            {
                Debug.Log("[HMS] Show Archive List Intent Fail: " + onFailure.WrappedExceptionMessage);
            });               
        }
           

        public ITask<AndroidBitmap> GetThumbnail(string paramString) =>
            CallAsWrapper<TaskJavaObjectWrapper<AndroidBitmap>>("getThumbnail", paramString);

        public ITask<OperationResult> LoadArchiveDetails(ArchiveSummary paramArchiveSummary) =>
            CallAsWrapper<TaskJavaObjectWrapper<OperationResult>>("loadArchiveDetails", paramArchiveSummary);

        public ITask<OperationResult> LoadArchiveDetails(ArchiveSummary paramArchiveSummary, int paramInt) =>
            CallAsWrapper<TaskJavaObjectWrapper<OperationResult>>("loadArchiveDetails", paramArchiveSummary, paramInt);

        public ITask<OperationResult> LoadArchiveDetails(string paramString, int paramInt) =>
            CallAsWrapper<TaskJavaObjectWrapper<OperationResult>>("loadArchiveDetails", paramString, paramInt);

        public ITask<OperationResult> LoadArchiveDetails(string paramString) =>
            CallAsWrapper<TaskJavaObjectWrapper<OperationResult>>("loadArchiveDetails", paramString);

        public ITask<ArchiveSummary> ParseSummary(AndroidBundle paramBundle) =>
            CallAsWrapper<TaskJavaObjectWrapper<ArchiveSummary>>("parseSummary", paramBundle);

        public ITask<string> RemoveArchive(ArchiveSummary paramArchiveSummary) => CallAsWrapper<TaskStringWrapper>("removeArchive", paramArchiveSummary);

        public ITask<OperationResult> UpdateArchive(string paramString, ArchiveSummaryUpdate paramArchiveSummaryUpdate, ArchiveDetails paramArchiveDetails) =>
            CallAsWrapper<TaskJavaObjectWrapper<OperationResult>>("updateArchive", paramString, paramArchiveSummaryUpdate, paramArchiveDetails);

        public ITask<OperationResult> UpdateArchive(Archive paramArchive) =>
            CallAsWrapper<TaskJavaObjectWrapper<OperationResult>>("updateArchive", paramArchive);
    }
}
