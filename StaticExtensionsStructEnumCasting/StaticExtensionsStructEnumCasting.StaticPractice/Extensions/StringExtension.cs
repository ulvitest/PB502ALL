using System.Text.RegularExpressions;

namespace StaticExtensionsStructEnumCasting.StaticPractice.Extensions
{
    internal static partial class Extension
    {
        public static bool CheckStr(this string str,string pattern) //12a
        {
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }

    }
}
