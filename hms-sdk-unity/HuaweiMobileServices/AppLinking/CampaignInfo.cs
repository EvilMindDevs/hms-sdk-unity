using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.AppLinking
{
    public class CampaignInfo : JavaObjectWrapper
    {
        public CampaignInfo(AndroidJavaObject javaObject) : base(javaObject) { }

        public CampaignInfo() : base("com.huawei.agconnect.applinking.AppLinking$CampaignInfo") { }

        public Builder NewBuilder => CallAsWrapper<Builder>("newBuilder");
    }

    public class Builder : JavaObjectWrapper
    {
        public Builder(AndroidJavaObject javaObject) : base(javaObject) { }

        public Builder() : base("com.huawei.agconnect.applinking.AppLinking$CampaignInfo") { }

        public CampaignInfo Build() => CallAsWrapper<CampaignInfo>("build");

        public Builder SetName(string name) => CallAsWrapper<Builder>("setName", name.AsJavaString());

        public Builder SetSource(string source) => CallAsWrapper<Builder>("setSource", source.AsJavaString());

        public Builder SetMedium(string medium) => CallAsWrapper<Builder>("setMedium", medium.AsJavaString());

    }
}
