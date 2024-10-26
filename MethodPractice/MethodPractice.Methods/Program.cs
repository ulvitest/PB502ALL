namespace MethodPractice.Methods
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = { -10, 20, -5, 30 };
            int[]positiveNumbers= MakePositive(ref numbers);
            for (int i = 0; i < positiveNumbers.Length; i++)
            {
                Console.WriteLine(positiveNumbers[i]);
            }

        }

        #region firstPart
        //static void MakeSalam()
        //{
        //    Console.WriteLine("salam");
        //}
        //static void MakeName(string name)
        //{
        //    Console.WriteLine($"telebe adi {name}");
        //}
        //static int Sum(int a, int b)
        //{
        //    return a + b;
        //}
        //static int SumOrExtract(int num1, int num2)//1,7
        //{
        //    if (num1 > num2)
        //        return num1 - num2;
        //    else if (num1 == num2)
        //        return num1 * num2;
        //    return num1 + num2;
        //}
        //static char GetFirstLetter(string name)//parametr
        //{
        //    return name[0];
        //}
        //static bool CheckNumber(int r, int c)
        //{
        //    return r > c;
        //}
        #endregion
        #region secondPart
        //Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
        //static int CheckNumber(int a,int b,int c)
        //{
        //    if (a > b)
        //    {
        //        if (a > c)
        //            return a;

        //    }
        //    else if (b > c)
        //    {
        //       return b;
        //    }
        //    return c;
        //}

        ////Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
        //static bool CheckLetterA(string word)
        //{
        //    bool hasA = false;
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == 'A')
        //        {
        //            hasA = true;
        //            break;
        //        }
        //    }
        //    return hasA;

        //}

        //static int SumOfArray(int z,params int[] array)
        //{
        //    int sum = 0;    
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum+= array[i];
        //    }
        //    return sum;
        //}
        #endregion
        #region thirdPart
        //static void MakeFullName(string name,string surname="filankesov",string address="baki")
        //{
        //    Console.WriteLine(name+ " " + surname+ " "+address);
        //}
        #endregion

        #region fourthPart
        //method overloading,method signature
        //=>1.method adi,2.methodun parametlerinin data type,3.methodun parametlerinin sayi;
        //static void Sum(params int[]numbers)
        //{

        //}
        //static void Sum(int d)
        //{

        //}
        //static void Sum(int d,int c=3)
        //{

        //}



        #endregion
        #region fifthPart
        static int[] MakePositive(ref int[] array)//-10, 20, -5, 30 
        {
            int index = 0;
            int count=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>0)
                {
                    array[index++] = array[i]; //20 30
                }

            }
            return array;
        }
        #endregion

    }

}

