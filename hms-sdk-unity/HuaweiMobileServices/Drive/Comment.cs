using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class Comment : JavaObjectWrapper
    {
        public Comment(AndroidJavaObject javaObject) : base(javaObject) { }
        public Comment() : base("com.huawei.cloud.services.drive.model.Comment") { }

        public string GetPosition() => Call<string>("getPosition");
        public Comment SetPosition(string var1) => CallAsWrapper<Comment>("setPosition", var1);

        public User GetCreator() => CallAsWrapper<User>("getCreator");
        public Comment SetCreator(User var1) => CallAsWrapper<Comment>("setCreator", var1);

        public string GetDescription() => Call<string>("getDescription");
        public Comment SetDescription(string var1) => CallAsWrapper<Comment>("setDescription", var1);

        public DateTime GetCreatedTime() => CallAsWrapper<DateTime>("getCreatedTime");
        public Comment SetCreatedTime(DateTime var1) => CallAsWrapper<Comment>("setCreatedTime", var1);

        public bool GetDeleted() => CallAsBool("getDeleted");
        public Comment SetDeleted(bool var1) => CallAsWrapper<Comment>("setDeleted", var1);

        public string GetHtmlDescription() => Call<string>("getHtmlDescription");
        public Comment SetHtmlDescription(string var1) => CallAsWrapper<Comment>("setHtmlDescription", var1);

        public IList<Reply> GetReplies() => Call<AndroidJavaObject>("getReplies").AsListFromWrappable<Reply>();
        public Comment SetReplies(IList<Reply> var1) => CallAsWrapper<Comment>("setReplies", var1);

        public string GetId() => Call<string>("getId");
        public Comment SetId(string var1) => CallAsWrapper<Comment>("setId", var1);

        public string GetCategory() => Call<string>("getCategory");
        public Comment SetCategory(string var1) => CallAsWrapper<Comment>("setCategory", var1);

        public DateTime GetEditedTime() => CallAsWrapper<DateTime>("GetEditedTime");
        public Comment SetEditedTime(DateTime var1) => CallAsWrapper<Comment>("SetEditedTime", var1);

        public QuotedContent GetQuotedContent() => CallAsWrapper<QuotedContent>("getQuotedContent");
        public Comment SetQuotedContent(QuotedContent var1) => CallAsWrapper<Comment>("setQuotedContent", var1);

        public bool GetResolved() => CallAsBool("getResolved");
        public Comment SetResolved(string var1, AndroidJavaObject var2) => CallAsWrapper<Comment>("setResolved", var1, var2);

        public Comment Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Comment>("set", var1, var2);
        public Comment Clone() => CallAsWrapper<Comment>("clone");

        public class QuotedContent : JavaObjectWrapper
        {
            public QuotedContent(AndroidJavaObject javaObject) : base(javaObject) { }
            public QuotedContent() : base("com.huawei.cloud.services.drive.model.Comment$QuotedContent") { }

            public string GetMimeType() => Call<string>("getMimeType");
            public QuotedContent SetMimeType(string var1) => CallAsWrapper<QuotedContent>("setMimeType", var1);

            public string GetContent() => Call<string>("getContent");
            public QuotedContent SetContent(string var1) => CallAsWrapper<QuotedContent>("setContent", var1);

            public QuotedContent Clone() => CallAsWrapper<QuotedContent>("clone");
            public QuotedContent Set(string var1, AndroidJavaObject var2) => CallAsWrapper<QuotedContent>("set", var1, var2);
        }
    }
}
