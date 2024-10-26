namespace MethodPractice.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
            #region task1
            //Console.WriteLine("1ci reqemi daxil et..");
            //int num1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2ci reqemi daxil et..");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3ci reqemi daxil et..");
            //int num3 = Convert.ToInt32(Console.ReadLine());

            //int biggest=default;

            //if (num1>num2)
            //{
            //    if (num1 > num3)
            //        biggest = num1;

            //}else if (num2>num3)
            //{
            //    biggest = num2;
            //}
            //else
            //{
            //    biggest = num3;
            //}
            //Console.WriteLine($"en boyuk eded {biggest}");


            #endregion
            #region task2
            //Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
            //string word = "TestA";
            //bool hasA=false;
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == 'A')
            //    {
            //        hasA = true;
            //        break;
            //    }
            //}
            //if (hasA)
            //    Console.WriteLine("tapildi");
            //else
            //    Console.WriteLine("tapilmadi");

            #endregion
            #region task3
            //Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
            //int count = 0;
            //string word = "Test";
            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (word[i] == 'A')
            //        count++;
            //}
            //Console.WriteLine(count);

            ////git commit -m "feat:task added"
            ////git commit -m "refactor:task added"
            ////git commit -m "bug-fix:task added"

            #endregion
            #region task4
            //int num;
            //do
            //{
            //    Console.WriteLine("ededi daxil et");
            //    num = Convert.ToInt32(Console.ReadLine());

            //} while (num%2!=0||num<0);

            //int result = num * num;
            //Console.WriteLine(result);
            #endregion
            #region task5
            //int[] numbers = new int[]{ 1, 2, 3, 4, 5 };
            //int sum = default;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            #endregion
            #region task6
            //string educationType=Console.ReadLine();//programing
            //switch (educationType)
            //{
            //    case "programing":
            //        Console.WriteLine("400");
            //        break;
            //    case "design":
            //        Console.WriteLine("250");
            //        break;
            //    case "system":
            //        Console.WriteLine("20");
            //        break;
            //    default:
            //        Console.WriteLine("duzgun daxil et..");
            //        break;
            //}
            //string result = educationType switch
            //{
            //    "programing" => "400saat",
            //    "system" => "200saat",
            //    "design" => "250saat",
            //    _ => "duzgun daxil et",
            //};
            //if (educationType =="programing")
            //    Console.WriteLine("400");
            //else if(educationType =="design")
            //    Console.WriteLine("250");
            //else if(educationType =="system")
            //    Console.WriteLine(200);
            //else
            //    Console.WriteLine("duzgun daxil et..");
            #endregion
        }
    }
}
