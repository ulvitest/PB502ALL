using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCopyThreadTaskAsynAwait.Lesson.Models
{
    internal class Bank
    {
        public object obj1 = new();
        public object obj2 = new();
        public int Balance { get; set; }

        public void Add()
        {
            lock (obj1)
            {
                lock (obj2)
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        Console.WriteLine("add method "+i);
                        Balance++;
                    }
                }
            }
        }
        public void WithDraw()
        {
            lock (obj2)
            {
                lock (obj1)
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        Console.WriteLine("withdraw method"+i);
                        Balance--;
                    }
                }
            }
        }
    }
}
