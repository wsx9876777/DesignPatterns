using Prototype.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Concrete
{
    class Toilet
    {
        private int _Square;
        public int Square
        {
            get { return _Square; }
            set { _Square = value; }
        }
        private int _Height;

        public int Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        public Toilet Clone()
        {
            return this.MemberwiseClone() as Toilet;
        }
    }
    class BigHouse : IHousePrototype
    {
        private int _Square;

        public int Square
        {
            get { return _Square; }
            set { _Square = value; }
        }
        private int _Height;

        public int Height
        {
            get { return _Height; }
            set { _Height = value; }
        }
        private int securityNum =123;
        
        private Toilet _Toilet;

        public Toilet Toilet
        {
            get => _Toilet;
            set { _Toilet = value; }
        }


        public void build()
        {
            Console.WriteLine($"{_Square} {Height} {securityNum};");
            Console.WriteLine($"Toilet {_Toilet.Height};");
        }
        public IHousePrototype Clone()
        {
            var a = this.MemberwiseClone() as BigHouse;
            a.Toilet = this.Toilet.Clone();
            return a;
        }
    }
}
