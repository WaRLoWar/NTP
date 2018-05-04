using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model_4;

namespace ConsoleLoader
{
    class Program
    {
        private static void PrintFirstPartInfo()
        {
            Console.Clear();
            Console.WriteLine("The first part of the menu");
            Console.WriteLine("Select an item from the menu :");
            Console.WriteLine("1. Fuel consumption for vehicle");
            Console.WriteLine("2. Fuel consumption for hybrid vehicles");
            Console.WriteLine("0. Exit");
        }
        static void PrintSecondPart(ITransport source)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Current value :");
            Console.WriteLine("Fuel = {0} , Distance = {1}", source.Fuel,source.Distance);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The second part of the menu");
            Console.WriteLine("Select an item from the menu :");
            Console.WriteLine("1. Add fuel consumption");
            Console.WriteLine("2. Add distance");
            Console.WriteLine("3. Сalculate the final result");
            Console.WriteLine("0. Exit");
        }
        static void Main(string[] args)
        {
            SelectionMenu();
        }
        public static void SelectionMenu()
        {
            bool isExit = false;
            while (!(isExit))
            {
                try
                {
                    PrintFirstPartInfo();
                    int choice = Convert.ToInt32(Console.ReadLine());  
                    if (choice < 0 || choice > 3)
                    {
                        throw new Exception("You entered an incorrect value");
                    }
                    switch (choice)
                    {
                        case 0:
                            {
                                isExit = true;
                                break;
                            }
                        case 1:
                            {
                                UICalculationFuel(new Car());                               
                                break;
                            }
                        case 2:
                            {
                                UICalculationFuel(new Boat());
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("**** Format Exception ! ****");
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine("**** {0} ! **** ",e.Message);
                    Console.ReadKey();
                }
            }
        }
        static void UICalculationFuel(ITransport source)
        {
            bool isExit = false;
            do
            {
                try
                {
                    PrintSecondPart(source);
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice < 0 || choice > 3)
                    {
                        throw new Exception("You entered an incorrect value");
                    }
                    switch(choice)
                    {
                        case 0:
                            {
                                isExit = true;
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("Enter your vehicle's fuel consumption ");
                                source.CostFuel = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter the distance traveled ");
                                source.Distance = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("Fuel consumption is {0}  [ liter / {1} km ]", source.GetResult(), source.Distance);
                                Console.ReadKey();
                                break;
                            }
                    }              
                }
                catch (FormatException)
                {                   
                    Console.WriteLine("**** Format Exception ! ****");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {             
                    Console.WriteLine("**** {0} ! **** ", ex.Message);
                    Console.ReadKey();
                }
            }
            while (!(isExit));
        }
    }
}
