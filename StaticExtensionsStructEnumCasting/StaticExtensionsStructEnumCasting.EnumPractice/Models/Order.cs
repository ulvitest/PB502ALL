using StaticExtensionsStructEnumCasting.EnumPractice.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensionsStructEnumCasting.EnumPractice.Models
{
    internal class Order
    {
        public int No { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatus Status { get; set; }
    }
}