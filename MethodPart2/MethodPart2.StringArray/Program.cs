using System.Globalization;
using System.Text;

namespace MethodPart2.StringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "LoreM";
            //Console.WriteLine(word.Length);
            //word.ToLower();
            //Console.WriteLine(word);
            //Console.WriteLine(word.ToUpper());
            //Console.WriteLine("lorem"==word);
            //Console.WriteLine(word.Equals(word2,StringComparison.OrdinalIgnoreCase));
            //Console.OutputEncoding=Encoding.Unicode;
            //CultureInfo culture = new CultureInfo("az");
            //string name = "isim";
            //Console.WriteLine(name.ToUpper());
            //Console.WriteLine(name.ToUpperInvariant());
            //Console.WriteLine(word.Replace("Lo","Ta"));
            //Console.WriteLine(word.Replace('L','A'));
            string word2 = "IpsumpAa";
            //Console.WriteLine(word+" "+word2);
            //Console.WriteLine($"{word}{word2}");
            //Console.WriteLine(string.Concat(word,word2,"Cavid"));
            //Console.WriteLine(word2.LastIndexOf('p'));
            //Console.WriteLine(string.Compare("bcedz","%"));
            //Console.WriteLine(word2.Substring(3,2));
            //Console.WriteLine(word2.StartsWith('A'));
            //Console.WriteLine(word2.EndsWith('A'));
            //Console.WriteLine(word2.Contains("Aa"));//lorem ipsum   lo
            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine($"#{new string('=',i)}#");
            //}
            //Console.WriteLine("===================");
            //Array

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.Rank);
            //int[,] numbers2 = new int[2, 3];
            //Console.WriteLine(numbers2.Length);
            //Array.Reverse(numbers);
            //Array.Sort(numbers);

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}
            int[] numbers = { 23, 77, 11,1,66 };
            //int[] numbers2 = new int[2];
            //Array.Copy(numbers, numbers2, 2);
            //foreach (var num in numbers2)
            //{
            //    Console.WriteLine(num);
            //}
            //Console.WriteLine(numbers.Contains(11));
            Array numbers2= Array.CreateInstance(typeof(int),4);//0,0,0,0 null,null
            
            //int[]newNumbers=numbers2 as int[];
            //newNumbers[0] = 12;
            //newNumbers[0] = 12;
            //newNumbers[0] = 12;
            //newNumbers[0] = 12;







        }
    }
}
