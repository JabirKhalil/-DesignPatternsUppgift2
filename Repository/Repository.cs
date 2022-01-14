using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Patterns_Assignment;

namespace Design_Patterns_Assignment
{
    internal class Repository
    {

        internal static void Run()
        {
            Console.WriteLine("Repository");
            Menu.MenuOptions();

            // Refactor this code so that it uses the Repository Pattern
         


            while (true)
            {
                // Get User Input
                char userInput = Console.ReadKey(true).KeyChar;

                var dataRepository = new SimulatedDatabase();
                string data = dataRepository.Load("Dataset A");
                string customer = "";
                string animal = "";

                switch (userInput)
                {
                    case 'a' or 'A':
                        data = dataRepository.GetData();
                        Console.WriteLine("This is the " +data);
                        break;

                    case 'b' or 'B':
                        customer = dataRepository.GetCustomer();
                        Console.WriteLine("Customer: " + customer);
                        break;

                    case 'c' or 'C':
                        animal = dataRepository.GetAnimal();
                        Console.WriteLine("Animal: " +animal);
                        break;

                    case 'd' or 'D':
                        if (data != "")
                        {
                            dataRepository.Save(data);
                            Console.WriteLine("Saved "+data);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to save");
                        }
                        break;

                    case 'e' or 'E':
                        if (customer != "")
                        {
                            dataRepository.Save(customer);
                            Console.WriteLine("Saved: " +customer);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to save");
                        }
                        break;

                    case 'f' or 'F':
                        if (animal != "")
                        {
                            dataRepository.Save(animal);
                            Console.WriteLine("Saved "+animal);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to save");
                        }

                        break;

                    case 'x' or 'X':
                        Console.Write("Exiting program");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;


                        //var data = SimulatedDatabase.Load("Dataset A");
                        //var customer = SimulatedDatabase.Load("From Table Customer Where Name==Steve"); // this is a search
                        //var animal = SimulatedDatabase.Load("From Table Animal Where Owner==Steve"); // this is a search
                        //SimulatedDatabase.Save(data);
                        //SimulatedDatabase.Save(customer);
                        //SimulatedDatabase.Save(animal);
                        //Console.WriteLine();
                }
            }
        }
    }
}