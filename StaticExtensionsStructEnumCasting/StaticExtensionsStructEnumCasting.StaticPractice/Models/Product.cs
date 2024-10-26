

namespace StaticExtensionsStructEnumCasting.StaticPractice.Models
{
    internal class Product:Object
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
     
        public void Info()
        {
            Console.WriteLine(Id+" "+Name+ " "+SalePrice);
        }
        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object? obj)
        {
            if (obj != null&&obj is Product p)
            {
                return SalePrice== p.SalePrice;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (Id + Name).GetHashCode();
        }
    }
}
