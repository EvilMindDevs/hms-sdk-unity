using UnityEngine;
using System.Collections;
using HuaweiMobileServices.Utils;

//com.huawei.hms.nearby.transfer.TransferStateUpdate
namespace HuaweiMobileServices.Nearby.Transfer
{
    public class TransferStateUpdate : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public TransferStateUpdate(AndroidJavaObject javaObject) : base(javaObject) { }

        public long GetBytesTransferred  => Call<long>("getBytesTransferred");
 
        public long GetDataId => Call<long>("getDataId");
        public int GetStatus => Call<int>("getStatus");
        public long GetTotalBytes => Call<long>("getTotalBytes");

        public class Status
        {
            public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.TransferStateUpdate$Status");

            public static int TRANSFER_STATE_CANCELED  => androidJavaClass.GetStatic<int>("TRANSFER_STATE_CANCELED");
            public static int TRANSFER_STATE_FAILURE => androidJavaClass.GetStatic<int>("TRANSFER_STATE_FAILURE");
            public static int TRANSFER_STATE_IN_PROGRESS => androidJavaClass.GetStatic<int>("TRANSFER_STATE_IN_PROGRESS");
            public static int TRANSFER_STATE_SUCCESS => androidJavaClass.GetStatic<int>("TRANSFER_STATE_SUCCESS");
        }
    }
}