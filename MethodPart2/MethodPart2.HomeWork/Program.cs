using System.Numerics;

namespace MethodPart2.HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 12;  
            //Pow(ref num);
            //Console.WriteLine(num);//144

            //int[] numbers = { 11, 10, 12 };
            //PowArr(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //string word = "lorem ipsum doler";//loremipsumdoler
            //ChangeStr(ref word);
            //Console.WriteLine(word);
            //int[] numbers = { 3, 7, 1 };//9=>3,7,1,9   
            //AddArr(ref numbers, 9);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            string[] names = { "Seymur", "Ramil", "Isa" };
            int operation;
            do
            {
                Console.WriteLine("emeliyyat sech :");
                Console.WriteLine("1.butun telebeleri goster");
                Console.WriteLine("2.secilmis telebe adi deyis");
                Console.WriteLine("0.Chixis");
               
                 operation = Convert.ToInt32(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("telebelerin list :");
                        WriteStudents(names);
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("index daxil et :");
                        int index = Convert.ToInt32(Console.ReadLine());
                        string newName = Console.ReadLine();
                        ChangeStuName(names,index,newName); 

                        WriteStudents(names);
                        break;

                    default:
                        Console.WriteLine("duzgun secim et..");
                        break;
                }

            } while (operation!=0);

        }
        static void ChangeStuName(string[]arr,int i,string newName)
        {
          
            arr[i] = newName;
        }
        static void WriteStudents(string[]arr)
        {
            foreach (string name in arr)
                Console.WriteLine(name);
        }
        static void Pow(ref int num)
        {
            num *= num;
        }
        static void PowArr(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }
        }
        static void ChangeStr(ref string str)
        {
            string newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i]!=' ')
                {
                    newStr += str[i];
                }
            }
            str = newStr;
        }
        static void AddArr(ref int[]array,int num)
        {
            int[]newArr= new int[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                newArr[i] = array[i];
            }
            newArr[array.Length] = num;
            array=newArr;
        }
    }
}
