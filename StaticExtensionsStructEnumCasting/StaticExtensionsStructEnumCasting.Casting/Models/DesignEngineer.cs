

namespace StaticExtensionsStructEnumCasting.Casting.Models
{
    internal class DesignEngineer : Engineer
    {
        public string Tool { get; set; }
        public override void Detail()
        {
            Console.WriteLine("design detail");
        }
        public void DoDesign()
        {
            Console.WriteLine("design...");
        }
    }
}
