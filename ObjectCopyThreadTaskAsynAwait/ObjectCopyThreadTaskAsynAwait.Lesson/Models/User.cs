using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ObjectCopyThreadTaskAsynAwait.Lesson.Models
{
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public UserDetail Detail { get; set; }

        public override string ToString()
        {
            return Id+" "+Name+" "+City+" "+Detail.PhoneNumber;
        }

        public User ShallowCopy()
        {
           return this.MemberwiseClone() as User;
        }
        public User DeepCopy()
        {
            var result=JsonSerializer.SerializeToUtf8Bytes(this);
            return JsonSerializer.Deserialize<User>(result);
        }
    }
}
