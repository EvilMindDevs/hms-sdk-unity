using HuaweiMobileServices.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace HuaweiMobileServices.ML.DownloadModel
{
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
