using System;
using System.Collections.Generic;
using System.Text;
namespace OOPv2
{
    class Dog
    {
        //Declare Fields
        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;

        
        //private bool Run = true;
        //private bool Bark = true;
        //private bool Potty = true;
        //private bool Cuddle = true;

        //Declare Properties
        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //Declare Constructor
        public Dog()
        {
            //default constructor
        }

        public Dog(int hairLength, int height, int runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        public void Run()
        {
            Console.Write("Your dog can run {0} miles per hour" , runningSpeed);
        }

        ////Methods
        //public void Runs()
        //{
        //    if (Run)
        //    {
        //        Run = false;
        //    }

        //    Console.WriteLine("Can dog run? " + Run);
        //}

        //public void Barks()
        //{
        //    if (Bark)
        //    {
        //        Bark = false;
        //    }

        //    Console.WriteLine("Can dog bark? " + Bark);
        //}

        //public void Potties()
        //{
        //    if (Potty)
        //    {
        //        Potty = false;
        //    }

        //    Console.WriteLine("Does dog go potty? " + Potty);
        //}

        //public void Cuddles()
        //{
        //    if (Cuddle)
        //    {
        //        Cuddle = false;
        //    }

        //    Console.WriteLine("Does dog cuddle? " + Cuddle);
        //}
    }
}