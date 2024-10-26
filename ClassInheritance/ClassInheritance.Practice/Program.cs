using System.Text;

namespace ClassInheritance.Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string word = "lorem ipsum";// merol muspi;
            Console.WriteLine(ReverseStr(word));
        }
        static string ReverseStr(string str)
        {
            string[] words = str.Split(' '); //[lorem,Ipsum];
            StringBuilder newWord = new StringBuilder();
            foreach (var word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    newWord.Append(word[i]);//merol
                }
                newWord.Append(' ');
            }
            return newWord.ToString().TrimEnd();
           
        }
    }
}
