using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.CloudDB
{
    public class Text : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Text() : base("com.huawei.agconnect.cloud.database.Text") { }
        public Text(string arg0) : base("com.huawei.agconnect.cloud.database.Text", arg0) { }

        public string Get() => Call<string>("get"); 
        public void Set(string arg0) => Call("set", arg0);
        public bool Equals(Text arg0) => Call<bool>("equals", arg0);
        public int HashCode() => Call<int>("hashCode");
    }

    public class Date : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public Date() : base("java.util.Date") { }
        public Date(string arg0) : base("java.util.Date", arg0) { }
        public Date(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base("java.util.Date", arg0, arg1, arg2, arg3, arg4, arg5) { }
        public Date(int arg0, int arg1, int arg2, int arg3, int arg4) : base("java.util.Date", arg0, arg1, arg2, arg3, arg4) { }
        public Date(long arg0) : base("java.util.Date", arg0) { }
        public Date(int arg0, int arg1, int arg2) : base("java.util.Date", arg0, arg1, arg2) { }
    }
}
