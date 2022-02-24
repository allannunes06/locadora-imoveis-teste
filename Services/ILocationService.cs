using homeLocation.Models;
using System.Collections.Generic;


namespace homeLocation.Services
{
    interface ILocationService
    {
        List<Location> GetLocation();
        Location AddLocation(Location newLocation);
        Location DeleteLocation(int id);
        Location UpdateLocation(Location newLocation);
    }
}
