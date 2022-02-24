using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeLocation.Models
{
    public class House
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string City { get; set; }

        public House()
        {

        }
        public House(int idHouse, string type, string city)
        {
            Id = idHouse;
            Type = type;
            City = city;
        }

    }
}
