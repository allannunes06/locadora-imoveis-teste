using homeLocation.Models;
using System.Collections.Generic;


namespace homeLocation.Services
{
   public interface IHouseService
    {
        List<House> GetHouse();
        House AddHouse(House newHouse);
        House DeleteHouse(int id);
        House UpdateHouse(House newUsers);
    }
}
