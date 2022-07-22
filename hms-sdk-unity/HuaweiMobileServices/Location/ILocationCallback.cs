using HuaweiMobileServices.Location.Location;

namespace HuaweiMobileServices.Location
{
    public interface ILocationCallback
    {
        void OnLocationResult(LocationResult result);
        void OnLocationAvailability(LocationAvailability availability);
    }
}


