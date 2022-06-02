using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class SocialCardInfo : JavaObjectWrapper
    {
        public SocialCardInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public SocialCardInfo() : base("com.huawei.agconnect.applinking.AppLinking$SocialCardInfo") { }

        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.agconnect.applinking.AppLinking$SocialCardInfo");

        public static Builder NewBuilder() => javaClass.CallStaticAsWrapper<Builder>("newBuilder");


        public class Builder : JavaObjectWrapper
        {
            public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

            public Builder() : base("com.huawei.agconnect.applinking.AppLinking$SocialCardInfo$Builder") { }

            public SocialCardInfo Build() => CallAsWrapper<SocialCardInfo>("build");

            public Builder SetDescription(string description) => CallAsWrapper<Builder>("setDescription", description.AsJavaString());

            public Builder SetImageUrl(string imageUrl) => CallAsWrapper<Builder>("setImageUrl", imageUrl.AsJavaString());

            public Builder SetTitle(string title) => CallAsWrapper<Builder>("setTitle", title.AsJavaString());


        }
    }
}
