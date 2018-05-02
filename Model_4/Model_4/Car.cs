using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_4
{
    public class Car :BaseClassModel
    { 
        public override void AddFuel()
        {
            Console.WriteLine("Enter your vehicle's fuel consumption ");            
            Fuel = GetFloatValue();
        }
        public override void AddDistance()
        {
            Console.WriteLine("Enter the distance");
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
                Result = (Fuel * Distance) / 100;
                Console.WriteLine("Fuel consumption is {0}  [ liter / {1} km ]", Result, Distance);
            }
        }
    }

}
 