﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExtensionsStructEnumCasting.Casting.Models
{
    internal abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void Detail(); 

    }
}
