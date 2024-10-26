using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Enums;

namespace DelegatePractice.HomeTask.Models
{
    internal class User : IEntity   
    {
        public static int _id;

        public User(string email, string userName, Role role)
        {
            _id++;
            Id = _id;
            Email = email;
            UserName = userName;
            Role = role;
        }

        public int Id { get;}
        public string Email { get; set; }
        public string UserName { get; set; }
        public Role Role { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Name : {UserName}");
        }
       
    }
   
}
