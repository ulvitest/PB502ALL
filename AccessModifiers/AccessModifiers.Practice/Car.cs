using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Practice
{
    class Car
    {
        //property
        public string Model { get; set; }
        private string Brand;
        protected string Color;
        private int _horsePower;
        public int HorsePower {
            get
            {
                if (_horsePower == 0)
                {
                    Console.WriteLine("set olmayib");
                    return -1;
                }
                return _horsePower;
            }
            set
            {
                if (value > 200)
                {
                    _horsePower = value;
                    return;
                }
                Console.WriteLine("duzgun daxil et");
            }
               
        }


        //public int GetHorsePower()
        //{
        //    if (_horsePower == 0)
        //    {
        //        Console.WriteLine("set olmayib");
        //        return -1;
        //    }
        //    return _horsePower;
        //}
        //public void SetPower(int power)
        //{
        //    if (power > 200)
        //    {
        //        _horsePower = power;
        //        return;
        //    }
        //    Console.WriteLine("duzgun daxil et");
        //}




        public Car(string model, string brand)
        {
            Model = model;
            Brand = brand;
        }
        public void Info()
        {
            Console.WriteLine($"Model :{Model} Brand : {Brand} Color :{Color}");
        }
    }
}
