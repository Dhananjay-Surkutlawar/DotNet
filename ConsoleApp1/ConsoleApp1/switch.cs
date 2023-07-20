using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class @switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month no");
               int month = int.Parse(Console.ReadLine());
            switch (month) { 
                    case 1: Console.WriteLine("jan");            
                        break;
                    case 2: Console.WriteLine("feb");        
                        break;
                    case 3: Console.WriteLine("mar"); ;
                        break;      
                    case 4: Console.WriteLine("apr");   
                        break;
                    case 5: Console.WriteLine("may");    
                        break;
                    case 6: Console.WriteLine("june");
                        break;  
                    case 7: Console.WriteLine("jul");
                        break;
                    case 8: Console.WriteLine("aug");
                        break;  
                    case 9: Console.WriteLine("sept");
                        break;  
                    case 10: Console.WriteLine("oct");
                        break;      
                    case 11: Console.WriteLine("nov");       
                        break;  
                    case 12: Console.WriteLine("dec");   
                        break;
                    default: Console.WriteLine("invalid month no");
                    break;
                    
                   
            }
        }
    }
}
