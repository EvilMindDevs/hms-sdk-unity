using HuaweiMobileServices.Utils;
using UnityEngine;

//com.huawei.agconnect.cloud.database.ServerStatus
namespace HuaweiMobileServices.CloudDB
{
    public class ServerStatus : JavaObjectWrapper
    {
        public ServerStatus(AndroidJavaObject javaObject) : base(javaObject) { }

        public long ServerTimestamp
        {
            get => Call<long>("getServerTimestamp");
        }
    }
}

