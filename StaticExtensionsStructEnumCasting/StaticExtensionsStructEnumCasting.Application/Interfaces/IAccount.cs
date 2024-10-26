using StaticExtensionsStructEnumCasting.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensionsStructEnumCasting.Application.Interfaces
{
    public interface IAccount
    {
        void Login(string email,string password,Role r);
    }
}
