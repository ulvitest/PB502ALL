

using AccessModifiers.Notification;
using AccessModifiers.Practice.Models;
using Demo.Test;

namespace AccessModifiers.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region public,private,protected
            //public=>class,all class members(field,method,property)
            //public=>(classin daxilinde,instance,inheritance);
            //class=>yalniz (public ve ya internal)=>default internal

            //private=>all class members
            //all class membersin default access mod=>private;
            //private=>class daxilinde;

            //protected=>all class members;
            //protected=>class daxilinde,inheritance;
            //Car car = new("", "");
            //car.Color = "";

            #endregion

            #region encapsulation
            //User user = new User();
            //user.Name = "_userrrrrrrrrrrr";
            //user.Surname = "";
            //user.Age= 30;

            #endregion
            #region (public,private) readonlyFields

            //User user = new User();
            //Console.WriteLine(user.Address);
            #endregion

            #region namespace,.exe,.dll
            //User user = new User();
            NotificationService notification = new();
            notification.Message = "salam";
            #endregion

            #region internal,private protected,protected internal
            //internal=>class,all class members
            #endregion

        }
    }
}

namespace Demo //nested
{
   
    
}
namespace Demo.Test
{
    class User:NotificationService
    {
        public User()
        {

            Message = "";
        }
    }
}
