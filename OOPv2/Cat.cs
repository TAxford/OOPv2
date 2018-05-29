using System;
using System.Collections.Generic;
using System.Text;

namespace OOPv2
{
    class Cat
    {
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;

        //field
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Cat()
        {
            //default constructor
        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
    }
}
