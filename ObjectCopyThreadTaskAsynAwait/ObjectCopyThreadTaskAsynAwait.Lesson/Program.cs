using ObjectCopyThreadTaskAsynAwait.Lesson.Models;

namespace ObjectCopyThreadTaskAsynAwait.Lesson
{
    internal class Program
    {
        static void  Main(string[] args)
        {
            //shallow and deep copy=>serialize=>deserialize,async await
            #region copy
            //User user1= new User() {
            //    Id = 1,
            //    Name="Ayxan",
            //    City="Baki",
            //    Detail=new() 
            //    {
            //        PhoneNumber="+994"
            //    }
            //};

            //User user2 =user1.ShallowCopy();

            //user2.Name = "Filankes";
            //user2.Detail.PhoneNumber = "1233";

            //Console.WriteLine(user1);
            //User user1 = new User()
            //{
            //    Id = 1,
            //    Name = "Ayxan",
            //    City = "Baki",
            //    Detail = new()
            //    {
            //        PhoneNumber = "+994"
            //    }
            //};
            //User user2 = user1.DeepCopy();
            //user2.Detail.PhoneNumber="12345";

            //Console.WriteLine(user1);

            #endregion

            #region
            //process,thread Task,
            //Thread thread1 = new(Loop1);
            //Thread thread2 = new(Loop2);

            //thread1.Start();
            //thread2.Start();
            //thread1.Join();
            //Console.WriteLine("Hello PB502");
            //thread2.Join();

            //Console.WriteLine("Bye PB502");
            //race condition =>lock ,deadlock
            Bank bank = new Bank();
            Thread thread1 = new(bank.Add);
            Thread thread2 = new(bank.WithDraw);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
            
            Console.WriteLine(bank.Balance);
            Console.ReadLine();


            #endregion

        }

        public static void Loop1()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"first loop {i}");
            }
        }
        public static void Loop2()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine($"second loop {i}");
            }
        }
    }
}
