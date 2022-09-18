using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_reviewer
{
    class Person
    {
        private string name;
        private int age;
        private bool isActive;

        public Person(string name, int age, bool isActive){
            this.name = name;
            this.age = age;
            this.isActive = isActive;
        }

        public void printDetails()
        {
            System.Console.WriteLine("{0} is {1} years old.", this.name, this.age.ToString());
        }

        public int getYearOfDate()
        {
            return 2022 - this.age;
        }
    }
 
}
