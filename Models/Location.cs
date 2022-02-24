using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeLocation.Models
{
    public class Location
    {
        public Location()
        {

        }
        public Location(int idLocation, int idUser, int idHouse, DateTime dataLocation, DateTime dataDevolution)
        {
            Id = idLocation;
            IdUser = idUser;
            IdHouse = idHouse;
            DataLocation = dataLocation;
            DataDevolution = dataDevolution;
        }

        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdHouse { get; set; }

        public DateTime DataLocation { get; set; }

        public DateTime DataDevolution { get; set; }
    }
}

