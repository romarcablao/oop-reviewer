using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_reviewer
{
     // Parent Class
    class School
    {
        public string? name;
        public string? address;

        public virtual string getLocation()
        {
            return "[School]: " + this.name + " is located at " + this.address;
        }

    }

    // Derived Class
    class College : School
    {
        public string[]? courses;

        public College(string name) {
            this.name = name;
        }

        public override string getLocation()
        {
            if (this.address != null) {
                return "[College]: " + this.name + " is located at " + this.address;
            }
            return "Cannot get location!";
        }

        public string getLocation(string addr1, string addr2)
        {
            return "[College]: " + this.name + " is located at " + addr1 + " and " + addr2;
        }

        public void printCourses()
        {
            if(this.courses != null)
            {
                for (int a = 0; a < this.courses.Length; a++)
                {
                    Console.WriteLine(this.courses[a]);
                }
            }
        }
    }

    // Derived Class
    class SeniorHigh : School
    {
        public string[]? strands;

        public void printStrands()
        {
            if(strands != null)
            {
                for (int a = 0; a < this.strands.Length; a++)
                {
                    Console.WriteLine(this.strands[a]);
                }
            }
            
        }
    }

}
