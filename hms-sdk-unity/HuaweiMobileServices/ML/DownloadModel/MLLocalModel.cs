using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.ML.DownloadModel
{
    // Wrapper for com.huawei.hms.mlsdk.model.download.MLLocalModel
    // https://developer.huawei.com/consumer/en/doc/hiai-References/mllocalmodel-0000001054841474
    public class MLLocalModel : JavaObjectWrapper
    {
        public MLLocalModel(AndroidJavaObject javaObject) : base(javaObject)
        {
        }

        public string ModelName => Call<string>("getModelName");
        public string AssetPathFile => Call<string>("getAssetPathFile");
        public string LocalFullPathFile => Call<string>("getLocalFullPathFile");

        public override int GetHashCode() => Call<int>("hashCode");
        public override bool Equals(object other) => CallAsBool("equals", other);


    }
}
