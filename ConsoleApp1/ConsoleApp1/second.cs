using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class second
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("Enter the rollno");
             String roll=Console.ReadLine();
            Console.WriteLine("Enter the name");
            String name=Console.ReadLine();
            Console.WriteLine("Enter marks for physics");
            int phy=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks for maths");
            int math=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter marks for chem");
            int chem=int.Parse(Console.ReadLine());
            Console.WriteLine("Total marks="+(phy + math + chem));
            if(phy >= 55 && math>=65 && chem>=50 && (phy + math + chem)>=180) 
            {
                Console.WriteLine("ELIGIBLE");

            }
            else
            {
                Console.WriteLine("Not ELIGIBILE");
            }
            Console.WriteLine("Percentage="+((phy + math + chem)*100)/300);

        }
    }
}
