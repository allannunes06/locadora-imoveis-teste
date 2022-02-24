using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace homeLocation.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User()
        {

        }
        public User(int idUser, string name)
        {
            Id = idUser;
            Name = name;
        }
    }
}
