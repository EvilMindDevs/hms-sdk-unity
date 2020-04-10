using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Game
{
    using UnityEngine;
    using HuaweiMobileServices.Utils;
    using HuaweiMobileServices.Base;

    // TODO Implement
    internal class ArchivesClientWrapper : JavaObjectWrapper, IArchivesClient
    {
        public ArchivesClientWrapper(AndroidJavaObject javaObject) : base(javaObject) { }

        public ITask<int> LimitThumbnailSize => throw new NotImplementedException();

        public ITask<int> LimitDetailsSize => throw new NotImplementedException();

        public ITask<ArchiveSummary> AddArchive(ArchiveDetails paramArchiveDetails, ArchiveSummaryUpdate paramArchiveSummaryUpdate, bool paramBoolean)
        {
            throw new NotImplementedException();
        }

        public ITask<IList<ArchiveSummary>> GetArchiveSummaryList(bool paramBoolean)
        {
            throw new NotImplementedException();
        }

        public ITask<AndroidIntent> GetShowArchiveListIntent(string paramString, bool paramBoolean1, bool paramBoolean2, int paramInt)
        {
            throw new NotImplementedException();
        }

        public ITask<AndroidBitmap> GetThumbnail(string paramString)
        {
            throw new NotImplementedException();
        }

        public ITask<OperationResult> LoadArchiveDetails(ArchiveSummary paramArchiveSummary)
        {
            throw new NotImplementedException();
        }

        public ITask<OperationResult> LoadArchiveDetails(ArchiveSummary paramArchiveSummary, int paramInt)
        {
            throw new NotImplementedException();
        }

        public ITask<OperationResult> LoadArchiveDetails(string paramString, int paramInt)
        {
            throw new NotImplementedException();
        }

        public ITask<OperationResult> LoadArchiveDetails(string paramString)
        {
            throw new NotImplementedException();
        }

        public ITask<ArchiveSummary> ParseSummary(AndroidBundle paramBundle)
        {
            throw new NotImplementedException();
        }

        public ITask<string> RemoveArchive(ArchiveSummary paramArchiveSummary)
        {
            throw new NotImplementedException();
        }

        public ITask<OperationResult> UpdateArchive(string paramString, ArchiveSummaryUpdate paramArchiveSummaryUpdate, ArchiveDetails paramArchiveDetails)
        {
            throw new NotImplementedException();
        }

        public ITask<OperationResult> UpdateArchive(Archive paramArchive)
        {
            throw new NotImplementedException();
        }
    }
}
