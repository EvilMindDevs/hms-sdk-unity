using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class HistoryVersionList : JavaObjectWrapper
    {
        public HistoryVersionList(AndroidJavaObject javaObject) : base(javaObject) { }
        public HistoryVersionList() : base("com.huawei.cloud.services.drive.model.HistoryVersionList") { }

        public string GetCategory() => Call<string>("getCategory");
        public HistoryVersion SetCategory(string var1) => CallAsWrapper<HistoryVersion>("setCategory", var1);

        public HistoryVersion Set(string var1, AndroidJavaObject var2) => CallAsWrapper<HistoryVersion>("set", var1, var2);
        public HistoryVersion Clone() => CallAsWrapper<HistoryVersion>("clone");

        public string GetNextCursor() => Call<string>("getNextCursor");

        public HistoryVersionList SetNextCursor(string nextCursor) => CallAsWrapper<HistoryVersionList>("setNextCursor", nextCursor);

        public IList<HistoryVersion> GetHistoryVersion() => Call<AndroidJavaObject>("getHistoryVersion").AsListFromWrappable<HistoryVersion>();

        public IList<HistoryVersion> SetHistoryVersion(IList<HistoryVersion> historyVersions) => CallAsWrapperList<HistoryVersion>("setHistoryVersion", historyVersions);
    }
}
