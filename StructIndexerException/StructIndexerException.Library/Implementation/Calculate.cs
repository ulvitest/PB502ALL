using StructIndexerException.Library.Interfaces;


namespace StructIndexerException.Library.Implementation
{
    public class Calculate : ICalculate
    {
        public void Divide(int a, int b)
        {
			try
			{
                Console.WriteLine(a / b);
            }
			catch (Exception)
			{

                throw;
            }
        }
    }
}
