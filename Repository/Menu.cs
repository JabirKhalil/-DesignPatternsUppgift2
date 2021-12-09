using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
   public static class Menu
    {
        public static void MenuOptions()
        {
            Console.WriteLine("Welcome To Database");
            Console.WriteLine("---------------------");
            Console.WriteLine(" Option ");
            Console.WriteLine("---------------------");
            Console.WriteLine("A: Get Data");
            Console.WriteLine("B: Get Customer");
            Console.WriteLine("C: Get Animal");
            Console.WriteLine("D: Save Data");
            Console.WriteLine("E: Save Customer");
            Console.WriteLine("F: Save Animal");
            Console.WriteLine("X: Exit Program");
        }
    }
}
