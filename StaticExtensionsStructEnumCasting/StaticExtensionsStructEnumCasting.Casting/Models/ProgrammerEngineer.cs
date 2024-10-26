using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensionsStructEnumCasting.Casting.Models
{
    internal class ProgrammerEngineer : Engineer
    {
        public string Language { get; set; }
        public override void Detail()
        {
            Console.WriteLine("programmer detail...");
        }
        public void WriteCode()
        {
            Console.WriteLine("code........");
        }
    }
}
