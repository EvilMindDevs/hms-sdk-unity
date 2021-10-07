using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class DateTime : JavaObjectWrapper
    {
        public DateTime(AndroidJavaObject javaObject) : base(javaObject) { }
        public DateTime(string var1) : base("com.huawei.cloud.base.util.DateTime", var1) { }

        public long GetValue() => Call<long>("getValue");
        public bool IsDateOnly() => Call<bool>("isDateOnly");
        public int GetTimeZoneShift() => Call<int>("getTimeZoneShift");
        public string ToStringRfc3339() => Call<string>("toStringRfc3339");
    }
}
