using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class ReplyList : JavaObjectWrapper
    {
        public ReplyList(AndroidJavaObject javaObject) : base(javaObject) { }
        public ReplyList() : base("com.huawei.cloud.services.drive.model.ReplyList") { }

        public string GetCategory() => Call<string>("getCategory");
        public ReplyList SetCategory(string var1) => CallAsWrapper<ReplyList>("setCategory", var1);

        public string GetNextCursor() => Call<string>("getNextCursor");
        public ReplyList SetNextCursor(string var1) => CallAsWrapper<ReplyList>("setNextCursor", var1);

        public IList<Reply> GetReplies() => Call<AndroidJavaObject>("getReplies").AsListFromWrappable<Reply>();
        public ReplyList SetReplies(IList<Reply> var1) => CallAsWrapper<ReplyList>("setReplies", var1);

        public ReplyList Set(string var1, AndroidJavaObject var2) => CallAsWrapper<ReplyList>("set", var1, var2);
        public ReplyList Clone() => CallAsWrapper<ReplyList>("clone");
    }
}
