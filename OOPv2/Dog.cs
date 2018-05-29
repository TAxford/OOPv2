using System;
using System.Collections.Generic;
using System.Text;

namespace OOPv2
{
    class Dog
    {
        private int hairLength;
        private int height;
        private double runningSpeed;
        private double weight;
        private bool Run = true;
        private bool Bark = true;
        private bool Potty = true;
        private bool Cuddle = true;

        //fields
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

        public double RunningSpeed
        {
            get { return this.runningSpeed; }
            set { this.runningSpeed = value; }
        }

        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //Cunstructor
        public Dog()
        {
            //default constructor
        }

        public Dog(int hairLength, int height, double runningSpeed, double weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

    }
}
