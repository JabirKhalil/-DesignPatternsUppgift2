using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    public class SimulatedDatabase 
    {
        internal string Load(string v)
        {
            return v;
        }

        internal void Save(string data)
        {
            Console.WriteLine($"Saving data \"{data}\"");
        }

        public string GetData()
        {
            var data = Load("Dataset A");
            return data;
        }
        public string GetAnimal()
        {
            var animal = Load("From Table Animal Where Owner==Steve");
            return animal;
        }

        public string GetCustomer()
        {
            var costomer = Load("From Table Customer Where Name == Steve");
            return costomer;
        }

    }
}
