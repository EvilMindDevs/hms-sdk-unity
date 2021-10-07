using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class CommentList : JavaObjectWrapper
    {
        public CommentList(AndroidJavaObject javaObject) : base(javaObject) { }
        public CommentList() : base("com.huawei.cloud.services.drive.model.CommentList") { }

        public string GetCategory() => Call<string>("getCategory");
        public CommentList SetCategory(string var1) => CallAsWrapper<CommentList>("setCategory", var1);

        public string GetNextCursor() => Call<string>("getNextCursor");
        public CommentList SetNextCursor(string var1) => CallAsWrapper<CommentList>("setNextCursor", var1);

        public IList<Comment> GetComments() => Call<AndroidJavaObject>("getComments").AsListFromWrappable<Comment>();
        public CommentList SetComments(IList<Comment> var1) => CallAsWrapper<CommentList>("setComments", var1);

        public Comment Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Comment>("set", var1, var2);
        public Comment Clone() => CallAsWrapper<Comment>("clone");
    }
}
