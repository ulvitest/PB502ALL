namespace ClassInheritance.HomeWork
{
    internal class Account
    {
        public void Login(string userName,string password)
        {
            if (userName == "lorem123" && password == "123456*")
                Console.WriteLine("giris ugurludur..");
            else
                Console.WriteLine("giris ugursuzdur...");
        }
    }
}
