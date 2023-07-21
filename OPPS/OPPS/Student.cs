using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPS
{
    internal class Student
    {

        String name;
        double percentage;
    
         public Student() { }  
         public Student(string name, double percentage)
        {
            this.name = name;
            this.percentage = percentage;
        }
        public void showGrade() 
        {
            if (this.percentage > 90)
            {
                Console.WriteLine("Excellent");
            }
            else if (this.percentage > 80 && this.percentage < 90)
            {
                Console.WriteLine("very good");
            }
            else if (this.percentage > 70 && this.percentage < 80)
            {
                Console.WriteLine("Good");
            }
            else if (this.percentage > 60 && this.percentage < 70)
            {
                Console.WriteLine("average");
            }
            else if (this.percentage > 40 && this.percentage < 60)
            {
                Console.WriteLine("pass");
            }
            else
            { Console.WriteLine("fail"); }
        }
    }
}
