

namespace StaticExtensionsStructEnumCasting.StaticPractice.Extensions
{
    internal static partial class Extension
    {
        public static int Pow(this int a,int b )//3
        {
            int sum = 1;
            for (int i = 1; i <= b; i++)
            {
                sum *= a;
            }
            return sum;
        }
    
    }
}
