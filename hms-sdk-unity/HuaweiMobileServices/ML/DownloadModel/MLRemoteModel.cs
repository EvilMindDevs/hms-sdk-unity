using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.DownloadModel
{
    // Wrapper for com.huawei.hms.mlsdk.model.download.MLRemoteModel
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mlremotemodel-0000001050444221
    public class MLRemoteModel : JavaObjectWrapper
    {
        public MLRemoteModel(AndroidJavaObject javaObject) : base(javaObject) { }

        public override bool Equals(object other) => CallAsBool("equals", other);
        public override int GetHashCode() => Call<int>("hashCode");
    }
}
