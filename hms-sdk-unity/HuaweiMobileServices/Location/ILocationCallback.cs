using HuaweiMobileServices.Location.Location;
using System;
using System.Collections.Generic;
using System.Text;

namespace HuaweiMobileServices.Location
{
    public interface ILocationCallback
    {
        void OnLocationResult(LocationResult result);
        void OnLocationAvailability(LocationAvailability availability);
    }
}
