using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class StartCursor : JavaObjectWrapper
    {
        public StartCursor(AndroidJavaObject javaObject) : base(javaObject) { }
        public StartCursor() : base("com.huawei.cloud.services.drive.model.StartCursor") { }

        public string GetCategory() => Call<string>("getCategory");
        public StartCursor SetCategory(string var1) => CallAsWrapper<StartCursor>("setCategory", var1);

        public string getStartCursor() => Call<string>("getStartCursor");
        public StartCursor setStartCursor(string var1) => CallAsWrapper<StartCursor>("setStartCursor", var1);

        public StartCursor Set(string var1, AndroidJavaObject var2) => CallAsWrapper<StartCursor>("set", var1, var2);
        public StartCursor Clone() => CallAsWrapper<StartCursor>("clone");
    }
}
