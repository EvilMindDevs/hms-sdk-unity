using HuaweiMobileServices.Utils;

namespace HuaweiMobileServices.Location
{
    public interface IBroadcastListener
    {
        void OnReceive(AndroidIntent intent);
    }
}
