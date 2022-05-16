using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Drive
{
    public class Channel : JavaObjectWrapper
    {
        public Channel(AndroidJavaObject javaObject) : base(javaObject) { }
        public Channel() : base("com.huawei.cloud.services.drive.model.Channel") { }

        public string GetUrl() => Call<string>("getUrl");
        public Channel SetUrl(string var1) => CallAsWrapper<Channel>("setUrl", var1);

        public string GetId() => Call<string>("getId");
        public Channel SetId(string var1) => CallAsWrapper<Channel>("setId", var1);

        public string GetCategory() => Call<string>("getCategory");
        public Channel SetCategory(string var1) => CallAsWrapper<Channel>("setCategory", var1);

        public string GetResourceId() => Call<string>("getResourceId");
        public Channel SetResourceId(string var1) => CallAsWrapper<Channel>("setResourceId", var1);

        public string GetResourceUri() => Call<string>("getResourceUri");
        public Channel SetResourceUri(string var1) => CallAsWrapper<Channel>("setResourceUri", var1);

        public string GetUserToken() => Call<string>("getUserToken");
        public Channel SetUserToken(string var1) => CallAsWrapper<Channel>("setUserToken", var1);

        public new string GetType() => Call<string>("getType");
        public Channel SetType(string var1) => CallAsWrapper<Channel>("setType", var1);

        public long GetExpirationTime() => Call<long>("getExpirationTime");
        public Channel SetExpirationTime(long var1) => CallAsWrapper<Channel>("setExpirationTime", var1);

        public bool GetPayload() => Call<bool>("getPayload");
        public Channel SetPayload(bool var1) => CallAsWrapper<Channel>("setPayload", var1);

        public Channel Set(string var1, AndroidJavaObject var2) => CallAsWrapper<Channel>("set", var1, var2);
        public Channel Clone() => CallAsWrapper<Channel>("clone");
    }
}
