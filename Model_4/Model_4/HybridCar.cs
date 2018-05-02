using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    public class HybridCar:BaseClassModel
    {
        public override void AddFuel()
        {
            Console.WriteLine("Enter the amount of fuel consumed ");
            Fuel = GetFloatValue();
        }
        public override void AddDistance()
        {
            Console.WriteLine("Enter the distance traveled ");
            Distance = GetFloatValue();
        }
        public override void GetResult()
        {
            if ((Distance < 0) && (Fuel < 0))
            {
                Console.WriteLine("No data entered ! ");
            }
            else
            {
                Result = (Fuel * 100) / Distance;
                Console.WriteLine("Average fuel consumption is {0}  [ liter / 100 km ]", Result);
            }
        }
    }
}
