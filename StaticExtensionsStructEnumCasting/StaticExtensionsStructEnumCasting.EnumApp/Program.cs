using StaticExtensionsStructEnumCasting.Application.Services;

namespace StaticExtensionsStructEnumCasting.EnumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Account account = new Account();
            account.Login("test@code.edu.az"," test12345",Application.Enums.Role.SuperAdmin);
        }
    }
}
