

namespace Generic.Homework.Models
{
    internal abstract class Product
    {
        private static int _id;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalInCome { get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();
        protected Product()
        {
            _id++;
            Id = _id;
        }
    }
}
