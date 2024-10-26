using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInterface.NewLessons.Interfaces
{
    interface ISubstract
    {
        void Substract(int a, int b);
    }
    interface IMultiple:ISubstract
    {
        void Multiple(int a, int b);
    }
    interface IA
    {
        void Sum();
    }
    interface IB
    {
        void Sum();
    }
    class SumService : IA,IB
    {
        public int Age { get; set; }

        public void Sum()
        {
            throw new NotImplementedException();
        }

        void IA.Sum()
        {
            throw new NotImplementedException();
        }

    }


}
