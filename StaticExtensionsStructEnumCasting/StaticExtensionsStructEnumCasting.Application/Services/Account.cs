using StaticExtensionsStructEnumCasting.Application.Constants;
using StaticExtensionsStructEnumCasting.Application.Enums;
using StaticExtensionsStructEnumCasting.Application.Interfaces;

namespace StaticExtensionsStructEnumCasting.Application.Services
{
    public class Account : IAccount
    {
        public void Login(string email, string password, Role r)
        {
            if (email == LoginConstants.Email && password == LoginConstants.Password)
            {
                if (r==Role.SuperAdmin)
                {
                    Console.WriteLine(LoginConstants.SuccessMessage);
                }
                else
                {
                    Console.WriteLine(LoginConstants.Denied);
                }
            }
            else
            {
                Console.WriteLine(LoginConstants.UnSuccess);
            }
        }
    }
}
