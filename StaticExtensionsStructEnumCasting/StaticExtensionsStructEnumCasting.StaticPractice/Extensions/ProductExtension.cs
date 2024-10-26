using StaticExtensionsStructEnumCasting.StaticPractice.Models;

namespace StaticExtensionsStructEnumCasting.StaticPractice.Extensions
{
    internal static partial class Extension
    {
        public static bool GetProfit(this Product p,double price)
        {
            return (p.SalePrice - p.CostPrice)>price;
        }
    }
}
