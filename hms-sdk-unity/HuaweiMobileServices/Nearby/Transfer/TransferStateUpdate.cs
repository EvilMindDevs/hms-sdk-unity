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

        public long GetBytesTransferred
        {
            get => Call<long>("getBytesTransferred");
        }
        public long GetDataId
        {
            get => Call<long>("getDataId");
        }
        public int GetStatus
        {
            get => Call<int>("getStatus");
        }
        public long GetTotalBytes
        {
            get => Call<long>("getTotalBytes");
        }
        public long HashCode
        {
            get => Call<long>("hashCode");
        }
        public void WriteToParcel(Parcel dest, int flags) => Call("writeToParcel", dest, flags);
        public int DescribeContents() => Call<int>("describeContents");

        public bool Equals(AndroidJavaObject androidJavaObject) => Call<bool>("equals");

        public class Status
        {
            public static AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.huawei.hms.nearby.transfer.TransferStateUpdate$Status");

            public static int TRANSFER_STATE_CANCELED
            {
                get => androidJavaClass.GetStatic<int>("TRANSFER_STATE_CANCELED");
            }
            public static int TRANSFER_STATE_FAILURE
            {
                get => androidJavaClass.GetStatic<int>("TRANSFER_STATE_FAILURE");
            }
            public static int TRANSFER_STATE_IN_PROGRESS
            {
                get => androidJavaClass.GetStatic<int>("TRANSFER_STATE_IN_PROGRESS");
            }
            public static int TRANSFER_STATE_SUCCESS
            {
                get => androidJavaClass.GetStatic<int>("TRANSFER_STATE_SUCCESS");
            }
        }
    }
}