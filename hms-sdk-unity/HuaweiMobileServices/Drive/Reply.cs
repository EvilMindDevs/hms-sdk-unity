using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class Reply : JavaObjectWrapper
    {
        public Reply(AndroidJavaObject javaObject) : base(javaObject) { }
        public Reply() : base("com.huawei.cloud.services.drive.model.Reply") { }

        public string GetOperate() => Call<string>("getOperate");
        public Reply SetOperate(string var1) => CallAsWrapper<Reply>("setOperate", var1);

        public User GetCreator() => CallAsWrapper<User>("getCreator");
        public Reply SetCreator(User var1) => CallAsWrapper<Reply>("setCreator", var1);

        public string GetDescription() => Call<string>("getDescription");
        public Reply SetDescription(string var1) => CallAsWrapper<Reply>("setDescription", var1);

        public DateTime GetCreatedTime() => CallAsWrapper<DateTime>("getCreatedTime");
        public Reply SetCreatedTime(DateTime var1) => CallAsWrapper<Reply>("setCreatedTime", var1);

        public bool GetDeleted() => CallAsBool("getDeleted");
        public Reply SetDeleted(bool var1) => CallAsWrapper<Reply>("setDeleted", var1);

        public string GetHtmlDescription() => Call<string>("getHtmlDescription");
        public Reply SetHtmlDescription(string var1) => CallAsWrapper<Reply>("setHtmlDescription", var1);

        public string GetId() => Call<string>("getId");
        public Reply SetId(string var1) => CallAsWrapper<Reply>("setId", var1);

        public string GetCategory() => Call<string>("getCategory");
        public Reply SetCategory(string var1) => CallAsWrapper<Reply>("setCategory", var1);

        public DateTime GetEditedTime() => CallAsWrapper<DateTime>("getEditedTime");
        public Reply SetEditedTime(DateTime var1) => CallAsWrapper<Reply>("setEditedTime", var1);

        public Reply Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Reply>("set", var1, var2);
        public Reply Clone() => CallAsWrapper<Reply>("clone");
    }
}
