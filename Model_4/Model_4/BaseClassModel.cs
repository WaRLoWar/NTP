using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    public abstract class BaseClassModel:ICalculationOfFuel
    {
        public BaseClassModel()
        {
            Fuel = 0;
            Distance = 0;
            Result = 0;
        }
        // Растояние [км]        
        public double Distance { get; set; }
        // Расход топлива [л / 100 км]        
        public double Fuel { get; set; }
        public double Result { get; set; }        
        public double GetFloatValue()
        {
            double value;
            do
            {
                Console.Write("Enter a positive number : ");
            }
            while (!double.TryParse(Console.ReadLine(), out value) && (value < 0));
            return value;
        }
        public abstract void AddDistance();
        public abstract void AddFuel();
        public abstract void GetResult();
    }
}
