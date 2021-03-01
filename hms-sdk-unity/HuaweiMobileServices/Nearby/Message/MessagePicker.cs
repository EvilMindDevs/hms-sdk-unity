using HuaweiMobileServices.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace HuaweiMobileServices.Nearby.Message
{
   public  class MessagePicker : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public MessagePicker(AndroidJavaObject javaObject) : base(javaObject) { }

        public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.message.MessagePicker");
        public static MessagePicker DEFAULT => androidJavaClass.GetStatic<MessagePicker>("INCLUDE_ALL_TYPES");
        public bool Equals(AndroidJavaObject androidJavaObject) => androidJavaClass.Call<bool>("equals", androidJavaObject);
 
        public int HashCode => androidJavaClass.Call<int>("hashCode");
        public void WriteToParce(Parcel dest, int flags) => androidJavaClass.Call("writeToParcel", dest, flags);
        public int DescribeContents => androidJavaClass.Call<int>("describeContents");
        public String ToStringObject => androidJavaClass.Call<String>("toString");
        public class Builder : JavaObjectWrapper
        {
            [UnityEngine.Scripting.Preserve]
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.hms.nearby.message.MessagePicker$Builder") { }
            public GetOption Build() => CallAsWrapper<GetOption>("build");
            public Builder IncludeAllTypes() => Call<Builder>("includeAllTypes"); 
        }
    }
}
