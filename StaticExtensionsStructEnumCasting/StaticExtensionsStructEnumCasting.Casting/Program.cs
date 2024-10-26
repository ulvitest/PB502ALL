using StaticExtensionsStructEnumCasting.Casting.Models;

namespace StaticExtensionsStructEnumCasting.Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProgrammerEngineer programmerEngineer = new ProgrammerEngineer();
            //programmerEngineer.Id = 1;
            //programmerEngineer.Name = "Seymur";
            //programmerEngineer.Language= "C#";

            //DesignEngineer designEngineer = new DesignEngineer();
            //designEngineer.Id = 2;
            //designEngineer.Name = "Fidan";
            //designEngineer.Tool = "PhotoShop";

            ////boxing,implicit,upcasting

            //Person programmerEngineer2=new ProgrammerEngineer();

            //Person[] engineers = new Person[] { designEngineer, programmerEngineer, programmerEngineer2 };

            ////unboxing,explicit,downcasting;
            //foreach (var enginer in engineers)
            //{
            //    //if (enginer is DesignEngineer test)
            //    //{
            //    //    test.DoDesign();
            //    //}
            //    DesignEngineer d = enginer as DesignEngineer;
            //    if (d != null)
            //    {
            //        d.DoDesign();
            //    }
            //}

            //double num1 = 123.4;
            //int num = (int)num1;

            //implicit explicit operators;

            Manat manat = new Manat(340);
            Dollar dollar =manat;
            Console.WriteLine(dollar.Usd);





        }
    }
}
