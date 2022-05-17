using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class ChangeList : JavaObjectWrapper
    {
        public ChangeList(AndroidJavaObject javaObject) : base(javaObject) { }
        public ChangeList() : base("com.huawei.cloud.services.drive.model.ChangeList") { }

        public string GetCategory() => Call<string>("getCategory");
        public ChangeList SetCategory(string var1) => CallAsWrapper<ChangeList>("setCategory", var1);

        public string GetNextCursor() => Call<string>("getNextCursor");
        public ChangeList SetNextCursor(string var1) => CallAsWrapper<ChangeList>("setNextCursor", var1);

        public IList<Change> GetChanges() => Call<AndroidJavaObject>("getChanges").AsListFromWrappable<Change>();
        public ChangeList SetChanges(IList<Change> var1) => CallAsWrapper<ChangeList>("setChanges", var1);

        public string GetNewStartCursor() => Call<string>("getNewStartCursor");
        public ChangeList SetNewStartCursor(string var1) => CallAsWrapper<ChangeList>("setNewStartCursor", var1);

        public ChangeList Set(string var1, AndroidJavaObject var2) => CallAsWrapper<ChangeList>("set", var1, var2);
        public ChangeList Clone() => CallAsWrapper<ChangeList>("clone");
    }
}
